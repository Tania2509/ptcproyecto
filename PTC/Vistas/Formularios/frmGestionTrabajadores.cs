using Modelos.Conexion;
using Modelos.Entidades;
using Modelos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmTrabajadores : Form
    {
        public frmTrabajadores()
        {
            InitializeComponent();
            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

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

        private void AjustarColumnasDataGrid()
        {
            dgvVerTrabajador.Columns[0].Width = 70;
            dgvVerTrabajador.Columns[4].Width = 80;
        }

        private void frmVerTrabajadores_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            CargarEspecialidad();
            mostrarRol();
            AjustarColumnasDataGrid();
            
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

        public void MostrarUsuarios()
        {
            dgvVerTrabajador.DataSource = null;
            dgvVerTrabajador.DataSource = Usuario.CargarUsuarios("select *from CrearUsuario");

        }

        #region Validaciones de textbox

        Validaciones V = new Validaciones();

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
            txtCorreo.Text = string.Empty;
            txtBuscar.Text = string.Empty;

            // Restablecer ComboBox
            cbRol.SelectedIndex = -1;
            cbEspecialidad.SelectedIndex = -1;

            // Restablecer DateTimePicker
            dtpFechaNaci.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            else if  (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !EsEmailValido(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                    return ;
                }

                else if (!EsMayorDeEdad(dtpFechaNaci.Value))
            {
                return;
            }

            // Validar DUI único
            if (Usuario.DuiExiste(txtDui.Text))
            {
                MessageBox.Show("Ese DUI ya está registrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDui.Focus();
                return;
            }

            Modelos.Entidades.Usuario U = new Usuario();

            U.NombreU = txtNombre.Text;
            U.ApellidoU = txtApellido.Text;
            U.TelefonoU = txtTelefono.Text;
            U.DuiU = txtDui.Text;
            U.Correo = txtCorreo.Text;
            U.FechaNacimientoU = dtpFechaNaci.Value;
            U.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            U.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            U.InsertarUsuarios();
            MostrarUsuarios();
            LimpiarCampos();
            MessageBox.Show("Datos ingresados correctamente");
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
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
            u.Correo = txtCorreo.Text;
            u.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            u.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            u.IdUsuario = Convert.ToInt32(dgvVerTrabajador.CurrentRow.Cells[0].Value);

            if (u.ActualizarUsuarios() == true)
            {
                MostrarUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el trabajador.", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVerTrabajador.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            int idUsuario = Convert.ToInt32(dgvVerTrabajador.CurrentRow.Cells["Usuario"].Value);
            string nombreUsuario = dgvVerTrabajador.CurrentRow.Cells["Nombre"].Value.ToString();

            Usuario u = new Usuario();

            // Confirmar eliminación
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar al usuario: {nombreUsuario}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                u.EliminarUsuario(idUsuario);

                // Refrescar la lista de usuarios
                MostrarUsuarios();
            }
        }
    }
}

