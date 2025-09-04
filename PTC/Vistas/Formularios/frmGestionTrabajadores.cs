using Modelos.Entidades;
using Modelos.Metodos;
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
    public partial class frmGestionTrabajadores : Form
    {
        public frmGestionTrabajadores()
        {
            InitializeComponent();
        }

        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                cbRol.SelectedIndex == -1 ||
                cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modelos.Entidades.Usuario U = new Usuario();

            U.NombreU = txtNombre.Text;
            U.ApellidoU = txtApellido.Text;
            U.TelefonoU = txtTelefono.Text;
            U.DuiU = txtDui.Text;
            U.FechaNacimientoU = dtpFechaNaci.Value;
            U.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            U.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            U.Contrasena = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text);
            U.InsetarUsuarios();
            MostrarTrabajadores();
            LimpiarCampos();

        }

        private void frmVerTrabajadores_Load(object sender, EventArgs e)
        {
            MostrarTrabajadores();
            CargarEspecialidad();
            mostrarRol();
        }

        #region Metodos de combobox

        private void mostrarRol()
        {
            cbRol.DataSource = null;
            cbRol.DataSource = Rol.CargarRol();
            cbRol.DisplayMember = "nombreRol";
            cbRol.ValueMember = "idRol";
            cbRol.SelectedIndex = -1;
            cbRol.SelectedIndexChanged += cambiarComboBox;
        }

        private void CargarEspecialidad()
        {
            cbEspecialidad.DataSource = null;
            cbEspecialidad.DataSource = Especialidad.CargarEspecialidad();
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "idEspecialidad";
            cbEspecialidad.SelectedIndex = -1;
        }

        private void cambiarComboBox(object sender, EventArgs e)
        {
            if (cbRol.SelectedIndex != -1 && cbRol.Text == "Asistente")
            {
                cbEspecialidad.SelectedIndex = cbEspecialidad.FindStringExact("Ninguno");
            }
        }

        #endregion

        public void MostrarTrabajadores()
        {
            dgvVerTrabajador.DataSource = null;
            dgvVerTrabajador.DataSource = Usuario.CargarUsuarios("select *from MostrarTrabajadores"); 
        }

        private void btnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            Usuario Trabajador = new Usuario();
            int id = int.Parse(dgvVerTrabajador.CurrentRow.Cells[0].Value.ToString());
            if (Trabajador.eliminarTrabajador(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarTrabajadores();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validaciones de textbox

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

        private void dgvVerTrabajador_DoubleClick(object sender, EventArgs e)
        {
           
                txtNombre.Text = dgvVerTrabajador.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvVerTrabajador.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvVerTrabajador.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDui.Text = dgvVerTrabajador.CurrentRow.Cells["DUI"].Value.ToString();
                dtpFechaNaci.Value = Convert.ToDateTime(dgvVerTrabajador.CurrentRow.Cells["Fecha de nacimiento"].Value);
                cbEspecialidad.Text = dgvVerTrabajador.CurrentRow.Cells["Especialidad"].Value.ToString();
                cbRol.Text = dgvVerTrabajador.CurrentRow.Cells["Rol"].Value.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                cbRol.SelectedIndex == -1 ||
                cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Usuario u = new Usuario(); 
            u.NombreU = txtNombre.Text;
            u.ApellidoU = txtApellido.Text;
            u.TelefonoU = txtTelefono.Text;
            u.DuiU = txtDui.Text;
            u.FechaNacimientoU = dtpFechaNaci.Value;
            u.Contrasena = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text);
            u.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            u.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            u.IdUsuario = Convert.ToInt32(dgvVerTrabajador.CurrentRow.Cells[0].Value);

            if (u.ActualizarUsuarios() == true)
            {
                MostrarTrabajadores();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el trabajador.", "Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVerTrabajador.DataSource = null;
                dgvVerTrabajador.DataSource = Usuario.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDui.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtBuscar.Text = string.Empty;

            // Restablecer ComboBox
            cbRol.SelectedIndex = -1;
            cbEspecialidad.SelectedIndex = -1;

            // Restablecer DateTimePicker
            dtpFechaNaci.Value = DateTime.Now;
        }
    }
}
