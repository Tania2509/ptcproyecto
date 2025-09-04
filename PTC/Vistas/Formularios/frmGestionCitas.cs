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
    public partial class frmGestionCitas : Form
    {
        public frmGestionCitas()
        {
            InitializeComponent();
        }

        #region DateTimePicker

        private void dtpFecha_ValueChanged()
        {
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        #endregion

        #region comboBox

        private void MostrarNombre()
        {
            cbNombre.DataSource = null;
            cbNombre.DataSource = Paciente.CargarNombre();
            cbNombre.DisplayMember = "nombrePa";
            cbNombre.ValueMember = "idPaciente";
            cbNombre.SelectedIndex = -1;
        }

        private void MostrarApellido()
        {
            cbApellido.DataSource = null;
            cbApellido.DataSource = Paciente.CargarApellido();
            cbApellido.DisplayMember = "apellidoPa";
            cbApellido.ValueMember = "idPaciente";
            cbApellido.SelectedIndex = -1;
        }


        private void MostrarCorreo()
        {
            cbCorreo.DataSource = null;
            cbCorreo.DataSource = Paciente.CargarCorreo();
            cbCorreo.DisplayMember = "correoPa";
            cbCorreo.ValueMember = "idPaciente";
            cbCorreo.SelectedIndex = -1;
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombre.SelectedIndex != -1)
            {
                cbApellido.SelectedIndex = cbNombre.SelectedIndex;
                cbCorreo.SelectedIndex = cbNombre.SelectedIndex;
            }
        }


        #endregion

        private void frmVerCitas_Load(object sender, EventArgs e)
        {
            MostrarCitas();
            MostrarNombre();
            MostrarApellido();
            MostrarCorreo();
            dtpFecha_ValueChanged();
            cbNombre.SelectedIndexChanged += cbNombre_SelectedIndexChanged;
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (cbNombre.SelectedIndex == -1 || cbCorreo.SelectedIndex == -1 || cbApellido.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtRazonCita.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Modelos.Entidades.Cita C = new Cita();

            C.Id_Paciente = Convert.ToInt32(cbNombre.SelectedValue);
            C.RazonCita = txtRazonCita.Text;
            C.FechaHoraCita = dtpFechaHora.Value;
            C.InsertarCitas();
            MostrarCitas();
            LimpiarCampos();
        }

       

        public void MostrarCitas()
        {
            dgvVerCitas.DataSource = null;
            dgvVerCitas.DataSource = Cita.CargarCitas("select *From DatosCita");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita();
            int id = int.Parse(dgvVerCitas.CurrentRow.Cells[0].Value.ToString()); 
            if (cita.eliminarCita(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarCitas();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvVerCitas_DoubleClick(object sender, EventArgs e)
        {
            txtRazonCita.Text = dgvVerCitas.CurrentRow.Cells["Razón de la cita"].Value.ToString();
            dtpFechaHora.Value = Convert.ToDateTime(dgvVerCitas.CurrentRow.Cells["Fecha y hora"].Value);
            cbApellido.Text = dgvVerCitas.CurrentRow.Cells["Apellido del paciente"].Value.ToString();
            cbCorreo.Text = dgvVerCitas.CurrentRow.Cells["Correo del paciente"].Value.ToString();
            cbNombre.Text = dgvVerCitas.CurrentRow.Cells["Nombre del paciente"].Value.ToString();       
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbNombre.SelectedIndex == -1 || cbCorreo.SelectedIndex == -1 || cbApellido.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtRazonCita.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Cita C = new Cita();
            C.Id_Paciente = Convert.ToInt32(cbNombre.SelectedValue);
            C.RazonCita = txtRazonCita.Text;
            C.FechaHoraCita = dtpFechaHora.Value;
            C.IdCita = Convert.ToInt32(dgvVerCitas.CurrentRow.Cells[0].Value);

            if (C.ActualizarCita() == true)
            {
                MostrarCitas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la venta.", "Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVerCitas.DataSource = null;
                dgvVerCitas.DataSource = Cita.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtRazonCita.Text = string.Empty;

            // Restablecer ComboBox
            cbNombre.SelectedIndex = -1;
            cbApellido.SelectedIndex = -1;
            cbCorreo.SelectedIndex = -1;

            // Restablecer DateTimePicker 
            dtpFechaHora.Value = DateTime.Now;

        }

        #region TextBox

        Validaciones V = new Validaciones();
        private void txtRazonCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        #endregion
    }
}
