using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class Conexion
    {
        private static string servidor = "ODIE\\SQLEXPRESS01";
        private static string database = "ClinicaDental";


        //private static string servidor = "SQL9001.site4now.net";
        //private static string database = "db_abf0b9_clinica";




        public static SqlConnection conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={database};Integrated Security=true;";

            //string cadena = $"Data Source=SQL9001.site4now.net;Initial Catalog=db_abf0b9_clinica;User Id=db_abf0b9_clinica_admin;Password=Pass1234;";

            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();
            return conexion;
        }
    }
}
