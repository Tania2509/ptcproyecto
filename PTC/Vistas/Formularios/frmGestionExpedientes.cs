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

namespace Vistas.Formularios
{
    public partial class frmGestionExpedientes : Form
    {

        public frmGestionExpedientes()
        {
            InitializeComponent();
            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            txtDui.Text = string.Empty;

            // Restablecer CheckedListBox
            foreach (int i in clbEnfermedades.CheckedIndices)
            {
                clbEnfermedades.SetItemChecked(i, false);
            }

            foreach (int i in clbAlergias.CheckedIndices)
            {
                clbAlergias.SetItemChecked(i, false);
            }

            // Restablecer DateTimePicker
            dtpFechaNaci.Value = DateTime.Now;

        }

        private bool ValidarEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
                edad--;

            // Validar rango de edad (1 a 80 años)
            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser 1 año", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaci.Focus();
                return false;
            }

            if (edad > 90)
            {
                MessageBox.Show("La edad máxima no puede superar los 90 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaci.Focus();
                return false;
            }

            return true;
        }

        private void MostrarExpedientes()
        {
            dgvVerExpedientes.DataSource = null;
            dgvVerExpedientes.DataSource = Expediente.CargarExpedientes("select *from VerExpediente");
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {

            MostrarExpedientes();
            MostrarAlergias();
            MostrarEnfermedades();
        }

        #region CheckedListBox
        private void MostrarAlergias()
        {
            DataTable dtAlergias = Alergias.CargarAlergias();
            clbAlergias.DataSource = dtAlergias;
            clbAlergias.DisplayMember = "nombreAl";
            clbAlergias.ValueMember = "idAlergias";
        }

        private void MostrarEnfermedades()
        {
            DataTable dtEnfermedades = Enfermedades.CargarEnfermedades();
            clbEnfermedades.DataSource = dtEnfermedades;
            clbEnfermedades.DisplayMember = "nombreEnfer"; 
            clbEnfermedades.ValueMember = "idEnfermedades"; 
        }
        #endregion

        private void dgvVerExpedientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVerExpedientes.CurrentRow == null) return;

            txtNombre.Text = dgvVerExpedientes.CurrentRow.Cells["Nombre del Paciente"].Value.ToString();
            txtApellido.Text = dgvVerExpedientes.CurrentRow.Cells["Apellido del paciente"].Value.ToString();
            txtTelefono.Text = dgvVerExpedientes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDui.Text = dgvVerExpedientes.CurrentRow.Cells["DUI"].Value.ToString();
            txtCorreo.Text = dgvVerExpedientes.CurrentRow.Cells["Correo del paciente"].Value.ToString();
            txtDireccion.Text = dgvVerExpedientes.CurrentRow.Cells["Direccion"].Value.ToString();
            dtpFechaNaci.Value = Convert.ToDateTime(dgvVerExpedientes.CurrentRow.Cells["Fecha de nacimiento"].Value);

