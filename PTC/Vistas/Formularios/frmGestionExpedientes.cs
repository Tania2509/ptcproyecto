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

        private void btnAgregar_Click(object sender, EventArgs e)
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
            }
        }

        public void MostrarExpedientes()
        {
            dgvVerExpedientes.DataSource = null;
            dgvVerExpedientes.DataSource = Expediente.CargarExpedientes("select *from VerExpediente");
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
    }
}
