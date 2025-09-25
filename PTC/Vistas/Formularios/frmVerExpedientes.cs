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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCitas.DataSource = null;
                dgvCitas.DataSource = Cita.ID(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarCitas()
        {
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Cita.CargarCitas("select *From DatosCita");
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {
            MostrarCitas();
        }

    }
}
