using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Diente
    {
        public DataTable CargarDientes()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select idDiente,codigo as [N.], descripcion as Diente from Diente";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
    }   
}
