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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
       string.IsNullOrWhiteSpace(txtApellido.Text) ||
       string.IsNullOrWhiteSpace(txtTelefono.Text) ||
       string.IsNullOrWhiteSpace(txtDui.Text) ||
       cbRol.SelectedIndex == -1 ||
       cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            // Verificar si es el primer usuario
            SqlConnection con = Conexion.conectar();
            string checkQuery = "SELECT COUNT(*) FROM Usuario";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                // Si es el primer usuario, asignar automáticamente el rol de "Administrador"
                cbRol.SelectedItem = "Administrador";
            }
            Usuario nuevoUsuario = new Usuario
            {
                NombreU = txtNombre.Text,
                ApellidoU = txtApellido.Text,
                Correo = txtCorreo.Text,
                DuiU = txtDui.Text,
                TelefonoU = txtTelefono.Text,
                FechaNacimientoU = dtpFechaNaci.Value,
                Contrasena = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text),  // Hash de la contraseña
                Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue),
                Id_Rol = cbRol.SelectedItem.ToString() == "Administrador" ? 1 : 2, // Si selecciona Administrador, asignamos el rol 1
                EstadoVerificado = cbRol.SelectedItem.ToString() == "Administrador" ? 1 : 0  // Si es administrador, estado verificado
            };

            // Registrar usuario
            if (nuevoUsuario.InsertarUsuarios())
            {
                MessageBox.Show("Usuario registrado correctamente");
                this.Hide();
                new frmLogin().Show();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario.");
            }
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

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            CargarEspecialidad();
            mostrarRol();
        }
    }
}

