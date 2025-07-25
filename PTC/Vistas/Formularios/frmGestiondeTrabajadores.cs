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
using Vistas.Formularios;

namespace Vistas.Formularios
{
    public partial class frmGestiondeTrabajadores : Form
    {
        public frmGestiondeTrabajadores(frmVerTrabajadores formpadre)
        {
            InitializeComponent();
            frmVerTrabajadores1 = formpadre;
        }

        private void frmGestiondeTrabajadores_Load(object sender, EventArgs e)
        {
            CargarEspecialidad();
            mostrarRol();
        }

        private frmVerTrabajadores frmVerTrabajadores1;

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

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            Modelos.Entidades.Usuario U = new Usuario();

            U.NombreU = txtNombre.Text;
            U.ApellidoU = txtApellido.Text;
            U.TelefonoU = txtTelefono.Text;
            U.DuiU = txtDui.Text;
            U.FechaNacimientoU = dtpFechaNaci.Value;
            U.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            U.Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
            U.InsetarUsuarios();

            frmVerTrabajadores1.MostrarTrabajadores();

            this.Close();
        }
    }
}
