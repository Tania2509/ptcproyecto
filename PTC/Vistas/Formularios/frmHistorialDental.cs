using Modelos.Conexion;
using Modelos.Entidades;
using Modelos.Metodos;
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

            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        private void AjustarColumnasDataGrid()
        {
            dgvHistorial.Columns[1].Width = 35;
            dgvHistorial.Columns[2].Width = 245;
            dgvHistorial.Columns[3].Width = 110;
            dgvHistorial.Columns[4].Width = 110;
        }

        private void frmHistorialDental_Load(object sender, EventArgs e)
        {
            MostrarHistorial();
            dgvHistorial.Columns["idDiente"].Visible = false;
            dgvHistorial.Columns["Diente"].ReadOnly = true;
            dgvHistorial.Columns["N."].ReadOnly = true;
            dgvHistorial.Columns["Estado"].ReadOnly = true;
            AjustarColumnasDataGrid();

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
            colEstado.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colEstado.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;

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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            List<Historial> lista = new List<Historial>();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtPaciente.Text))
            {
                MessageBox.Show("Ingresa el DUI del Paciente", "Campos vacíos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dui = txtPaciente.Text.Trim();

            // Obtener id del expediente
            int? idExpediente = Modelos.Entidades.Historial.ObtenerIdExpedientePorDui(dui);

            if (idExpediente == null)
            {
                MessageBox.Show("El paciente con el DUI ingresado no existe.",
                                "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvHistorial.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Estado"].Value != null) // solo si seleccionaron un estado
                {
                    Historial h = new Historial
                    {
                        IdDiente = Convert.ToInt32(row.Cells["idDiente"].Value),
                        IdEstado = Convert.ToInt32(row.Cells["Estado"].Value),
                        Observaciones = row.Cells["Observaciones"].Value?.ToString(),
                    };

                    lista.Add(h);
                }
            }

            if (lista.Count == 32) // o cambiar a >= 1 si solo se requiere al menos un estado
            {
                if (Modelos.Entidades.Historial.InsertarHistorial(lista, idExpediente.Value))
                {
                    MessageBox.Show("Historial guardado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar los estados de todos los dientes antes de guardar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Validaciones V = new Validaciones();
        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

    }
}