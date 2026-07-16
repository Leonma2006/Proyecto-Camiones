using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace SistemaEntradasSalidas.Datos
{
    public class RegistroDAO
    {
        Conexion conexion = new();

        public DataTable Mostrar()
        {
            DataTable tabla = new();

            string sql = @"
SELECT
R.ID_REGISTRO,
O.Id AS ID_OPERADOR,
T.Id AS ID_TRANSPORTE,
R.FECHA_ENT,
R.HORA,
R.NOMBRE_PROV,
O.nombre AS OPERADOR,
T.Transporte,
T.Marca,
R.PLACAS,
R.SELLOS,
R.BULTOS,
R.DESTINO,
R.FOLIO,
R.FECHA_SAL,
R.HORA_S
FROM REGISTROS_E_S R
LEFT JOIN MAESTRO_OP O ON R.ID_PROV = O.Id
LEFT JOIN MAESTRO_TRANS T ON R.ID_TRANS = T.Id
ORDER BY R.ID_REGISTRO";

            SqlDataAdapter da = new(sql, conexion.AbrirConexion());
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Filtrar(int idOperador,
            int idTransporte,
            bool usarInicioE,
            TimeSpan horainicioE,
            TimeSpan horaFinE,
            DateTime fecha,
            bool usarInicioS,
            string destino,
            TimeSpan horaInicioS,
            TimeSpan horaFinS,
            string folio,
            string placas,
            string sellos)
        {
            DataTable tabla = new();
            string sql = @"
SELECT
R.ID_REGISTRO,
O.Id AS ID_OPERADOR,
T.Id AS ID_TRANSPORTE,
R.FECHA_ENT,
R.HORA,
R.NOMBRE_PROV,
O.nombre AS OPERADOR,
T.Transporte,
T.Marca,
R.PLACAS,
R.SELLOS,
R.BULTOS,
R.DESTINO,
R.FOLIO,
R.FECHA_SAL,
R.HORA_S
FROM REGISTROS_E_S R
LEFT JOIN MAESTRO_OP O ON R.ID_PROV = O.Id
LEFT JOIN MAESTRO_TRANS T ON R.ID_TRANS = T.Id
WHERE 1 = 1";

            if (idOperador != 0) sql += " AND O.Id=@idOperador";
            if (idTransporte != 0) sql += " AND T.Id=@idTransporte";
            if (usarInicioE) sql += " AND R.HORA between @horaInicioE and @horaFinE";
            if (usarInicioS) sql += " AND R.HORA_S between @horaInicioS and @horaFinS";
            if (!string.IsNullOrEmpty(destino) && destino != "TODOS") sql += " AND R.DESTINO = @destino";
            if (!string.IsNullOrEmpty(folio)) sql += " AND R.FOLIO = @folio";
            if (!string.IsNullOrEmpty(placas)) sql += " AND R.PLACAS = @placas";
            if (!string.IsNullOrEmpty(sellos)) sql += " AND R.SELLOS = @sellos";

            sql += " ORDER BY R.ID_REGISTRO";

            SqlCommand cmd = new(sql, conexion.AbrirConexion());

            if (idOperador != 0) cmd.Parameters.AddWithValue("@idOperador", idOperador);
            if (idTransporte != 0) cmd.Parameters.AddWithValue("@idTransporte", idTransporte);
            if (usarInicioE)
            {
                cmd.Parameters.AddWithValue("@horaInicioE", horainicioE);
                cmd.Parameters.AddWithValue("@horaFinE", horaFinE);
            }
            if (usarInicioS)
            {
                cmd.Parameters.AddWithValue("@horaInicioS", horaInicioS);
                cmd.Parameters.AddWithValue("@horaFinS", horaFinS);
            }
            if (!string.IsNullOrEmpty(destino) && destino != "TODOS") cmd.Parameters.AddWithValue("@destino", destino);
            if (!string.IsNullOrEmpty(folio)) cmd.Parameters.AddWithValue("@folio", folio);
            if (!string.IsNullOrEmpty(placas)) cmd.Parameters.AddWithValue("@placas", placas);
            if (!string.IsNullOrEmpty(sellos)) cmd.Parameters.AddWithValue("@sellos", sellos);

            SqlDataAdapter da = new(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public bool EliminarRegistro(int idRegistro)
        {
            string sql = "DELETE FROM REGISTROS_E_S WHERE ID_REGISTRO=@idRegistro";
            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idRegistro", idRegistro);
            bool eliminado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return eliminado;
        }

        public bool ActualizarRegistro(
            int idRegistro,
            DateTime fechaEntrada,
            TimeSpan horaEntrada,
            int idOperador,
            string placas,
            int idTransporte,
            string sellos,
            string bultos,
            string destino,
            string folio,
            DateTime? fechaSalida,
            TimeSpan? horaSalida)
        {
            string sql = @"
UPDATE REGISTROS_E_S
SET
    FECHA_ENT = @FECHA_ENT,
    HORA = @HORA,
    ID_PROV = @ID_PROV,
    PLACAS = @PLACAS,
    ID_TRANS = @ID_TRANS,
    SELLOS = @SELLOS,
    BULTOS = @BULTOS,
    DESTINO = @DESTINO,
    FOLIO = @FOLIO,
    FECHA_SAL = @FECHA_SAL,
    HORA_S = @HORA_S
WHERE ID_REGISTRO = @ID_REGISTRO";

            SqlCommand cmd = new(sql, conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@ID_REGISTRO", idRegistro);
            cmd.Parameters.AddWithValue("@FECHA_ENT", fechaEntrada);
            cmd.Parameters.AddWithValue("@HORA", horaEntrada);
            cmd.Parameters.AddWithValue("@ID_PROV", idOperador);
            cmd.Parameters.AddWithValue("@PLACAS", placas);
            cmd.Parameters.AddWithValue("@ID_TRANS", idTransporte);
            cmd.Parameters.AddWithValue("@SELLOS", sellos);
            cmd.Parameters.AddWithValue("@BULTOS", bultos);
            cmd.Parameters.AddWithValue("@DESTINO", destino ?? string.Empty);
            cmd.Parameters.AddWithValue("@FOLIO", folio ?? string.Empty);

            if (fechaSalida.HasValue)
                cmd.Parameters.AddWithValue("@FECHA_SAL", fechaSalida.Value);
            else
                cmd.Parameters.AddWithValue("@FECHA_SAL", DBNull.Value);

            if (horaSalida.HasValue)
                cmd.Parameters.AddWithValue("@HORA_S", horaSalida.Value);
            else
                cmd.Parameters.AddWithValue("@HORA_S", DBNull.Value);

            bool actualizado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return actualizado;
        }

        public bool NuevoRegistro(
            DateTime fechaEntrada,
            TimeSpan horaEntrada,
            int idOperador,
            string placas,
            int idTransporte,
            string sellos,
            string bultos,
            string destino,
            string folio,
            DateTime? fechaSalida,
            TimeSpan? horaSalida)
        {
            string sql = @"
INSERT INTO REGISTROS_E_S
(
    FECHA_ENT,
    HORA,
    ID_PROV,
    PLACAS,
    ID_TRANS,
    SELLOS,
    BULTOS,
    DESTINO,
    FOLIO,
    FECHA_SAL,
    HORA_S
)
VALUES
(
    @FECHA_ENT,
    @HORA,
    @ID_PROV,
    @PLACAS,
    @ID_TRANS,
    @SELLOS,
    @BULTOS,
    @DESTINO,
    @FOLIO,
    @FECHA_SAL,
    @HORA_S
)";

            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@FECHA_ENT", fechaEntrada);
            cmd.Parameters.AddWithValue("@HORA", horaEntrada);
            cmd.Parameters.AddWithValue("@ID_PROV", idOperador);
            cmd.Parameters.AddWithValue("@PLACAS", placas);
            cmd.Parameters.AddWithValue("@ID_TRANS", idTransporte);
            cmd.Parameters.AddWithValue("@SELLOS", sellos);
            cmd.Parameters.AddWithValue("@BULTOS", bultos);
            cmd.Parameters.AddWithValue("@DESTINO", destino ?? string.Empty);
            cmd.Parameters.AddWithValue("@FOLIO", folio ?? string.Empty);

            if (fechaSalida.HasValue)
                cmd.Parameters.AddWithValue("@FECHA_SAL", fechaSalida.Value);
            else
                cmd.Parameters.AddWithValue("@FECHA_SAL", DBNull.Value);

            if (horaSalida.HasValue)
                cmd.Parameters.AddWithValue("@HORA_S", horaSalida.Value);
            else
                cmd.Parameters.AddWithValue("@HORA_S", DBNull.Value);

            bool insertado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return insertado;
        }
    }
}