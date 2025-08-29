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

        public static DataTable CargarNombre()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, nombrePa from Paciente P left join Expediente E on E.idExpediente=P.id_Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable CargarCorreo()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, correoPa from Paciente P left join Expediente E on E.idExpediente=P.id_Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
        public static DataTable CargarApellido()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, apellidoPa from Paciente P left join Expediente E on E.idExpediente=P.id_Expediente\r\n";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        #endregion


    }
}
