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
    public partial class frmVerTrabajadores : Form
    {
        public frmVerTrabajadores()
        {
            InitializeComponent();
        }

        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {
            frmGestiondeTrabajadores ventana = new frmGestiondeTrabajadores(this);
            ventana.Visible = true;
            ventana.Show();
        }

        private void frmVerTrabajadores_Load(object sender, EventArgs e)
        {
            MostrarTrabajadores();
        }

        public void MostrarTrabajadores()
        {
            dgvVerTrabajador.DataSource = null;
            dgvVerTrabajador.DataSource = Usuario.CargarUsuarios("select *from MostrarTrabajadores"); 
        }

        private void btnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            Usuario Trabajador = new Usuario();
            int id = int.Parse(dgvVerTrabajador.CurrentRow.Cells[0].Value.ToString());
            if (Trabajador.eliminarTrabajador(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarTrabajadores();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

    }
}
