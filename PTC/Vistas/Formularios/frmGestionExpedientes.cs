using Modelos.Entidades;
using Modelos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmGestionExpedientes : Form
    {
        public frmGestionExpedientes()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNumTelefono.Text = string.Empty;
            txtBuscar.Text = string.Empty;

            // Restablecer ComboBox
            cbAlergias.SelectedIndex = -1;
            cbEnfermedades.SelectedIndex = -1;

            // Restablecer DateTimePicker
            dtpFechaNaciPa.Value = DateTime.Now;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 

        }
            
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Expediente expediente = new Expediente();
            int id = int.Parse(dgvVerExpedientes.CurrentRow.Cells[0].Value.ToString());
            if (expediente.eliminarExpediente(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarExpedientes();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {
            MostrarExpedientes();
            MostrarAlergias();
            MostrarEnfermedades();
        }

        #region Combobox
        private void MostrarAlergias()
        {
            cbAlergias.DataSource = null;
            cbAlergias.DataSource = Alergias.CargarAlergias();
            cbAlergias.DisplayMember = "nombreAl";
            cbAlergias.ValueMember = "idAlergias";
            cbAlergias.SelectedIndex = -1;
        }

        private void MostrarEnfermedades()
        {
            cbEnfermedades.DataSource = null;
            cbEnfermedades.DataSource = Enfermedades.CargarEnfermedades();
            cbEnfermedades.DisplayMember = "nombreEnfer";
            cbEnfermedades.ValueMember = "idEnfermedades";
            cbEnfermedades.SelectedIndex = -1;
        }

        #endregion


        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVerExpedientes.DataSource = null;
                dgvVerExpedientes.DataSource = Usuario.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region TextBox

        Validaciones V = new Validaciones();
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e); 
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        private void txtNumTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion



        private void btnAgregarJSMN_Click_1(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNumTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (!ValidarEdad(dtpFechaNaciPa.Value))
                return;

            else
            {
                Modelos.Entidades.Expediente E = new Expediente();

                E.NombrePa = txtNombre.Text;
                E.ApellidoPa = txtApellido.Text;
                E.TelefonoPa = txtNumTelefono.Text;
                E.Dui = txtDui.Text;
                E.CorreoPa = txtCorreoElectronico.Text;
                E.DireccionPa = txtDireccion.Text;
                E.FechaNacimiento = dtpFechaNaciPa.Value;
                E.Id_Alergias = Convert.ToInt32(cbAlergias.SelectedValue);
                E.Id_Enfermedades = Convert.ToInt32(cbEnfermedades.SelectedValue);
                E.InsertarExpediente();

                MostrarExpedientes();
                LimpiarCampos();
                MessageBox.Show("Datos ingresados correctamente");
            }
        }

        private bool ValidarEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
                edad--;

            // Validar rango de edad (1 a 80 años)
            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser 1 año", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaciPa.Focus();
                return false;
            }

            if (edad > 90)
            {
                MessageBox.Show("La edad máxima no puede superar los 90 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaciPa.Focus();
                return false;
            }

            return true;
        }

        public void MostrarExpedientes()
        {
            dgvVerExpedientes.DataSource = null;
            dgvVerExpedientes.DataSource = Expediente.CargarExpedientes("select *from VerExpediente");
        }

        private void btnActualizarJSMN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtNumTelefono.Text) ||
               string.IsNullOrWhiteSpace(txtDui.Text) ||
               string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
               string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Expediente E = new Expediente();
            E.NombrePa = txtNombre.Text;
            E.ApellidoPa = txtApellido.Text;
            E.TelefonoPa = txtNumTelefono.Text;
            E.Dui = txtDui.Text;
            E.CorreoPa = txtCorreoElectronico.Text;
            E.DireccionPa = txtDireccion.Text;
            E.FechaNacimiento = dtpFechaNaciPa.Value;
            E.Id_Alergias = Convert.ToInt32(cbAlergias.SelectedValue);
            E.Id_Enfermedades = Convert.ToInt32(cbEnfermedades.SelectedValue);
            E.IdExpediente = Convert.ToInt32(dgvVerExpedientes.CurrentRow.Cells[0].Value);

            if (E.ActualizarExpedientes() == true)
            {
                MostrarExpedientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el trabajador.", "Error");
            }
        }

        private void dgvVerExpedientes_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvVerExpedientes.CurrentRow.Cells["Nombre del Paciente"].Value.ToString();
            txtApellido.Text = dgvVerExpedientes.CurrentRow.Cells["Apellido del paciente"].Value.ToString();
            txtNumTelefono.Text = dgvVerExpedientes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDui.Text = dgvVerExpedientes.CurrentRow.Cells["DUI"].Value.ToString();
            txtCorreoElectronico.Text = dgvVerExpedientes.CurrentRow.Cells["Correo del paciente"].Value.ToString();
            txtDireccion.Text = dgvVerExpedientes.CurrentRow.Cells["Direccion"].Value.ToString();
            dtpFechaNaciPa.Value = Convert.ToDateTime(dgvVerExpedientes.CurrentRow.Cells["Fecha de nacimiento"].Value);
            cbAlergias.Text = dgvVerExpedientes.CurrentRow.Cells["Alergias"].Value.ToString();
            cbEnfermedades.Text = dgvVerExpedientes.CurrentRow.Cells["Enfermedades"].Value.ToString();
        }

        private void btnEliminarJSMN_Click(object sender, EventArgs e)
        {
            Expediente expediente = new Expediente();
            int id = int.Parse(dgvVerExpedientes.CurrentRow.Cells[0].Value.ToString());
            if (expediente.eliminarExpediente(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarExpedientes();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}

