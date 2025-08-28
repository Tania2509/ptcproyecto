using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    internal class Alergias
    {
        private int idAlergias;
        private string nombreAl;

        public int IdAlergias { get => idAlergias; set => idAlergias = value; }
        public string NombreAl { get => nombreAl; set => nombreAl = value; }

        public static DataTable CargarAlergias()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idAlergias, nombreAl from Alergias";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
