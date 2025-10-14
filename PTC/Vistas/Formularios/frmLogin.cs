using BCrypt.Net; 
using Modelos.Conexion;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modelos.Entidades.Venta;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {

        private int usuario = 0;
        public frmLogin()
        {
            InitializeComponent();

            // Verificar si es primera vez que se abre la aplicación
            if (!Configuracion.ExisteConfiguracion())
            {
                this.Hide();
                frmConfiguracion configForm = new frmConfiguracion();
                configForm.ShowDialog();
                this.Show();
            }

            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        public int Usuario { get => usuario; set => usuario = value; }

        #region
        public (bool success, string rol, bool debeCambiarContrasena, int idUsuario) VerificarLogin(string correo, string clave)
        {
            using (SqlConnection conn = Conexion.conectar())
            {
                string query = "SELECT idUsuario, contrasena, Id_Rol, estadoVerificado FROM Usuario WHERE correoUsu = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", correo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashEnBaseDeDatos = reader["contrasena"].ToString();
                            string rol = reader["Id_Rol"].ToString();
                            int idUsuario = Convert.ToInt32(reader["idUsuario"]);
                            bool estadoVerificado = Convert.ToBoolean(reader["estadoVerificado"]);

                            bool contraseñaCorrecta = BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);

                            // Si la contraseña es correcta, retornamos también si debe cambiar contraseña
                            bool debeCambiarContrasena = contraseñaCorrecta && !estadoVerificado;

                            return (contraseñaCorrecta, contraseñaCorrecta ? rol : null, debeCambiarContrasena, idUsuario);
                        }
                        else
                        {
                            return (false, null, false, 0);
                        }
                    }
                }
            }
        }
        #endregion

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                string correo = txtCorreo.Text;
                string contraseña = txtContraseña.Text;

                var (loginExitoso, rol, debeCambiarContrasena, idUsuario) = VerificarLogin(correo, contraseña);

                if (loginExitoso)
                {

                    Sesion.IdUsuario = idUsuario;

                    if (debeCambiarContrasena)
                    {
                        MessageBox.Show("Debe cambiar su contraseña temporal antes de continuar.",
                                      "Cambio de Contraseña Requerido",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // CORREGIDO: Usar idUsuario (la variable que retorna el método)
                        using (frmCambioContraseña formCambio = new frmCambioContraseña(idUsuario))
                        {
                            if (formCambio.ShowDialog() == DialogResult.OK)
                            {
                                MessageBox.Show("Contraseña cambiada exitosamente. Por favor inicie sesión nuevamente.",
                                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtContraseña.Text = "";
                                txtContraseña.Focus();

                                
                            }
                            else
                            {
                                txtContraseña.Text = "";
                                txtContraseña.Focus();
                            }
                        }
                    }
                    else
                    {
                        // Usuario normal, redirigir al dashboard correspondiente
                        MessageBox.Show("Inicio de sesión exitoso");

                        Form dashboard = null;
                        switch (rol)
                        {
                            case "1": // Administrador
                                dashboard = new frmDashboardAdministrador();
                                usuario = 2;
                                break;

                            case "2": // Trabajador (ajusta según tus IDs de rol)
                                dashboard = new frmDashboardTrabajador();
                                usuario = 1;
                                break;

                            case "3":
                                dashboard = new frmDashboardTrabajador();
                                usuario = 1;
                                break;

                            default:
                                MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor llena los campos requeridos");
            }
        }


        private void llbContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCorreo frm = new frmCorreo();
            frm.ShowDialog();
        }
    }

}
