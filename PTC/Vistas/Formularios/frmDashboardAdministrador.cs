using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmDashboardAdministrador : Form
    {
        public frmDashboardAdministrador()
        {
            InitializeComponent();
        }

        public frmDashboardAdministrador(frmLogin formpadre)
        {
            InitializeComponent();
            frmLogin1 = formpadre;
        }


        private frmLogin frmLogin1;
        private void frmDashboardAdministrador_Load(object sender, EventArgs e)
        {
            lblUsuario.ForeColor = Color.White;
            lblVentas.ForeColor = Color.White;
        }

        #region

        private Form activarForm = null;
        //Creando el metodo que me va permitir activar los formularios

        private void AbrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            {
                //esto detecta si hay un formulario abierto
                activarForm.Close();
            }

            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;

            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlFormulario.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        #endregion

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionTrabajadores());
            lblUsuario.ForeColor = Color.MediumAquamarine;
            lblVentas.ForeColor = Color.White;
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionVenta());
            lblVentas.ForeColor = Color.MediumAquamarine;
            lblUsuario.ForeColor = Color.White;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            this.Hide();
            ventana.Show();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/file/d/1MtfXVBMV8nK60ZSzsOhChZI7qsJLPdAK/view?usp=sharing");
        }
    }
}
