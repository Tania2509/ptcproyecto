using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreU;
        private string apellidoU;
        private DateTime fechaNacimientoU;
        private string duiU;
        private string telefonoU;
        private string correo;
        private string contrasena;
        private int estadoVerificado;
        private int id_Rol;
        private int id_Especialidad;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreU { get => nombreU; set => nombreU = value; }
        public string ApellidoU { get => apellidoU; set => apellidoU = value; }
        public DateTime FechaNacimientoU { get => fechaNacimientoU; set => fechaNacimientoU = value; }
        public string DuiU { get => duiU; set => duiU = value; }
        public string TelefonoU { get => telefonoU; set => telefonoU = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int EstadoVerificado { get => estadoVerificado; set => estadoVerificado = value; }


        public static DataTable CargarUsuarios(string Trabajador)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "select *from CrearUsuario";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertarUsuarios()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "";

            // Verificar si la tabla Usuario está vacía
            string checkQuery = "SELECT COUNT(*) FROM Usuario";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            int count = (int)checkCmd.ExecuteScalar();

            // Generar contraseña temporal
            string contrasenaTemporal = "cont" + DuiU.Substring(0, 3);

            // Si es el primer usuario, debe ser administrador
            if (count == 0)
            {
                comando = @"INSERT INTO Usuario(nombreUsu, apellidoUsu, fechaNaciUsu, duiUsu, telefonoUsu, 
                           correoUsu, contrasena, id_Rol, id_Especialidad, estadoVerificado) 
                           VALUES(@nombreUsu, @apellidoUsu, @fechaNaciUsu, @duiUsu, @telefonoUsu, 
                           @correoUsu, @contrasena, @id_Rol, @id_Especialidad, 0);

                            UPDATE Configuracion 
                            SET pimerUsuarioCreado = 1, 
                            id_Usuario = SCOPE_IDENTITY() 
                            WHERE Configurado = 1;";
            }
            else
            {
                comando = @"INSERT INTO Usuario(nombreUsu, apellidoUsu, fechaNaciUsu, duiUsu, telefonoUsu, 
                    correoUsu, contrasena, id_Rol, id_Especialidad, estadoVerificado) 
                    VALUES(@nombreUsu, @apellidoUsu, @fechaNaciUsu, @duiUsu, @telefonoUsu, 
                    @correoUsu, @contrasena, @id_Rol, @id_Especialidad, 0)";
            }

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreUsu", NombreU);
            cmd.Parameters.AddWithValue("@apellidoUsu", ApellidoU);
            cmd.Parameters.AddWithValue("@fechaNaciUsu", FechaNacimientoU);
            cmd.Parameters.AddWithValue("@duiUsu", DuiU);
            cmd.Parameters.AddWithValue("@telefonoUsu", TelefonoU);
            cmd.Parameters.AddWithValue("@correoUsu", Correo);
            cmd.Parameters.AddWithValue("@contrasena", BCrypt.Net.BCrypt.HashPassword(contrasenaTemporal));
            cmd.Parameters.AddWithValue("@id_Rol", id_Rol);
            cmd.Parameters.AddWithValue("@id_Especialidad", Id_Especialidad);

            return cmd.ExecuteNonQuery() > 0;
        }

        #region PrimerUsuario

        public bool EsPrimerUsuario(int idUsuario)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = @"SELECT COUNT(*) FROM Configuracion 
                        WHERE id_Usuario = @idUsuario AND pimerUsuarioCreado = 1";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }       

        #endregion

        #region Primero Contraseña
        // Verificar si el usuario debe cambiar contraseña (estadoVerificado = 0)
        public static bool DebeCambiarContrasena(int idUsuario)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT estadoVerificado FROM Usuario WHERE idUsuario = @idUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                object result = cmd.ExecuteScalar();
                // Si estadoVerificado = 0, debe cambiar contraseña
                return result != null && (int)result == 0;
            }
        }

        // Cambiar contraseña y marcar como verificado
        public static bool CambiarContrasenaPrimerInicio(int idUsuario, string nuevaContrasena)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = @"UPDATE Usuario 
                        SET clave = @nuevaContrasena, 
                            estadoVerificado = 1
                        WHERE idUsuario = @idUsuario";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nuevaContrasena", BCrypt.Net.BCrypt.HashPassword(nuevaContrasena));
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        #endregion

        // Nuevo método para validar si el DUI ya existe
        public static bool DuiExiste(string dui)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE duiUsu = @dui";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dui", dui);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            // Verificar si es el primer usuario
            if (EsPrimerUsuario(idUsuario))
            {
                MessageBox.Show("No se puede eliminar el primer usuario creado del sistema.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (SqlConnection con = Conexion.Conexion.conectar())
                {
                    string query = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.",
                                           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public bool ActualizarUsuarios()
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string comando = "UPDATE Usuario SET nombreUsu=@nombreUsu, apellidoUsu=@apellidoUsu, fechaNaciUsu=@fechaNaciUsu, duiUsu=@duiUsu, telefonoUsu=@telefonoUsu, correoUsu=@correoUsu, contrasena=@contrasena, id_Rol=@id_Rol, id_Especialidad=@id_Especialidad WHERE idUsuario=@idUsuario;";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
            cmd.Parameters.AddWithValue("@nombreUsu", NombreU);
            cmd.Parameters.AddWithValue("@apellidoUsu", ApellidoU);
            cmd.Parameters.AddWithValue("@fechaNaciUsu", FechaNacimientoU);
            cmd.Parameters.AddWithValue("@duiUsu", DuiU);
            cmd.Parameters.AddWithValue("@telefonoUsu", TelefonoU);
            cmd.Parameters.AddWithValue("@correoUsu", correo);
            cmd.Parameters.AddWithValue("@contrasena", Contrasena);
            cmd.Parameters.AddWithValue("@id_Rol", Id_Rol);
            cmd.Parameters.AddWithValue("@id_Especialidad", Id_Especialidad);

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
            string comando = $"select idUsuario, nombreUsu, apellidoUsu, fechaNaciUsu, duiUsu, telefonoUsu, correoUsu, contrasena, id_Rol, id_Especialidad from Usuario where nombreUsu like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }


    }
}
