using System;
using Microsoft.Data.SqlClient;

namespace SistemaEntradasSalidas.Datos
{
    public class Conexion
    {
        private readonly SqlConnection conexion = new(
        @"Server=10.21.200.169,1433;
        Database=BITACORA_E_S;
        User Id=BitacoraCamiones;
        Password=bitacoracamiones;
        TrustServerCertificate=True;");

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