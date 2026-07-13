using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using SistemaEntradasSalidas.Datos;

namespace Proyecto_Camiones
{
    public partial class Operadores : Form
    {
        private bool cargarDatos = true;
        private int Id_OperadorSeleccionado = -1;

        // NO inicializar aquí para evitar ejecución en tiempo de diseño
        private RegistroDAO registroDAO;
        private OperadorDAO operadorDAO;
        private TransporteDAO transporteDAO;

        public Operadores()
        {
            InitializeComponent();
        }

        private void Operadores_Load(object sender, EventArgs e)
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

            CargarCombosO();
            ConfigurarGridO();
            CargarRegistros();
        }

        private void CargarRegistros()
        {
            dgvOperador.DataSource = operadorDAO.Mostrar();
        }

        private void CargarRegistroSeleccionadoO()
        {
            if (dgvOperador.CurrentRow == null) return;

            DataGridViewRow fila = dgvOperador.CurrentRow;
            txtNombre.Text = fila.Cells["nombre"].Value?.ToString();
            if (fila.Cells["id_transporte"].Value != DBNull.Value)
                cbTrans3.SelectedValue = fila.Cells["id_transporte"].Value;
            Id_OperadorSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
        }

        private void ConfigurarGridO()
        {
            dgvOperador.ReadOnly = true;
            dgvOperador.MultiSelect = false;
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOperador.AllowUserToAddRows = false;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.AutoGenerateColumns = true;
        }

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

        private void btnConexion_Click(object sender, EventArgs e)
        {
            Conexion cn = new();
            try
            {
                cn.AbrirConexion();
                MessageBox.Show("Conexión exitosa");
                cn.CerrarConexion();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvOperador_SelectionChanged(object sender, EventArgs e)
        {
            if (!cargarDatos) return;
            if (dgvOperador.CurrentRow == null) return;
            CargarRegistroSeleccionadoO();
        }

        private void CargarCombosO()
        {
            DataTable tablaTrans = transporteDAO.ObtenerTransportes();
            DataRow filaTrans = tablaTrans.NewRow();
            filaTrans["Id"] = 0;
            filaTrans["Transporte"] = "Todos";
            tablaTrans.Rows.InsertAt(filaTrans, 0);

            cbTrans3.DataSource = tablaTrans;
            cbTrans3.DisplayMember = "Transporte";
            cbTrans3.ValueMember = "Id";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool ok = operadorDAO.NuevoRegistro(txtNombre.Text, Convert.ToInt32(cbTrans3.SelectedValue));
            if (ok)
            {
                MessageBox.Show("Registro ingresado correctamente.");
                CargarRegistros();
                CargarCombosO();
            }
            else
            {
                MessageBox.Show("No fue posible ingresar el registro.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dgvOperador.DataSource = operadorDAO.Filtrar(txtNombre.Text, Convert.ToInt32(cbTrans3.SelectedValue));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Id_OperadorSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }
            bool ok = operadorDAO.EliminarRegistro(Id_OperadorSeleccionado);
            if (ok)
            {
                MessageBox.Show("Registro eliminado correctamente.");
                CargarRegistros();
                CargarCombosO();
            }
            else MessageBox.Show("No fue posible eliminar el registro.");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            bool ok = operadorDAO.ActualizarRegistro(Id_OperadorSeleccionado, txtNombre.Text, Convert.ToInt32(cbTrans3.SelectedValue));
            if (ok)
            {
                MessageBox.Show("Registro actualizado correctamente.");
                CargarRegistros();
                CargarCombosO();
            }
            else MessageBox.Show("No fue posible actualizar el registro.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadorDAO.EliminarRegistro(Id_OperadorSeleccionado);
                CargarRegistros();
                CargarCombosO();
                txtNombre.Clear();
                cbTrans3.SelectedIndex = -1;
            }
        }

        private void button7_Click(object sender, EventArgs e) => ExportarExcel(dgvOperador);

        private void button12_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cbTrans3.SelectedIndex = -1;
            if (dgvOperador.DataSource != null) dgvOperador.ClearSelection();
            Id_OperadorSeleccionado = -1;
        }
    }
}