using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using SistemaEntradasSalidas.Datos;

namespace Proyecto_Camiones
{
    public partial class Transporte : Form
    {
        private bool cargarDatos = true;
        private int Id_TransporteSeleccionado = -1;

        // NO inicializar aquí
        private RegistroDAO registroDAO;
        private OperadorDAO operadorDAO;
        private TransporteDAO transporteDAO;

        public Transporte()
        {
            InitializeComponent();
        }

        private void Transporte_Load(object sender, EventArgs e)
        {
            try
            {
                registroDAO = new RegistroDAO();
                operadorDAO = new OperadorDAO();
                transporteDAO = new TransporteDAO();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error iniciando acceso a datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarRegistros();
            ConfigurarGridT();
        }

        private void CargarRegistros()
        {
            dgvTransportes.DataSource = transporteDAO.Mostrar();
        }

        private void ConfigurarGridT()
        {
            dgvTransportes.ReadOnly = true;
            dgvTransportes.MultiSelect = false;
            dgvTransportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransportes.AllowUserToAddRows = false;
            dgvTransportes.RowHeadersVisible = false;
            dgvTransportes.AutoGenerateColumns = true;
        }

        private void CargarRegistroSeleccionadoT()
        {
            if (dgvTransportes.CurrentRow == null) return;
            DataGridViewRow fila = dgvTransportes.CurrentRow;
            txtMarca.Text = fila.Cells["Marca"].Value?.ToString();
            txtTransporte.Text = fila.Cells["Transporte"].Value?.ToString();
            Id_TransporteSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
        }

        private void dgvTransportes_SelectionChanged(object sender, EventArgs e)
        {
            if (!cargarDatos) return;
            if (dgvTransportes.CurrentRow == null) return;
            CargarRegistroSeleccionadoT();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMarca.Clear();
            txtTransporte.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Ajuste de orden: TransporteDAO.ActualizarRegistro(int IdTransporte, string Transporte, string Marca)
            bool ok = transporteDAO.ActualizarRegistro(Id_TransporteSeleccionado, txtTransporte.Text, txtMarca.Text);
            if (ok)
            {
                MessageBox.Show("Registro actualizado correctamente.");
                CargarRegistros();
            }
            else
            {
                MessageBox.Show("No fue posible actualizar el registro.");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dgvTransportes.DataSource = transporteDAO.Filtrar(txtTransporte.Text, txtMarca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ajuste de orden: NuevoRegistro(transporte, marca)
            transporteDAO.NuevoRegistro(txtTransporte.Text, txtMarca.Text);
            CargarRegistros();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                transporteDAO.EliminarRegistro(Id_TransporteSeleccionado);
                CargarRegistros();
                txtMarca.Clear();
                txtTransporte.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e) => ExportarExcel(dgvTransportes);

        private void ExportarExcel(DataGridView dgv)
        {
            SaveFileDialog guardar = new() { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "Registros.xlsx" };
            if (guardar.ShowDialog() != DialogResult.OK) return;

            using var libro = new XLWorkbook();
            var hoja = libro.Worksheets.Add("Datos");
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                hoja.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                hoja.Cell(1, i + 1).Style.Font.Bold = true;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                    hoja.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
            }
            hoja.Columns().AdjustToContents();
            libro.SaveAs(guardar.FileName);
            MessageBox.Show("Archivo exportado correctamente.");
        }
    }
}
