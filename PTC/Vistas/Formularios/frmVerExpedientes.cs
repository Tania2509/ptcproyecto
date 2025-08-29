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
    public partial class frmVerExpedientes : Form
    {
        public frmVerExpedientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestiondeExpedientes ventana = new frmGestiondeExpedientes(this);
            ventana.Visible = true;
            ventana.Show();
        }

        public void MostrarExpedientes()
        {
            dgvVerExpedientes.DataSource = null;
            dgvVerExpedientes.DataSource = Expediente.CargarExpedientes("select *from VerExpediente");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Expediente expediente = new Expediente();
            int id = int.Parse(dgvVerExpedientes.CurrentRow.Cells[0].Value.ToString());
            if (expediente.eliminarExpediente(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                MostrarExpedientes();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {
            MostrarExpedientes();
        }
    }
}
