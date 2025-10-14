using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        private List<int> enfermedadesIds;
        private List<int> alergiasIds;

        public int IdExpediente { get => idExpediente; set => idExpediente = value; }
        public string NombrePa { get => nombrePa; set => nombrePa = value; }
        public string ApellidoPa { get => apellidoPa; set => apellidoPa = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TelefonoPa { get => telefonoPa; set => telefonoPa = value; }
        public string DireccionPa { get => direccionPa; set => direccionPa = value; }
        public string CorreoPa { get => correoPa; set => correoPa = value; }
        public string Dui { get => dui; set => dui = value; }
        public List<int> EnfermedadesIds { get => enfermedadesIds; set => enfermedadesIds = value; }
        public List<int> AlergiasIds { get => alergiasIds; set => alergiasIds = value; }

        public static DataTable CargarExpedientes(string Citas)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "SELECT * FROM VerExpediente";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertarExpediente()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // 1. Insertar el expediente principal
                string comando = @"INSERT INTO Expediente 
                                 (nombrePa, apellidoPa, fechaNacimiento, telefonoPa, direccionPa, correoPa, dui) 
                                 OUTPUT INSERTED.idExpediente
                                 VALUES (@nombrePa, @apellidoPa, @fechaNacimiento, @telefonoPa, @direccionPa, @correoPa, @dui)";

                SqlCommand cmd = new SqlCommand(comando, con, transaction);
                cmd.Parameters.AddWithValue("@nombrePa", nombrePa);
                cmd.Parameters.AddWithValue("@apellidoPa", apellidoPa);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@telefonoPa", telefonoPa);
                cmd.Parameters.AddWithValue("@direccionPa", direccionPa);
                cmd.Parameters.AddWithValue("@correoPa", correoPa);
                cmd.Parameters.AddWithValue("@dui", dui);

                int expedienteId = (int)cmd.ExecuteScalar();

                // 2. Insertar enfermedades si existen
                if (enfermedadesIds != null && enfermedadesIds.Count > 0)
                {
                    foreach (int enfermedadId in enfermedadesIds)
                    {
                        string queryEnfermedad = "INSERT INTO ExpedienteEnfermedades (idExpediente, idEnfermedades) VALUES (@expedienteId, @enfermedadId)";
                        SqlCommand cmdEnfermedad = new SqlCommand(queryEnfermedad, con, transaction);
                        cmdEnfermedad.Parameters.AddWithValue("@expedienteId", expedienteId);
                        cmdEnfermedad.Parameters.AddWithValue("@enfermedadId", enfermedadId);
                        cmdEnfermedad.ExecuteNonQuery();
                    }
                }

                // 3. Insertar alergias si existen
                if (alergiasIds != null && alergiasIds.Count > 0)
                {
                    foreach (int alergiaId in alergiasIds)
                    {
                        string queryAlergia = "INSERT INTO ExpedienteAlergias (idExpediente, idAlergias) VALUES (@expedienteId, @alergiaId)";
                        SqlCommand cmdAlergia = new SqlCommand(queryAlergia, con, transaction);
                        cmdAlergia.Parameters.AddWithValue("@expedienteId", expedienteId);
                        cmdAlergia.Parameters.AddWithValue("@alergiaId", alergiaId);
                        cmdAlergia.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error al insertar expediente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarExpedientes()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // 1. Actualizar el expediente principal
                string comando = @"UPDATE Expediente SET 
                                 nombrePa = @nombrePa, 
                                 apellidoPa = @apellidoPa, 
                                 fechaNacimiento = @fechaNacimiento, 
                                 telefonoPa = @telefonoPa, 
                                 direccionPa = @direccionPa, 
                                 correoPa = @correoPa, 
                                 dui = @dui 
                                 WHERE idExpediente = @idExpediente";

                SqlCommand cmd = new SqlCommand(comando, con, transaction);
                cmd.Parameters.AddWithValue("@idExpediente", idExpediente);
                cmd.Parameters.AddWithValue("@nombrePa", nombrePa);
                cmd.Parameters.AddWithValue("@apellidoPa", apellidoPa);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@telefonoPa", telefonoPa);
                cmd.Parameters.AddWithValue("@direccionPa", direccionPa);
                cmd.Parameters.AddWithValue("@correoPa", correoPa);
                cmd.Parameters.AddWithValue("@dui", dui);

                cmd.ExecuteNonQuery();

                // 2. Eliminar enfermedades existentes y insertar las nuevas
                string deleteEnfermedades = "DELETE FROM ExpedienteEnfermedades WHERE idExpediente = @idExpediente";
                SqlCommand cmdDeleteEnf = new SqlCommand(deleteEnfermedades, con, transaction);
                cmdDeleteEnf.Parameters.AddWithValue("@idExpediente", idExpediente);
                cmdDeleteEnf.ExecuteNonQuery();

                if (enfermedadesIds != null && enfermedadesIds.Count > 0)
                {
                    foreach (int enfermedadId in enfermedadesIds)
                    {
                        string insertEnfermedad = "INSERT INTO ExpedienteEnfermedades (idExpediente, idEnfermedades) VALUES (@idExpediente, @enfermedadId)";
                        SqlCommand cmdInsertEnf = new SqlCommand(insertEnfermedad, con, transaction);
                        cmdInsertEnf.Parameters.AddWithValue("@idExpediente", idExpediente);
                        cmdInsertEnf.Parameters.AddWithValue("@enfermedadId", enfermedadId);
                        cmdInsertEnf.ExecuteNonQuery();
                    }
                }

                // 3. Eliminar alergias existentes y insertar las nuevas
                string deleteAlergias = "DELETE FROM ExpedienteAlergias WHERE idExpediente = @idExpediente";
                SqlCommand cmdDeleteAlg = new SqlCommand(deleteAlergias, con, transaction);
                cmdDeleteAlg.Parameters.AddWithValue("@idExpediente", idExpediente);
                cmdDeleteAlg.ExecuteNonQuery();

                if (alergiasIds != null && alergiasIds.Count > 0)
                {
                    foreach (int alergiaId in alergiasIds)
                    {
                        string insertAlergia = "INSERT INTO ExpedienteAlergias (idExpediente, idAlergias) VALUES (@idExpediente, @alergiaId)";
                        SqlCommand cmdInsertAlg = new SqlCommand(insertAlergia, con, transaction);
                        cmdInsertAlg.Parameters.AddWithValue("@idExpediente", idExpediente);
                        cmdInsertAlg.Parameters.AddWithValue("@alergiaId", alergiaId);
                        cmdInsertAlg.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error al actualizar expediente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Métodos auxiliares para obtener enfermedades y alergias de un expediente
        public static List<int> ObtenerEnfermedadesPorExpediente(int expedienteId)
        {
            List<int> enfermedades = new List<int>();
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT idEnfermedades FROM ExpedienteEnfermedades WHERE idExpediente = @expedienteId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@expedienteId", expedienteId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enfermedades.Add(reader.GetInt32(0));
                    }
                }
            }
            return enfermedades;
        }

        public static List<int> ObtenerAlergiasPorExpediente(int expedienteId)
        {
            List<int> alergias = new List<int>();
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT idAlergias FROM ExpedienteAlergias WHERE idExpediente = @expedienteId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@expedienteId", expedienteId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alergias.Add(reader.GetInt32(0));
                    }
                }
            }
            return alergias;
        }

        public bool eliminarExpediente(int id)
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conexion.conectar())
                {
                    // Primero eliminar las relaciones
                    string deleteRelaciones = @"
                        DELETE FROM ExpedienteEnfermedades WHERE idExpediente = @id;
                        DELETE FROM ExpedienteAlergias WHERE idExpediente = @id;";

                    using (SqlCommand cmdRelaciones = new SqlCommand(deleteRelaciones, conexion))
                    {
                        cmdRelaciones.Parameters.AddWithValue("@id", id);
                        cmdRelaciones.ExecuteNonQuery();
                    }

                    // Luego eliminar el expediente
                    string consultaDelete = "EXEC EliminarPaciente @id;";
                    using (SqlCommand delete = new SqlCommand(consultaDelete, conexion))
                    {
                        delete.Parameters.AddWithValue("@id", id);
                        int resultado = delete.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar", "Información",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos al eliminar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable Buscar(string termino)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = $"SELECT * FROM VerExpediente WHERE nombreUsu LIKE '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static bool DuiExiste(string dui)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Expediente WHERE dui = @dui";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dui", dui);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}