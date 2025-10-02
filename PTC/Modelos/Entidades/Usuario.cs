using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private int id_venta;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreU { get => nombreU; set => nombreU = value; }
        public string ApellidoU { get => apellidoU; set => apellidoU = value; }
        public DateTime FechaNacimientoU { get => fechaNacimientoU; set => fechaNacimientoU = value; }
        public string DuiU { get => duiU; set => duiU = value; }
        public string TelefonoU { get => telefonoU; set => telefonoU = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
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
                    correoUsu, contrasena, id_Rol, id_Especialidad, id_Venta, estadoVerificado) 
                    VALUES(@nombreUsu, @apellidoUsu, @fechaNaciUsu, @duiUsu, @telefonoUsu, 
                    @correoUsu, @contrasena, @id_Rol, @id_Especialidad, @id_venta, 0)";
                id_Rol = 1;  // Administrador
            }
            else
            {
                comando = @"INSERT INTO Usuario(nombreUsu, apellidoUsu, fechaNaciUsu, duiUsu, telefonoUsu, 
                    correoUsu, contrasena, id_Rol, id_Especialidad, id_Venta, estadoVerificado) 
                    VALUES(@nombreUsu, @apellidoUsu, @fechaNaciUsu, @duiUsu, @telefonoUsu, 
                    @correoUsu, @contrasena, @id_Rol, @id_Especialidad, @id_venta, 0)";
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
            cmd.Parameters.AddWithValue("@id_venta", DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }

        #region Primero 
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

        public bool eliminarTrabajador(int id)
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaDelete = "Delete from Usuario where idUsuario = @id;";
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
