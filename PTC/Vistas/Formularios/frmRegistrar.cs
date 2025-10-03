using Modelos.Conexion;
using Modelos.Entidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Formularios
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

       

        #region insercion 

        // Método para validar email
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

        //Metodo de date
        private bool EsMayorDeEdad(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
                edad--;

            // Validar rango de edad (1 a 80 años)
            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser 18 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaci.Focus();
                return false;
            }

            if (edad > 40)
            {
                MessageBox.Show("La edad máxima no puede superar los 45 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaci.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Metodos de combobox

        private void mostrarRol()
        {
            cbRol.DataSource = null;
            cbRol.DataSource = Rol.CargarRol();
            cbRol.DisplayMember = "nombreRol";
            cbRol.ValueMember = "idRol";
            if (cbRol.Items.Count > 0)
            {
                cbRol.SelectedIndex = 0; // Primer elemento
            }
        }

        private void CargarEspecialidad()
        {
            cbEspecialidad.DataSource = null;
            cbEspecialidad.DataSource = Especialidad.CargarEspecialidad();
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "idEspecialidad";
            cbEspecialidad.SelectedIndex = -1;
        }

        #endregion

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            CargarEspecialidad();
            mostrarRol();
            
        }

        #region validaciones

        Validaciones V = new Validaciones();

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.");
                return;
            }
            else if (!EsMayorDeEdad(dtpFechaNaci.Value))
            {
                return;
            }
            // Validar que el correo tenga formato válido (si se ingresó)
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !EsEmailValido(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                return;
            }

            Modelos.Entidades.Usuario U = new Usuario();

            U.NombreU = txtNombre.Text;
            U.ApellidoU = txtApellido.Text;
            U.TelefonoU = txtTelefono.Text;
            U.DuiU = txtDui.Text;
            U.Correo = txtCorreo.Text;
            U.FechaNacimientoU = dtpFechaNaci.Value;
            U.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            U.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            U.InsertarUsuarios();

            MessageBox.Show("Primer usuario creado correctamente!\n\n",
                                      "Registro Exitoso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar el registro?\n\nDebe registrar un usuario administrador para usar el sistema.",
                      "Confirmar Cancelación",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}