            // Cargar enfermedades y alergias del expediente seleccionado
            int expedienteId = Convert.ToInt32(dgvVerExpedientes.CurrentRow.Cells[0].Value);
            CargarEnfermedadesDelExpediente(expedienteId);
            CargarAlergiasDelExpediente(expedienteId);
        }

        #region CargarCheckedListBox

        private void CargarEnfermedadesDelExpediente(int expedienteId)
        {
            // Desmarcar todos primero
            for (int i = 0; i < clbEnfermedades.Items.Count; i++)
            {
                clbEnfermedades.SetItemChecked(i, false);
            }

            // Marcar las enfermedades del expediente
            List<int> enfermedades = Expediente.ObtenerEnfermedadesPorExpediente(expedienteId);
            foreach (int enfermedadId in enfermedades)
            {
                for (int i = 0; i < clbEnfermedades.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)clbEnfermedades.Items[i];
                    if ((int)item["idEnfermedades"] == enfermedadId)
                    {
                        clbEnfermedades.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void CargarAlergiasDelExpediente(int expedienteId)
        {
            // Desmarcar todos primero
            for (int i = 0; i < clbAlergias.Items.Count; i++)
            {
                clbAlergias.SetItemChecked(i, false);
            }

            // Marcar las alergias del expediente
            List<int> alergias = Expediente.ObtenerAlergiasPorExpediente(expedienteId);
            foreach (int alergiaId in alergias)
            {
                for (int i = 0; i < clbAlergias.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)clbAlergias.Items[i];
                    if ((int)item["idAlergias"] == alergiaId)
                    {
                        clbAlergias.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        #endregion

        #region TextBox

        Validaciones V = new Validaciones();
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        private void txtNumTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Numeros(sender, e);
        }

        #endregion

        // Método para validar email
        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validaciones previas (las que ya tienes)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !EsEmailValido(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                return;
            }

            if (Expediente.DuiExiste(txtDui.Text))
            {
                MessageBox.Show("Ese DUI ya está registrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDui.Focus();
                return;
            }

            if (!ValidarEdad(dtpFechaNaci.Value))
                return;

            // Obtener enfermedades seleccionadas - CORREGIDO
            List<int> enfermedadesIds = new List<int>();
            foreach (int index in clbEnfermedades.CheckedIndices)
            {
                DataRowView row = (DataRowView)clbEnfermedades.Items[index];
                enfermedadesIds.Add((int)row["idEnfermedades"]);
            }

            // Obtener alergias seleccionadas - CORREGIDO
            List<int> alergiasIds = new List<int>();
            foreach (int index in clbAlergias.CheckedIndices)
            {
                DataRowView row = (DataRowView)clbAlergias.Items[index];
                alergiasIds.Add((int)row["idAlergias"]);
            }

            Modelos.Entidades.Expediente E = new Expediente();
            E.NombrePa = txtNombre.Text;
            E.ApellidoPa = txtApellido.Text;
            E.TelefonoPa = txtTelefono.Text;
            E.Dui = txtDui.Text;
            E.CorreoPa = txtCorreo.Text;
            E.DireccionPa = txtDireccion.Text;
            E.FechaNacimiento = dtpFechaNaci.Value;
            E.EnfermedadesIds = enfermedadesIds;
            E.AlergiasIds = alergiasIds;

            if (E.InsertarExpediente())
            {
                MostrarExpedientes();
                LimpiarCampos();
                MessageBox.Show("Datos ingresados correctamente");
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
    string.IsNullOrWhiteSpace(txtApellido.Text) ||
    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
    string.IsNullOrWhiteSpace(txtDui.Text) ||
    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
    string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            // Obtener enfermedades seleccionadas - CORREGIDO
            List<int> enfermedadesIds = new List<int>();
            foreach (int index in clbEnfermedades.CheckedIndices)
            {
                DataRowView row = (DataRowView)clbEnfermedades.Items[index];
                enfermedadesIds.Add((int)row["idEnfermedades"]);
            }

            // Obtener alergias seleccionadas - CORREGIDO
            List<int> alergiasIds = new List<int>();
            foreach (int index in clbAlergias.CheckedIndices)
            {
                DataRowView row = (DataRowView)clbAlergias.Items[index];
                alergiasIds.Add((int)row["idAlergias"]);
            }

            Expediente E = new Expediente();
            E.NombrePa = txtNombre.Text;
            E.ApellidoPa = txtApellido.Text;
            E.TelefonoPa = txtTelefono.Text;
            E.Dui = txtDui.Text;
            E.CorreoPa = txtCorreo.Text;
            E.DireccionPa = txtDireccion.Text;
            E.FechaNacimiento = dtpFechaNaci.Value;
            E.EnfermedadesIds = enfermedadesIds;
            E.AlergiasIds = alergiasIds;
            E.IdExpediente = Convert.ToInt32(dgvVerExpedientes.CurrentRow.Cells[0].Value);

            if (E.ActualizarExpedientes())
            {
                MostrarExpedientes();
                LimpiarCampos();
                MessageBox.Show("Expediente actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar el expediente.", "Error");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Validar que hay una fila seleccionada
            if (dgvVerExpedientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmLogin L = new frmLogin();

            if (L.Usuario == 1)
            {
                MessageBox.Show("No tienes permisos para eliminar registros.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del paciente para mostrar en la confirmación
            string nombrePaciente = dgvVerExpedientes.CurrentRow.Cells[1].Value?.ToString() ?? "";
            string apellidoPaciente = dgvVerExpedientes.CurrentRow.Cells[2].Value?.ToString() ?? "";
            int id = int.Parse(dgvVerExpedientes.CurrentRow.Cells[0].Value.ToString());

            // Mostrar diálogo de confirmación
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar este expediente?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Yes)
            {
                Expediente expediente = new Expediente();

                if (expediente.eliminarExpediente(id))
                {
                    MostrarExpedientes();
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada", "Cancelado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvVerExpedientes.DataSource = null;
                dgvVerExpedientes.DataSource = Usuario.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
