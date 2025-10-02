using Modelos.Conexion;
using Modelos.Entidades;
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
    public partial class frmCambioContraseña : Form
    {
        private int idUsuario;

        // Constructor que recibe el parámetro
        public frmCambioContraseña(int userId)
        {
            InitializeComponent();
            idUsuario = userId;
            this.Text = "Cambio de Contraseña Obligatorio";
        }


        private bool ValidarContrasenas()
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("La nueva contraseña no puede estar vacía.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            if (txtContraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            if (txtContraseña.Text != txtPrimero.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                txtContraseña.SelectAll();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarContrasenas())
            {
                try
                {
                    // Usar la variable idUsuario que ya está asignada
                    if (CambiarContrasenaPrimerInicio(idUsuario, txtContraseña.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool CambiarContrasenaPrimerInicio(int idUsuario, string nuevaContrasena)
        {
            using (SqlConnection con = Conexion.conectar())
            {
                // Verificamos si la conexión es nula, lo que indica que la conexión falló
                if (con.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("No se pudo establecer una conexión con la base de datos. Verifique su conexión.",
                                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string query = @"UPDATE Usuario 
                         SET contrasena = @nuevaContrasena, 
                             estadoVerificado = 1
                         WHERE idUsuario = @idUsuario";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nuevaContrasena", BCrypt.Net.BCrypt.HashPassword(nuevaContrasena));
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                try
                {
                    // Ejecutamos la consulta y verificamos cuántas filas se afectaron
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true; // Cambio exitoso
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario con el ID proporcionado o no se pudo realizar el cambio.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Si no se afecta ninguna fila, significa que el cambio no ocurrió
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
