using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Paciente
    {

        #region ComboBox

        public static DataTable CargarPacientes()
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string comando = "SELECT Expediente, [Nombre del Paciente], [Apellido del paciente], [Correo del paciente] FROM VerExpediente";
                SqlDataAdapter ad = new SqlDataAdapter(comando, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }

        #endregion


    }
}
