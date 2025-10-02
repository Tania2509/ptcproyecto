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
    public partial class frmDashboardTrabajador : Form
    {
        public frmDashboardTrabajador()
        {
            InitializeComponent();
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

            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        #endregion

        public frmDashboardTrabajador(frmLogin formpadre)
        {
            InitializeComponent();
            frmLogin1 = formpadre;
        }

        private frmLogin frmLogin1;


        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerExpedientes());
        }


        private void lblExpedientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionExpedientes());
            lblExpedientes.ForeColor = Color.MediumAquamarine;
            lblCita.ForeColor = Color.White;
            lblVerExpedientes.ForeColor = Color.White;
            lblDental.ForeColor = Color.White;
        }

        private void lblCita_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionCitas());
            lblCita.ForeColor = Color.MediumAquamarine;
            lblExpedientes.ForeColor = Color.White;
            lblVerExpedientes.ForeColor = Color.White;
            lblDental.ForeColor = Color.White;
        }

        private void lblDental_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmHistorialDental());
            lblDental.ForeColor = Color.MediumAquamarine;
            lblCita.ForeColor = Color.White;
            lblExpedientes.ForeColor = Color.White;
            lblVerExpedientes.ForeColor = Color.White;
        }

        private void lblVerExpedientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerExpedientes());
            lblVerExpedientes.ForeColor = Color.MediumAquamarine;
            lblCita.ForeColor = Color.White;
            lblExpedientes.ForeColor = Color.White;
            lblDental.ForeColor = Color.White;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            this.Hide();
            ventana.Show();
        }

        private void frmDashboardTrabajador_Load(object sender, EventArgs e)
        {
            lblVerExpedientes.ForeColor = Color.White;
            lblCita.ForeColor = Color.White;
            lblDental.ForeColor = Color.White;
            lblExpedientes.ForeColor = Color.White;
        }
    }
}
