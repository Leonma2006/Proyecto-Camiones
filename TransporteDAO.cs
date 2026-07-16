using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaEntradasSalidas.Datos
{
    public class TransporteDAO
    {
        Conexion conexion = new();

        public DataTable ObtenerTransportes()
        {
            DataTable tabla = new();

            string sql = @"SELECT Id, Transporte
                           FROM MAESTRO_TRANS
                           ORDER BY Transporte";

            SqlDataAdapter da = new(sql, conexion.AbrirConexion());

            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar()
        {
            DataTable tabla = new();

            string sql = @"

SELECT
Id,
Transporte,
Marca
from   MAESTRO_TRANS
ORDER BY Id";

            SqlDataAdapter da = new(sql, conexion.AbrirConexion());

            da.Fill(tabla);

            conexion.CerrarConexion();

            return tabla;

        }

        public DataTable Filtrar(string Transporte, string Marca)
        {
            DataTable tabla = new();

            string sql = @"
SELECT
Id, Transporte, Marca

FROM MAESTRO_TRANS 

WHERE 1 = 1";
            if (!string.IsNullOrEmpty(Transporte))
            {
                sql += " AND Transporte = @Transporte";
            }
            if (!string.IsNullOrEmpty(Marca))
            {
                sql += " AND Marca = @Marca";
            }
            sql += " ORDER BY Id";

            SqlCommand cmd = new(sql, conexion.AbrirConexion());

            if (!string.IsNullOrEmpty(Transporte))
            {
                cmd.Parameters.AddWithValue("@Transporte", Transporte);
            }
            if (!string.IsNullOrEmpty(Marca))
            {
                cmd.Parameters.AddWithValue("@Marca", Marca);
            }
            SqlDataAdapter da = new(cmd);

            da.Fill(tabla);

            conexion.CerrarConexion();

            return tabla;
        }

        public bool EliminarRegistro(int idTransporte)
        {
            string sql = "DELETE FROM MAESTRO_TRANS WHERE Id=@idTransporte";
            SqlCommand cmd = new(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idTransporte", idTransporte);
            bool eliminado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return eliminado;
        }


        public bool ActualizarRegistro(int IdTransporte, string Transporte, string Marca)
        {
            string sql = @"
    UPDATE MAESTRO_TRANS
    SET
        Transporte = @Transporte,
        Marca = @Marca
    WHERE Id = @IdTransporte";

            SqlCommand cmd = new SqlCommand(sql, conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@IdTransporte", IdTransporte);
            cmd.Parameters.AddWithValue("@Transporte", Transporte);
            cmd.Parameters.AddWithValue("@Marca", Marca);

            bool actualizado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return actualizado;
        }


        public bool NuevoRegistro(string Transporte, string Marca)
        {
            string sql = @"
    INSERT INTO MAESTRO_TRANS(
   Transporte, Marca)
    VALUES(@Transporte, @Marca)";

            SqlCommand cmd = new SqlCommand(sql, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@Transporte", Transporte);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            bool insertado = cmd.ExecuteNonQuery() > 0;
            conexion.CerrarConexion();
            return insertado;
        }



    }

    
}
