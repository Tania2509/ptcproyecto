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
    public class Historial
    {
        private int idHistorial;
        private int idPaciente;
        private int idDiente;
        private int idEstado;
        private DateTime  fecha;
        private string observaciones;

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdDiente { get => idDiente; set => idDiente = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        // Método para insertar varios registros


        public static bool InsertarHistorial(List<Historial> listaHistorial)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            using (SqlTransaction trans = con.BeginTransaction())
            {
                try
                {
                    string sql = @"INSERT INTO HistorialDental 
                          (id_Paciente, id_Diente, id_Estado, fecha, observaciones) 
                          VALUES (@idPaciente, @idDiente, @idEstado, @fecha, @observaciones)";

                    foreach (Historial h in listaHistorial)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@idPaciente", h.IdPaciente);
                            cmd.Parameters.AddWithValue("@idDiente", h.IdDiente);
                            cmd.Parameters.AddWithValue("@idEstado", h.IdEstado);
                            cmd.Parameters.AddWithValue("@fecha", h.Fecha);
                            cmd.Parameters.AddWithValue("@observaciones",
                                string.IsNullOrEmpty(h.Observaciones) ? "" : h.Observaciones);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al insertar historial: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
