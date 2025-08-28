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
    public class Expediente
    {
        private int idExpediente;
        private string nombrePa;
        private string apellidoPa;
        private DateTime fechaNacimiento;
        private string telefonoPa;
        private string direccionPa;
        private string correoPa;
        private string dui;
        private int id_Enfermedades;
        private int id_Alergias;

        public int IdExpediente { get => idExpediente; set => idExpediente = value; }
        public string NombrePa { get => nombrePa; set => nombrePa = value; }
        public string ApellidoPa { get => apellidoPa; set => apellidoPa = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TelefonoPa { get => telefonoPa; set => telefonoPa = value; }
        public string DireccionPa { get => direccionPa; set => direccionPa = value; }
        public string CorreoPa { get => correoPa; set => correoPa = value; }
        public string Dui { get => dui; set => dui = value; }
        public int Id_Enfermedades { get => id_Enfermedades; set => id_Enfermedades = value; }
        public int Id_Alergias { get => id_Alergias; set => id_Alergias = value; }


        public static DataTable CargarExpedientes(string Citas)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *from VerExpediente";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public bool InsertarExpediente()
        {

            SqlConnection con = Conexion.Conexion.conectar();


            string comando = "INSERT INTO Paciente (nombrePa, apellidoPa, fechaNacimiento, telefonoPa, direccionPa, correoPa, dui, id_Enfermedades, id_Alergias) " +
                "VALUES (@nombrePa, @apellidoPa, @fechaNacimiento, @telefonoPa, @direccionPa, @correoPa, @dui, @id_Enfermedades, @id_Alergias);";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombrePa", nombrePa);
            cmd.Parameters.AddWithValue("@apellidoPa", apellidoPa);
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@telefonoPa", telefonoPa);
            cmd.Parameters.AddWithValue("@direccionPa", direccionPa);
            cmd.Parameters.AddWithValue("@correoPa", correoPa);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@id_Enfermedades", id_Enfermedades);
            cmd.Parameters.AddWithValue("@id_Alergias", id_Alergias);

            return cmd.ExecuteNonQuery() > 0;

        }
        public bool eliminarExpediente(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "EliminarPaciente @id;";
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
            string consultaQuery = "select idExpediente, nombrePa from Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable CargarCorreo()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idExpediente, correoPa from Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
        public static DataTable CargarApellido()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idExpediente, apellidoPa from Expediente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        #endregion

    }
}