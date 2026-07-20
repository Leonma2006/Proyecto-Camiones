using Microsoft.Data.SqlClient;
using Proyecto_Camiones;

namespace SistemaEntradasSalidas.Datos
{
    public class Conexion
    {
        private readonly SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection(
                Configuracion.CadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();

            return conexion;
        }
    }
}