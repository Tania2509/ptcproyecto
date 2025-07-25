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
using static System.Net.Mime.MediaTypeNames;

namespace Vistas.Formularios
{
    public partial class frmGestiondeExpedientes : Form
    {
        public frmGestiondeExpedientes()
        {
            InitializeComponent();
        }

        public frmGestiondeExpedientes(frmVerExpedientes formpadre)
        {
            InitializeComponent();
            VerExpedientes = formpadre;
        }

        private frmVerExpedientes VerExpedientes;

        #region Combobox
        private void MostrarAlergias()
        {
            cbAlergias.DataSource = null;
            cbAlergias.DataSource = Expediente.CargarAlergia();
            cbAlergias.DisplayMember = "alergias";
            cbAlergias.ValueMember = "idExpediente";
            cbAlergias.SelectedIndex = -1;
        }

        private void MostrarEnfermedades()
        {
            cbEnfermedades.DataSource = null;
            cbEnfermedades.DataSource = Expediente.CargarEnfermedades();
            cbEnfermedades.DisplayMember = "enfermedades";
            cbEnfermedades.ValueMember = "idExpediente";
            cbEnfermedades.SelectedIndex = -1;
        }

        #endregion


        private void frmGestiondeExpedientes_Load(object sender, EventArgs e)
        {
            MostrarAlergias();
            MostrarEnfermedades();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Modelos.Entidades.Paciente P = new Paciente();

            P.NombrePa = txtNombre.Text;
            P.ApellidoPa = txtApellido.Text;
            P.TelefonoPa = txtNumTelefono.Text;
            P.Dui = txtDui.Text;
            P.CorreoPa = txtCorreoElectronico.Text;
            P.DireccionPa = txtDireccion.Text;
            P.FechaNacimiento = dtpFechaNaciPa.Value;
            P.Id_Expediente = Convert.ToInt32(cbAlergias.SelectedValue);
            P.InsertarPaciente();

            VerExpedientes.MostrarExpedientes();

            this.Close();
        }
    }

}

