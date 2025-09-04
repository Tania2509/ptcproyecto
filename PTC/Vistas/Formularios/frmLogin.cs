using Modelos.Conexion;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net; 

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }   

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                string correo = txtCorreo.Text;
                string contraseña = txtContraseña.Text;

                var (autenticado, rol) = AutenticarYObtenerRol(correo, contraseña);

                if (!autenticado)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Inicio de sesión exitoso");

                // Redirigir según el rol
                Form dashboard = null;
                switch (rol)
                {
                    case "Administrador":
                        dashboard = new frmDashboardAdministrador();
                        break;
                    case "Asistente":
                        dashboard = new frmDashboardAsistente();
                        break;
                    case "Dentista":
                        dashboard = new frmDashboardDoctor();
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor llena los campos requeridos");
            }
        }

        #region Login
        private (bool autenticado, string rol) AutenticarYObtenerRol(string usuario, string contraseña)
        {
            string rol = null;
            bool autenticado = false;

            using (var connection = Conexion.conectar())
            {
                // 1. Obtener el hash de la contraseña y el rol
                string query = "SELECT u.contrasena, r.nombreRol FROM Usuario U INNER JOIN Rol r ON u.id_Rol = r.idRol WHERE correoUsu = @usuario";

                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashAlmacenado = reader.GetString(0);
                            string rolObtenido = reader.GetString(1);

                            // 2. Verificar la contraseña con BCrypt
                            if (BCrypt.Net.BCrypt.Verify(contraseña, hashAlmacenado))
                            {
                                rol = rolObtenido;
                                autenticado = true;
                            }
                        }
                    }
                }

                connection.Close();
            }

            return (autenticado, rol);
        }

        #endregion

    }

}
