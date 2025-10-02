using Modelos.Entidades;
using Modelos.Metodos;
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
    public partial class frmVerExpedientes : Form
    {
        public frmVerExpedientes()
        {
            InitializeComponent();            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPaciente = Convert.ToInt32(txtBuscar.Text);
            try
            {
                dgvCitas.DataSource = null;
                dgvCitas.DataSource = Cita.ID(txtBuscar.Text.Trim());
                dgvFecha.DataSource = Historial.CargarFechas(idPaciente);
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

        private void dgvFecha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPaciente;
                if (!int.TryParse(txtBuscar.Text, out idPaciente))
                {
                    MessageBox.Show("Ingrese un ID de paciente válido.");
                    return;
                }

                DateTime fechaSeleccionada = Convert.ToDateTime(dgvFecha.Rows[e.RowIndex].Cells["Fecha"].Value);

                dgvDientes.DataSource = Historial.CargarHistorialPorFecha(idPaciente, fechaSeleccionada);
            }
        }

        #region

        Validaciones V = new Validaciones();
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion
    }
}
