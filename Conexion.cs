using System;
using Microsoft.Data.SqlClient;

namespace SistemaEntradasSalidas.Datos
{
    public class Conexion
    {
        private readonly SqlConnection conexion = new(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BITACORA_E_S;Integrated Security=True;TrustServerCertificate=True;");

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