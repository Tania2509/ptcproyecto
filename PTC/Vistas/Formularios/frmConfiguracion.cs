using Modelos.Entidades;
using Modelos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();

            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Código modificado en btnAgregar_Click:

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Corregir la validación: solo los campos de texto son obligatorios, el logo NO.
            if (!string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !EsEmailValido(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                    return;
                }

                try
                {
                    Configuracion config = new Configuracion
                    {
                        NombreClinica = txtNombre.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtCorreo.Text.Trim()
                    };

                    Configuracion.GuardarConfiguracion(config);

                    MessageBox.Show("Configuración inicial guardada exitosamente!\n\nAhora procederá a registrar el usuario administrador principal.",
                                  "Configuración Completada",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la configuración: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No dejes campos vacíos", "Campos obligatorios");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar la configuración inicial?\n\nLa aplicación se cerrará.",
                          "Confirmar Cancelación",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        #region Validaciones de campos

        Validaciones V = new Validaciones();
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Simbolos(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion
    }
}
