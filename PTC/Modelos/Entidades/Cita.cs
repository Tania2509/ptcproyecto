using Modelos.Conexion;
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


        public bool ActualizarCita()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "update Cita set razonCita =@razonCita , fechaHoraCita = @fechaHoraCita , id_Paciente = @id_Paciente where idCita = @idCita";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@razonCita", razonCita);
            cmd.Parameters.AddWithValue("@fechaHoraCita", fechaHoraCita);
            cmd.Parameters.AddWithValue("@id_Paciente", id_Paciente);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Buscar(string termino)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = $"select *from DatosCita where [Nombre del paciente] like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static DataTable ID (string termino)
        {

            SqlConnection con = Conexion.Conexion.conectar();
            string comando = $"select *from DatosCita where Paciente like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static DataTable FiltrarPorFecha(string filtro)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "SELECT * FROM DatosCita WHERE 1=1 ";

            DateTime inicio = DateTime.MinValue;
            DateTime fin = DateTime.MaxValue;

            switch (filtro)
            {
                case "Hoy":
                    inicio = DateTime.Today;
                    fin = DateTime.Today.AddDays(1).AddTicks(-1);
                    break;

                case "Ayer":
                    inicio = DateTime.Today.AddDays(-1);
                    fin = DateTime.Today.AddTicks(-1);
                    break;

                case "Semana Actual":
                    int diff = (int)DateTime.Today.DayOfWeek;
                    inicio = DateTime.Today.AddDays(-diff + 1); // Lunes
                    fin = inicio.AddDays(7).AddTicks(-1);
                    break;

                case "Semana Pasada":
                    int diff2 = (int)DateTime.Today.DayOfWeek;
                    inicio = DateTime.Today.AddDays(-diff2 - 6); // Lunes anterior
                    fin = inicio.AddDays(7).AddTicks(-1);
                    break;

                case "Mes Actual":
                    inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    fin = inicio.AddMonths(1).AddTicks(-1);
                    break;

                case "Mes Pasado":
                    inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                    fin = inicio.AddMonths(1).AddTicks(-1);
                    break;
            }

            comando += "AND fechaHoraCita BETWEEN @inicio AND @fin";

            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            ad.SelectCommand.Parameters.AddWithValue("@inicio", inicio);
            ad.SelectCommand.Parameters.AddWithValue("@fin", fin);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
