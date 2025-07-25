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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region CerrarSesion
        //Este es el constructor que me permite cerrar sesión desde el formulario de login  
        public frmLogin(frmDashboardAdministrador formpadre)
        { 
            InitializeComponent();
            frminlogin1 = formpadre;
        }

        public frmLogin(frmDashboardAsistente formpadre)
        {
            InitializeComponent();
            frminlogin2 = formpadre;
        }

        public frmLogin(frmDashboardDoctor formpadre)
        {
            InitializeComponent();
            frminlogin3 = formpadre;
        }

        private frmDashboardAdministrador frminlogin1;
        private frmDashboardAsistente frminlogin2;
        private frmDashboardDoctor frminlogin3;

        #endregion

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "1234" && txtCorreo.Text == "administrador@gmail.com")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardAdministrador ventana = new frmDashboardAdministrador(this);
                this.Hide();
                ventana.Show();
            }
            else if (txtContraseña.Text == "12345" && txtCorreo.Text == "1234@gmail.com")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardAsistente ventana = new frmDashboardAsistente(this);
                this.Hide();
                ventana.Show();
            }
            else if (txtContraseña.Text == "1200" && txtCorreo.Text == "4321@gmail.com")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardDoctor ventana = new frmDashboardDoctor(this);
                this.Hide();
                ventana.Show();
            }

            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
