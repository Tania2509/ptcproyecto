using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Configuracion
    {
        private int idConfig;
        private string nombreClinica;
        private string direccion;
        private string telefono;
        private string email;
        private DateTime fechaConfiguracion;
        private bool configurado;

        public int IdConfig { get => idConfig; set => idConfig = value; }
        public string NombreClinica { get => nombreClinica; set => nombreClinica = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaConfiguracion { get => fechaConfiguracion; set => fechaConfiguracion = value; }
        public bool Configurado { get => configurado; set => configurado = value; }

        public static bool ExisteConfiguracion()
        {
            using (SqlConnection conexion = Conexion.Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Configuracion WHERE Configurado = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        
        

        public static void GuardarConfiguracion(Configuracion config)
        {
            using (SqlConnection conexion = Conexion.Conexion.conectar())
            {
                string query = @"INSERT INTO Configuracion 
                           (nombreClinica, direccion, telefono, email , configurado, id_Usuario)
                           VALUES (@NombreClinica, @Direccion, @Telefono, @Email, 1, null)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreClinica", config.NombreClinica);
                cmd.Parameters.AddWithValue("@Direccion", config.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", config.Telefono);
                cmd.Parameters.AddWithValue("@Email", config.Email);

                cmd.ExecuteNonQuery();
            }
        }

        public static Configuracion ObtenerConfiguracion()
        {
            using (SqlConnection conexion = Conexion.Conexion.conectar())
            {
                string query = "SELECT TOP 1 * FROM Configuracion WHERE Configurado = 1 ORDER BY idConfig DESC";
                SqlCommand cmd = new SqlCommand(query, conexion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Configuracion
                        {
                            idConfig = reader.GetInt32(reader.GetOrdinal("Id")),
                            NombreClinica = reader.GetString(reader.GetOrdinal("NombreClinica")),
                            Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                            Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            FechaConfiguracion = reader.GetDateTime(reader.GetOrdinal("FechaConfiguracion")),
                            Configurado = reader.GetBoolean(reader.GetOrdinal("Configurado"))
                        };
                    }
                }
                return null;
            }
        }

        Usuario hola = new Usuario();

       
        public static bool DebeCambiarContrasena(int idUsuario)
        {
            using (SqlConnection con = Conexion.Conexion.conectar())
            {
                string query = "SELECT estadoVerificado FROM Usuario WHERE idUsuario = @idUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                object result = cmd.ExecuteScalar();
                // Si estadoVerificado = 0, debe cambiar contraseña
                return result != null && !(bool)result;
            }
        }

        public static bool ExistePrimerUsuario()
        {
            using (SqlConnection conexion = Conexion.Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Configuracion WHERE pimerUsuarioCreado = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
}

    
}
