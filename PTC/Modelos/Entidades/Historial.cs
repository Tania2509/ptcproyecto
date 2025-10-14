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
        private string observaciones;

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdDiente { get => idDiente; set => idDiente = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        public static int? ObtenerIdExpedientePorDui(string dui)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT id_Expediente FROM Expediente WHERE dui = @dui";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dui", dui);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        return null; // No existe el paciente
                }
            }
        }

        public static bool InsertarHistorial(List<Historial> listaHistorial, int idExpediente)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            using (SqlTransaction trans = con.BeginTransaction())
            {
                try
                {
                    string sql = @"INSERT INTO HistorialDental 
                   (id_Expediente, id_Diente, id_Estado, fecha, observaciones) 
                   VALUES (@idExpediente, @idDiente, @idEstado, GETDATE(), @observaciones)";

                    foreach (Historial h in listaHistorial)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@idExpediente", idExpediente);
                            cmd.Parameters.AddWithValue("@idDiente", h.IdDiente);
                            cmd.Parameters.AddWithValue("@idEstado", h.IdEstado);
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

        public static DataTable CargarFechas(int idPaciente)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = @"SELECT DISTINCT fecha 
                         FROM HistorialDental 
                         WHERE id_Paciente = @idPaciente
                         ORDER BY fecha DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
