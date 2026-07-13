
using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaEntradasSalidas.Datos
{
    public class OperadorDAO
    {
        private readonly Conexion conexion = new();

        public DataTable ObtenerOperadores()
        {
            DataTable tabla = new();
            string sql = @"SELECT Id, nombre FROM MAESTRO_OP ORDER BY nombre";
            SqlDataAdapter da = new(sql, conexion.AbrirConexion());
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar()
        {
            DataTable tabla = new();
            string sql = @"SELECT Id, nombre, id_transporte FROM MAESTRO_OP ORDER BY Id DESC";
            SqlDataAdapter da = new(sql, conexion.AbrirConexion());
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Filtrar(string nombre, int idTransporte)
        {
            DataTable tabla = new();
            string sql = @"SELECT Id, nombre, id_transporte FROM MAESTRO_OP WHERE 1=1";
            if (!string.IsNullOrEmpty(nombre)) sql += " AND nombre = @nombre";
            if (idTransporte != 0) sql += " AND id_transporte = @idTransporte";
            sql += " ORDER BY Id DESC";

            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            if (!string.IsNullOrEmpty(nombre)) cmd.Parameters.AddWithValue("@nombre", nombre);
            if (idTransporte != 0) cmd.Parameters.AddWithValue("@idTransporte", idTransporte);

            SqlDataAdapter da = new(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public bool NuevoRegistro(string nombre, int idTransporte)
        {
            string sql = @"INSERT INTO MAESTRO_OP (nombre, id_transporte) VALUES (@nombre, @idTransporte)";
            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@idTransporte", idTransporte);
            bool insertado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return insertado;
        }

        public bool ActualizarRegistro(int id, string nombre, int idTransporte)
        {
            string sql = @"UPDATE MAESTRO_OP SET nombre = @nombre, id_transporte = @idTransporte WHERE Id = @id";
            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@idTransporte", idTransporte);
            bool actualizado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return actualizado;
        }

        public bool EliminarRegistro(int id)
        {
            string sql = "DELETE FROM MAESTRO_OP WHERE Id=@id";
            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);
            bool eliminado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return eliminado;
        }
    }
}