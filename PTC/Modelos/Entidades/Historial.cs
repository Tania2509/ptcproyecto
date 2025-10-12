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

        public static bool InsertarHistorial(List<Historial> listaHistorial)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            using (SqlTransaction trans = con.BeginTransaction())
            {
                try
                {
                    string sql = @"INSERT INTO HistorialDental 
                          (id_Expediente, id_Diente, id_Estado, fecha, observaciones) 
                          VALUES (@idPaciente, @idDiente, @idEstado, GETDATE(), @observaciones)";

                    foreach (Historial h in listaHistorial)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@idPaciente", h.IdPaciente);
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

        public static DataTable CargarFechas(int paciente)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "execute FechaHistorial @id";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", paciente);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable CargarHistorialPorFecha(int idPaciente, DateTime fecha)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = @"SELECT d.codigo AS CodigoDiente, d.descripcion AS NombreDiente, 
                                e.nombre_estado AS Estado, h.observaciones
                         FROM HistorialDental h
                         INNER JOIN Diente d ON h.id_Diente = d.idDiente
                         INNER JOIN EstadoDiente e ON h.id_Estado = e.idEstado
                         WHERE h.id_Expediente = @idPaciente
                           AND CONVERT(date, h.fecha) = @fecha
                         ORDER BY d.codigo";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                da.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
