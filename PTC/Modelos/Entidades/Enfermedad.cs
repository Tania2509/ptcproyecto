using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Modelos.Entidades
{
    public class Enfermedad
    {
        private int idEnfermedades;
        private string nombreEnfer;

        public int IdEnfermedades { get => idEnfermedades; set => idEnfermedades = value; }
        public string NombreEnfer { get => nombreEnfer; set => nombreEnfer = value; }

        public static DataTable CargarExpedientes(string Citas)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *from VerExpediente";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
    }
}
