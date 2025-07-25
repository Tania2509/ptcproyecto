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
        private int idPaciente;
        private string nombrePa;
        private string apellidoPa;
        private DateTime fechaNacimiento;
        private string telefonoPa;
        private string direccionPa;
        private string correoPa;
        private string dui;
        private int id_Expediente;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePa { get => nombrePa; set => nombrePa = value; }
        public string ApellidoPa { get => apellidoPa; set => apellidoPa = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TelefonoPa { get => telefonoPa; set => telefonoPa = value; }
        public string DireccionPa { get => direccionPa; set => direccionPa = value; }
        public string CorreoPa { get => correoPa; set => correoPa = value; }
        public string Dui { get => dui; set => dui = value; }

        public int Id_Expediente { get => idPaciente; set => idPaciente = value; }


        public static DataTable CargarExpedientes(string Citas)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *from VerExpediente";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public bool InsertarPaciente()
        {

            SqlConnection con = Conexion.Conexion.conectar();


            string comando = "INSERT INTO Paciente (nombrePa, apellidoPa, fechaNacimiento, telefonoPa, direccionPa, correoPa, dui, id_Expediente) " +
                "VALUES (@nombrePa, @apellidoPa, @fechaNacimiento, @telefonoPa, @direccionPa, @correoPa, @dui, @id_Expediente);";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombrePa", nombrePa);
            cmd.Parameters.AddWithValue("@apellidoPa", ApellidoPa);
            cmd.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@telefonoPa", TelefonoPa);
            cmd.Parameters.AddWithValue("@direccionPa", DireccionPa);
            cmd.Parameters.AddWithValue("@correoPa", CorreoPa);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@id_Expediente", Id_Expediente);

            return cmd.ExecuteNonQuery() > 0;

        }

        public bool eliminarPaciente(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "Delete from Paciente where idPaciente = @id;";
            SqlCommand delete = new SqlCommand(consultaDelete, conexion);
            delete.Parameters.AddWithValue("@id", id);
            if (delete.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eliminando Registros", "Exito al eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }

        }

        #region ComboBox

        public static DataTable CargarNombre()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, nombrePa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable CargarCorreo()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, correoPa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
        public static DataTable CargarApellido()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaciente, apellidoPa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        #endregion

    }
}
