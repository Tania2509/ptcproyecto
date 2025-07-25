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
    public class Cita
    {
        private int idCita;
        private string razonCita;
        private DateTime fechaHoraCita;
        private int id_Paciente;

        public int IdCita { get => idCita; set => idCita = value; }
        public string RazonCita { get => razonCita; set => razonCita = value; }
        public DateTime FechaHoraCita { get => fechaHoraCita; set => fechaHoraCita = value; }
        public int Id_Paciente { get => id_Paciente; set => id_Paciente = value; }

        public static DataTable CargarCitas(string Citas)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *From DatosCita";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public bool InsertarCitas()
        {
            SqlConnection con = Conexion.Conexion.conectar();

            string comando = "Insert into Cita(razonCita,fechaHoraCita, id_Paciente) " +
                     "values(@razonCita, @fechaHoraCita, @id_Paciente);";

            SqlCommand cmd = new SqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@razonCita", razonCita);
            cmd.Parameters.AddWithValue("@fechaHoraCita", fechaHoraCita);
            cmd.Parameters.AddWithValue("@id_Paciente", id_Paciente);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool eliminarCita(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "Delete from Cita where idCita = @id;";
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
    }
}
