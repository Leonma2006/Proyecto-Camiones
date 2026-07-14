using ClosedXML.Excel;
using SistemaEntradasSalidas.Datos;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Camiones
{
    public partial class Form1 : Form
    {
        private bool cargarDatos = true;
        private int Id_registroSeleccionado = -1;

        // NO inicializar aquí para evitar ejecución en tiempo de diseño
        private RegistroDAO registroDAO;
        private OperadorDAO operadorDAO;
        private TransporteDAO transporteDAO;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar DAO en tiempo de ejecución (no en la declaración)
            try
            {
                registroDAO = new RegistroDAO();
                operadorDAO = new OperadorDAO();
                transporteDAO = new TransporteDAO();
            }
            catch (Exception ex)
            {
                // Si hay problema al crear DAOs, mostrar mensaje y evitar fallos en el diseñador
                MessageBox.Show($"Error iniciando acceso a datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigurarGridR();
            ConfigurarGridO();
            ConfigurarGridT();
            CargarCombosR();
            CargarCombosO();
            CargarRegistros();
            dtHoraFinS.Enabled = false;
            dtHoraFinE.Enabled = false;
            dtHoraInE.Enabled = false;
            dtHoraInS.Enabled = false;
            chkFechaE.Enabled = false;
            chkFechaS.Enabled = false;
            lolo.Enabled = true;
            LOL.Enabled = true;
        }

        private void CargarRegistros()
        {
            dgvRegistros.DataSource = registroDAO.Mostrar();
            if (dgvOperador != null) dgvOperador.DataSource = operadorDAO.Mostrar();
            if (dgvTransportes != null) dgvTransportes.DataSource = transporteDAO.Mostrar();
        }

        private void ConfigurarGridR()
        {
            dgvRegistros.ReadOnly = true;
            dgvRegistros.MultiSelect = false;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.AutoGenerateColumns = true;
        }

        private void ConfigurarGridO()
        {
            if (dgvOperador != null)
            {
                dgvOperador.ReadOnly = true;
                dgvOperador.MultiSelect = false;
                dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOperador.AllowUserToAddRows = false;
                dgvOperador.RowHeadersVisible = false;
                dgvOperador.AutoGenerateColumns = true;
            }
        }

        private void ConfigurarGridT()
        {
            if (dgvTransportes != null)
            {
                dgvTransportes.ReadOnly = true;
                dgvTransportes.MultiSelect = false;
                dgvTransportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTransportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransportes.AllowUserToAddRows = false;
                dgvTransportes.RowHeadersVisible = false;
                dgvTransportes.AutoGenerateColumns = true;
            }
        }

        private void CargarCombosR()
        {
            DataTable tablaOp = operadorDAO.ObtenerOperadores();
            DataRow filaOp = tablaOp.NewRow();
            filaOp["Id"] = 0;
            filaOp["nombre"] = "Todos";
            tablaOp.Rows.InsertAt(filaOp, 0);

            cbOp.DataSource = tablaOp;
            cbOp.DisplayMember = "nombre";
            cbOp.ValueMember = "Id";

            DataTable tablaTrans = transporteDAO.ObtenerTransportes();
            DataRow filaTrans = tablaTrans.NewRow();
            filaTrans["Id"] = 0;
            filaTrans["Transporte"] = "Todos";
            tablaTrans.Rows.InsertAt(filaTrans, 0);

            cbTrans.DataSource = tablaTrans;
            cbTrans.DisplayMember = "Transporte";
            cbTrans.ValueMember = "Id";
        }

        private void CargarCombosO()
        {
            // Si hay combos adicionales de operadores en el form, cargar aquí.
        }

        private void CargarRegistroSeleccionadoR()
        {
            if (dgvRegistros.CurrentRow == null) return;

            DataGridViewRow fila = dgvRegistros.CurrentRow;

            // Fecha/Hora Entrada
            if (fila.Cells["FECHA_ENT"].Value != DBNull.Value)
                chkFechaE.Value = Convert.ToDateTime(fila.Cells["FECHA_ENT"].Value);

            if (fila.Cells["HORA"].Value != DBNull.Value)
                dtHoraInE.Value = DateTime.Today + (TimeSpan)fila.Cells["HORA"].Value;

            // Datos básicos
            cbOp.Text = fila.Cells["OPERADOR"].Value?.ToString();
            cbTrans.Text = fila.Cells["Transporte"].Value?.ToString();
            txtPlacas.Text = fila.Cells["PLACAS"].Value?.ToString();
            txtSellos.Text = fila.Cells["SELLOS"].Value?.ToString();
            txtBultos.Text = fila.Cells["BULTOS"].Value?.ToString();
            cbDestino.Text = fila.Cells["DESTINO"].Value?.ToString();
            txtFolio.Text = fila.Cells["FOLIO"].Value?.ToString();

            // Fecha/Hora Salida
            if (fila.Cells["FECHA_SAL"].Value != DBNull.Value)
                chkFechaS.Value = Convert.ToDateTime(fila.Cells["FECHA_SAL"].Value);

            if (fila.Cells["HORA_S"].Value != DBNull.Value)
                dtHoraInS.Value = DateTime.Today + (TimeSpan)fila.Cells["HORA_S"].Value;

            // Ids
            cbOp.SelectedValue = fila.Cells["ID_OPERADOR"].Value;
            cbTrans.SelectedValue = fila.Cells["ID_TRANSPORTE"].Value;

            string tipo = fila.Cells["DESTINO"].Value?.ToString();
            if (!string.IsNullOrEmpty(tipo))
            {
                if (tipo.Trim().ToUpper() == "ENTRADA")
                    cbDestino.SelectedIndex = 1;
                else if (tipo.Trim().ToUpper() == "SALIDA")
                    cbDestino.SelectedIndex = 2;
                else
                    cbDestino.SelectedIndex = 0;
            }

            Id_registroSeleccionado = Convert.ToInt32(fila.Cells["ID_REGISTRO"].Value);
        }

        private void LimpiarFormulario()
        {
            if (cbOp.DataSource != null) cbOp.SelectedIndex = -1;
            if (cbTrans.DataSource != null) cbTrans.SelectedIndex = -1;

            txtPlacas.Clear();
            txtSellos.Clear();
            txtBultos.Clear();
            txtFolio.Clear();

            cbDestino.SelectedIndex = -1;

            chkFechaE.Value = DateTime.Today;
            dtHoraInE.Value = DateTime.Now;
            dtHoraFinE.Value = DateTime.Now;

            chkFechaS.Value = DateTime.Today;
            dtHoraInS.Value = DateTime.Now;
            dtHoraFinS.Value = DateTime.Now;
        }

        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            if (!cargarDatos) return;
            if (dgvRegistros.CurrentRow == null) return;
            CargarRegistroSeleccionadoR();
        }

        private void dgvRegistros_SelectionChanged_1(object sender, EventArgs e)
        {
            // compatibilidad con eventhandler generado en designer
            dgvRegistros_SelectionChanged(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // placeholder: puedes completar la lógica de búsqueda específica aquí
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cargarDatos = false;
            dgvRegistros.ClearSelection();
            LimpiarFormulario();
            cargarDatos = true;
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
                {
                    hoja.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            hoja.Columns().AdjustToContents();
            libro.SaveAs(guardar.FileName);
            MessageBox.Show("Archivo exportado correctamente.");
        }

        private void btnExportar_Click(object sender, EventArgs e) => ExportarExcel(dgvRegistros);

        private void btnConexion_Click(object sender, EventArgs e)
        {
            Conexion cn = new();
            try
            {
                cn.AbrirConexion();
                MessageBox.Show("Conexión exitosa");
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            string destino = cbDestino.Text;
            int idTransporte = Convert.ToInt32(cbTrans.SelectedValue);
            DateTime fecha = chkFechaE.Value.Date;
            TimeSpan horaInicioE = dtHoraInE.Value.TimeOfDay;
            TimeSpan horaSalidaE = dtHoraFinE.Value.TimeOfDay;
            TimeSpan horaInicioS = dtHoraInS.Value.TimeOfDay;
            TimeSpan horaFinS = dtHoraFinS.Value.TimeOfDay;
            int IdOperador = Convert.ToInt32(cbOp.SelectedValue);
            string folio = txtFolio.Text;
            string placas = txtPlacas.Text;
            string sellos = txtSellos.Text;

            dgvRegistros.DataSource = registroDAO.Filtrar(IdOperador,
                idTransporte,
                LOL.Checked,
                chkHoraE.Checked,
                horaInicioE,
                horaSalidaE,
                fecha,
                lolo.Checked,
                chkHoraS.Checked,
                destino,
                horaInicioS,
                horaFinS,
                folio, placas, sellos);
        }

        private void txtBultos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            bool ok = registroDAO.ActualizarRegistro(
               Id_registroSeleccionado,
               chkFechaE.Value.Date,
               dtHoraInE.Value.TimeOfDay,
               Convert.ToInt32(cbOp.SelectedValue),
               txtPlacas.Text,
               Convert.ToInt32(cbTrans.SelectedValue),
               txtSellos.Text,
               txtBultos.Text,
               cbDestino.Text,
               txtFolio.Text,
               chkFechaS.Value.Date,
               dtHoraInS.Value.TimeOfDay
           );

            if (ok)
            {
                MessageBox.Show("Registro actualizado correctamente.");
                dgvRegistros.DataSource = registroDAO.Mostrar();
            }
            else
            {
                MessageBox.Show("No fue posible actualizar el registro.");
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                registroDAO.EliminarRegistro(Id_registroSeleccionado);
                CargarRegistros();
                LimpiarFormulario();
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            bool ok = registroDAO.NuevoRegistro(
                chkFechaE.Value.Date,
                dtHoraInE.Value.TimeOfDay,
                Convert.ToInt32(cbOp.SelectedValue),
                txtPlacas.Text,
                Convert.ToInt32(cbTrans.SelectedValue),
                txtSellos.Text,
                txtBultos.Text,
                cbDestino.Text,
                txtFolio.Text,
                chkFechaS.Value.Date,
                dtHoraInS.Value.TimeOfDay
            );

            if (ok)
            {
                MessageBox.Show("Registro ingresado correctamente.");
                dgvRegistros.DataSource = registroDAO.Mostrar();
            }
            else
            {
                MessageBox.Show("No fue posible ingresar el registro.");
            }
        }

        private void chkHoraS_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void chkFechaS_CheckedChanged(object sender, EventArgs e)
        {
            lolo.Enabled = lolo.Checked;
        }

        private void chkHoraE_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkFechaE_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void chkHoraE_CheckedChanged_1(object sender, EventArgs e)
        {
            dtHoraInE.Enabled = chkHoraE.Checked;
            dtHoraFinE.Enabled = chkHoraE.Checked;
        }

        private void chkHoraS_CheckedChanged(object sender, EventArgs e)
        {
            dtHoraInS.Enabled = chkHoraS.Checked;
            dtHoraFinS.Enabled = chkHoraS.Checked;
        }

        private void lolo_CheckedChanged(object sender, EventArgs e)
        {
            chkFechaS.Enabled = lolo.Checked;
        }

        private void LOL_CheckedChanged(object sender, EventArgs e)
        {

            chkFechaE.Enabled = LOL.Checked;
        }

    }
}
