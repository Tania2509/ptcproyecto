using Modelos.Conexion;
using Modelos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmCorreo : Form
    {
        public frmCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Ingrese un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Conexion.conectar())
                {
                    string query = "SELECT idUsuario FROM Usuario WHERE correoUsu = @correo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int idUsuario = Convert.ToInt32(result);

                            // Generar token aleatorio de 6 dígitos
                            string token = new string(Enumerable.Repeat("0123456789", 6)
                                .Select(s => s[new Random().Next(s.Length)]).ToArray());

                            Token.UsuarioID = idUsuario;
                            Token.Codigo = token;
                            Token.Expira = DateTime.Now.AddMinutes(1);

                            // Enviar correo
                            Correo.EnviarToken(correo, token);

                            MessageBox.Show("Se ha enviado un código a tu correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("El correo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            string tokenIngresado = txtToken.Text.Trim();

            if (Token.TokenValido(tokenIngresado))
            {
                MessageBox.Show("Código válido. Ingresa tu nueva contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmCambioContraseña frmCambio = new frmCambioContraseña(Token.UsuarioID);
                this.Hide();
                frmCambio.ShowDialog();
                this.Close();

                Token.LimpiarToken();
            }
            else
            {
                MessageBox.Show("Código inválido o ha expirado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}
