using Modelos.Conexion;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmHistorialDental : Form
    {
        public frmHistorialDental()
        {
            InitializeComponent();
        }

        private void frmHistorialDental_Load(object sender, EventArgs e)
        {
            MostrarHistorial();
            dgvHistorial.Columns["idDiente"].Visible = false;
        }

        public void MostrarHistorial()
        {
            // 1. Limpiar cualquier configuración previa
            dgvHistorial.Columns.Clear();
            dgvHistorial.DataSource = null;

            // 2. Asignar la lista de dientes (Número y Diente)
            Diente Diente = new Diente();
            dgvHistorial.DataSource = Diente.CargarDientes();

            // 3. Agregar columna ComboBox para Estado
            DataGridViewComboBoxColumn colEstado = new DataGridViewComboBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado del Diente";

            // Llenar el combo con estados desde la BD
            EstadoDiente estado = new EstadoDiente();
            colEstado.DataSource = estado.ObtenerEstados();
            colEstado.DisplayMember = "nombre_estado"; // lo que ve el usuario
            colEstado.ValueMember = "idEstado";        // lo que se guarda

            dgvHistorial.Columns.Add(colEstado);

            // 4. Agregar columna de Observaciones
            DataGridViewTextBoxColumn colObs = new DataGridViewTextBoxColumn();
            colObs.Name = "Observaciones";
            colObs.HeaderText = "Observaciones";
            dgvHistorial.Columns.Add(colObs);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Historial> lista = new List<Historial>();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtPaciente.Text))
            {
                MessageBox.Show("Ingresa el número del Paciente", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPaciente = Convert.ToInt32(txtPaciente.Text); // 🔹 paciente seleccionado

            foreach (DataGridViewRow row in dgvHistorial.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Estado"].Value != null) // solo si seleccionaron un estado
                {
                    Historial h = new Historial
                    {
                        IdPaciente = idPaciente, // 🔹 se guarda con cada registro
                        IdDiente = Convert.ToInt32(row.Cells["idDiente"].Value),
                        IdEstado = Convert.ToInt32(row.Cells["Estado"].Value),
                        Observaciones = row.Cells["Observaciones"].Value?.ToString(),
                        Fecha = dtpFecha.Value.Date // solo fecha, sin hora
                    };

                    lista.Add(h);
                }
            }

            if (lista.Count > 0)
            {
                if (Modelos.Entidades.Historial.InsertarHistorial(lista))
                {
                    MessageBox.Show("Historial guardado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un estado para guardar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}