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

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtTransporte.Text))
            {
                MessageBox.Show("El campo Transporte no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("El campo Marca no puede estar vacío.");
                return false;
            }
            return true;    
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
            ConfigurarGridT();
            CargarRegistros();

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
            if (dgvTransportes.CurrentRow == null)
            {
                return;
            }
            DataGridViewRow fila = dgvTransportes.CurrentRow;
            txtMarca.Text = fila.Cells["Marca"].Value?.ToString();
            txtTransporte.Text = fila.Cells["Transporte"].Value?.ToString();
            Id_TransporteSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMarca.Clear();
            txtTransporte.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
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
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dgvTransportes.DataSource = transporteDAO.Filtrar(txtTransporte.Text, txtMarca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                transporteDAO.NuevoRegistro(txtTransporte.Text, txtMarca.Text);
                CargarRegistros();
            }
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
            string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            SaveFileDialog guardar = new()
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = "Transporte_" + fecha + ".xlsx"
            };
            if (guardar.ShowDialog() != DialogResult.OK) return;

            using var libro = new XLWorkbook();
            var hoja = libro.Worksheets.Add("Sheet1");

            // Dejar espacio: fila y columna inicial
            int filaInicio = 3; // empieza en la fila 3
            int colInicio = 2;  // empieza en la columna 2

            // Encabezado personalizado (sin color de fondo)
            hoja.Cell(filaInicio, colInicio).Value = "Generador el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            hoja.Range(filaInicio, colInicio, filaInicio, colInicio + dgv.Columns.Count - 1).Merge();
            hoja.Cell(filaInicio, colInicio).Style.Font.Bold = true;

            // Encabezados de columnas (verde oscuro con texto blanco)
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                var celda = hoja.Cell(filaInicio + 1, colInicio + i);
                celda.Value = dgv.Columns[i].HeaderText;
                celda.Style.Font.Bold = true;
                celda.Style.Fill.BackgroundColor = XLColor.Green;
                celda.Style.Font.FontColor = XLColor.White;
                celda.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                celda.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            }

            // Datos (verde claro con bordes)
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    var celda = hoja.Cell(filaInicio + 2 + i, colInicio + j);
                    celda.Value = dgv.Rows[i].Cells[j].Value?.ToString();
                    celda.Style.Fill.BackgroundColor = XLColor.LightGreen;
                    celda.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    celda.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                }
            }

            hoja.Columns().AdjustToContents();
            libro.SaveAs(guardar.FileName);
            MessageBox.Show("Archivo exportado correctamente.");
        }

        private void dgvTransportes_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!cargarDatos) return;
            if (dgvTransportes.CurrentRow == null) return;
            CargarRegistroSeleccionadoT();
        }
    }
}
