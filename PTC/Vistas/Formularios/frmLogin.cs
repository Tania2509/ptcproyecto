using BCrypt.Net; 
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

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======

        #region Login
>>>>>>> tania
        private (bool autenticado, string rol, bool verificado) AutenticarYObtenerRol(string usuario, string contraseña)
        {
            string rol = null;
            bool autenticado = false;
            bool verificado = false;

            using (var connection = Conexion.conectar())
            {
                string query = "SELECT u.contrasena, r.nombreRol, u.estadoVerificado FROM Usuario U " +
                               "INNER JOIN Rol r ON u.id_Rol = r.idRol WHERE correoUsu = @usuario";

                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashAlmacenado = reader.GetString(0);
                            rol = reader.GetString(1);
                            verificado = reader.GetBoolean(2);

                            if (BCrypt.Net.BCrypt.Verify(contraseña, hashAlmacenado))
                            {
                                autenticado = true;
                            }
                        }
                    }
                }
            }

            return (autenticado, rol, verificado);
<<<<<<< HEAD
        }
=======

        }

        #endregion
>>>>>>> tania

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                string correo = txtCorreo.Text;
                string contraseña = txtContraseña.Text;

                var (autenticado, rol, verificado) = AutenticarYObtenerRol(correo, contraseña);

                if (!autenticado)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!verificado)
                {
                    MessageBox.Show("Tu cuenta aún no ha sido verificada por un administrador.", "Cuenta no verificada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
<<<<<<< HEAD
                    case "Asistente":
                    case "Dentista":
=======
                    case "Trabajador":
>>>>>>> tania
                        dashboard = new frmDashboardTrabajador();
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
<<<<<<< HEAD
=======



        frmRegistrar registrar = new frmRegistrar();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrar.Show();
        }
>>>>>>> tania
    }

}
