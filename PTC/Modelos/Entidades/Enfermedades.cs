using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Enfermedades
    {
        private int idEnfermedades;
        private string nombreEnfer;

        public int IdEnfermedades { get => idEnfermedades; set => idEnfermedades = value; }
        public string NombreEnfer { get => nombreEnfer; set => nombreEnfer = value; }

        public static DataTable CargarEnfermedades() 
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idEnfermedades, nombreEnfer from Enfermedades";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
