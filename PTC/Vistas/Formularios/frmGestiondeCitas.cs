using Modelos.Entidades;
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
    public partial class frmGestiondeCitas : Form
    {
        public frmGestiondeCitas()
        {
            InitializeComponent();
        }

        public frmGestiondeCitas(frmVerCitas formpadre)
        {
            InitializeComponent();
            VerCitas = formpadre;
        }

        private frmVerCitas VerCitas;


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

        private void frmGestiondeCitas_Load(object sender, EventArgs e)
        {
            dtpFecha_ValueChanged();
            MostrarNombre();
            MostrarApellido();
            MostrarCorreo();
            cbNombre.SelectedIndexChanged += cbNombre_SelectedIndexChanged;
        }

        private void btnProgramarCita_Click(object sender, EventArgs e)
        {
            Modelos.Entidades.Cita C = new Cita();

            C.Id_Paciente = Convert.ToInt32(cbNombre.SelectedValue);
            C.RazonCita = tbxRazonCita.Text;
            C.FechaHoraCita = dtpFechaHora.Value;
            C.InsertarCitas();
            VerCitas.MostrarCitas();

            this.Close();
        }
    }
}
