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
    public partial class frmVerCitas : Form
    {
        public frmVerCitas()
        {
            InitializeComponent();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            frmGestiondeCitas ventana = new frmGestiondeCitas(this);
            ventana.Visible = true;
            ventana.Show();
        }

        private void frmVerCitas_Load(object sender, EventArgs e)
        {
            MostrarCitas();
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
    }
}
