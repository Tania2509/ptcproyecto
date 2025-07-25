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
    public partial class frmDashboardAsistente : Form
    {
        public frmDashboardAsistente()
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

            pnlCentralAsis.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        #endregion

        public frmDashboardAsistente(frmLogin formpadre)
        {
            InitializeComponent();
            frmLogin1 = formpadre;
        }

        private frmLogin frmLogin1;

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerCitas());
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerExpedientes());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin(this);
            this.Hide();
            ventana.Show();
        }
    }
}
