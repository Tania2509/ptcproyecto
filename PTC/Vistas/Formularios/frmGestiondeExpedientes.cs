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


        private void frmGestiondeExpedientes_Load(object sender, EventArgs e)
        {
            MostrarAlergias();
            MostrarEnfermedades();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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

            VerExpedientes.MostrarExpedientes();

            this.Close();
        }
    }

}

