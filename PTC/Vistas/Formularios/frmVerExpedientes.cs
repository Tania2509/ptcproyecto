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

            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("Ingrese el DUI del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idPaciente = Convert.ToInt32(txtBuscar.Text);
                dgvPacientes.DataSource = null;
                dgvPacientes.DataSource = Cita.ID(txtBuscar.Text.Trim());
                dgvFecha.DataSource = Historial.CargarFechas(idPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AjustarColumnasDataGrid()
        {
            if (dgvDientes.Columns.Count > 0)
            {
                dgvDientes.Columns[0].Width = 35;
                dgvDientes.Columns[1].Width = 245;
                dgvDientes.Columns[2].Width = 110;
                dgvDientes.Columns[3].Width = 110;
            }

            if (dgvPacientes.Columns.Count > 1)
            {
                dgvPacientes.Columns[1].Width = 200;
                dgvPacientes.Columns[3].Width = 150;
            }
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = Paciente.CargarPacientesHistorial();
            dgvPacientes.Columns[0].Visible = false;
            AjustarColumnasDataGrid();
        }

        #region

        Validaciones V = new Validaciones();
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                dgvPacientes.DataSource = Paciente.CargarPacientesHistorial();
                dgvPacientes.Columns[0].Visible = false;
            }
            else
            {
                dgvPacientes.DataSource = Paciente.BuscarPaciente(filtro);
                dgvPacientes.Columns[0].Visible = false;
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar errores si se da click en encabezados
            {
                // Obtengo el idPaciente de la fila seleccionada
                int idPaciente = Convert.ToInt32(dgvPacientes.Rows[e.RowIndex].Cells["idPaciente"].Value);

                // Cargo las fechas de ese paciente en el dgvFechas
                dgvFecha.DataSource = Historial.CargarFechas(idPaciente);
            }
        }
    }
}
