﻿using System;
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

        public static SqlConnection conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={database};Integrated Security=true;";

            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();
            return conexion;
        }
    }
}
