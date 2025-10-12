using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
                string comando = "select idPaciente, nombrePa + ' ' + apellidoPA as [Paciente], correoPa as Correo, dui as Dui from Paciente P inner join Expediente E on E.idExpediente = P.id_Expediente";
                SqlDataAdapter ad = new SqlDataAdapter(comando, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }

        #endregion


    }
}
