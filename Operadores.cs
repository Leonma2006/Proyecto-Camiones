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

        bool validar()
        {
            if(cbTrans3.SelectedIndex == -1 || cbTrans3.SelectedIndex==0)
            {
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                return false;
            }
            return true;
        }
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
            string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            SaveFileDialog guardar = new()
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = "Operadores_" + fecha + ".xlsx"
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
            if (validar())
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
            if (validar())
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

        private void dgvOperador_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!cargarDatos) return;
            if (dgvOperador.CurrentRow == null) return;
            CargarRegistroSeleccionadoO();
        }
    }
}