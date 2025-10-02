using Modelos.Entidades;
using Modelos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmGestionCitas : Form
    {
        public frmGestionCitas()
        {
            InitializeComponent();
        }

        #region Correo

        private void EnviarCorreoRecordatorio(string correoPaciente, DateTime fechaCita, string razonCita)
        {
            try
            {
                // Crea un objeto MailMessage
                MailMessage mensaje = new MailMessage();

                // Direcciones de correo
                mensaje.From = new MailAddress("dentalcleanverificacion@gmail.com"); // Tu dirección de Gmail
                mensaje.To.Add(correoPaciente); // Correo del paciente

                // Asunto y cuerpo del correo
                mensaje.Subject = "Recordatorio de Cita Médica";
                mensaje.Body = $"Estimado paciente, le recordamos que tiene una cita médica programada para el día {fechaCita.ToString("dd/MM/yyyy HH:mm")}. Razón: {razonCita}.";

                // Configuración SMTP para enviar el correo
                SmtpClient clienteSMTP = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("dentalcleanverificacion@gmail.com", "kplv shrw jbfo itfu"),
                    EnableSsl = true
                };

                // Enviar el correo
                clienteSMTP.Send(mensaje);
                MessageBox.Show("Correo de recordatorio enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DateTimePicker

        private void dtpFecha_ValueChanged()
        {
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        #endregion

        #region comboBox

        private void MostrarPacientes()
        {
            DataTable pacientes = Paciente.CargarPacientes(); // Método que usa tu vista VerExpediente

            // ComboBox de nombres
            cbNombre.DataSource = pacientes;
            cbNombre.DisplayMember = "Nombre del Paciente";
            cbNombre.ValueMember = "Expediente";

            // ComboBox de apellidos
            cbApellido.DataSource = pacientes;
            cbApellido.DisplayMember = "Apellido del paciente";
            cbApellido.ValueMember = "Expediente";

            // ComboBox de correos
            cbCorreo.DataSource = pacientes;
            cbCorreo.DisplayMember = "Correo del paciente";
            cbCorreo.ValueMember = "Expediente";

            // No seleccionar nada por defecto
            cbNombre.SelectedIndex = -1;
            cbApellido.SelectedIndex = -1;
            cbCorreo.SelectedIndex = -1;
        }


        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombre.SelectedIndex != -1)
            {

                    cbApellido.SelectedIndex = cbNombre.SelectedIndex;
                    cbCorreo.SelectedIndex = cbNombre.SelectedIndex;        
            }
        }


        #endregion



        private bool ValidarFechaCita(DateTime fechaCita)
        {
            DateTime fechaMinima = DateTime.Today.AddDays(1); // Mañana en adelante
            return fechaCita >= fechaMinima;
        }



        public void MostrarCitas()
        {
            dgvVerCitas.DataSource = null;
            dgvVerCitas.DataSource = Cita.CargarCitas("select *From DatosCita");
        }

        private void dgvVerCitas_DoubleClick(object sender, EventArgs e)
        {
            txtRazonCita.Text = dgvVerCitas.CurrentRow.Cells["Razón de la cita"].Value.ToString();
            dtpFechaHora.Value = Convert.ToDateTime(dgvVerCitas.CurrentRow.Cells["Fecha y hora"].Value);
            cbApellido.Text = dgvVerCitas.CurrentRow.Cells["Apellido del paciente"].Value.ToString();
            cbCorreo.Text = dgvVerCitas.CurrentRow.Cells["Correo del paciente"].Value.ToString();
            cbNombre.Text = dgvVerCitas.CurrentRow.Cells["Nombre del paciente"].Value.ToString();       
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVerCitas.DataSource = null;
                dgvVerCitas.DataSource = Cita.Buscar(txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtRazonCita.Text = string.Empty;

            // Restablecer ComboBox
            cbNombre.SelectedIndex = -1;
            cbApellido.SelectedIndex = -1;
            cbCorreo.SelectedIndex = -1;

            // Restablecer DateTimePicker 
            dtpFechaHora.Value = DateTime.Now;

        }

        #region TextBox

        Validaciones V = new Validaciones();
        private void txtRazonCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.Letras(sender, e);
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (cbNombre.SelectedIndex == -1 || cbApellido.SelectedIndex == -1 || cbCorreo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtRazonCita.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!ValidarFechaCita(dtpFechaHora.Value))
            {
                MessageBox.Show("La cita debe ser para una fecha futura (a partir de mañana)",
                               "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaHora.Focus();
                return;
            }

            // Crear objeto cita
            Modelos.Entidades.Cita C = new Cita();
            C.Id_Paciente = Convert.ToInt32(cbNombre.SelectedValue); // Expediente como ID
            C.RazonCita = txtRazonCita.Text;
            C.FechaHoraCita = dtpFechaHora.Value;
            C.InsertarCitas();
           

            // Obtener el correo del paciente seleccionado
            string correoPaciente = cbCorreo.Text;

            // Validación del correo antes de enviar
            if (string.IsNullOrWhiteSpace(correoPaciente))
            {
                MessageBox.Show("El paciente seleccionado no tiene un correo registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(correoPaciente, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo del paciente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LimpiarCampos();
            // Enviar recordatorio
            EnviarCorreoRecordatorio(correoPaciente, dtpFechaHora.Value, txtRazonCita.Text);

            MessageBox.Show("Cita agendada correctamente");
        
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (cbNombre.SelectedIndex == -1 || cbCorreo.SelectedIndex == -1 || cbApellido.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtRazonCita.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Cita C = new Cita();
            C.Id_Paciente = Convert.ToInt32(cbNombre.SelectedValue);
            C.RazonCita = txtRazonCita.Text;
            C.FechaHoraCita = dtpFechaHora.Value;
            C.IdCita = Convert.ToInt32(dgvVerCitas.CurrentRow.Cells[0].Value);

            if (C.ActualizarCita() == true)
            {
                //MostrarCitas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la venta.", "Error");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Cita cita = new Cita();
            int id = int.Parse(dgvVerCitas.CurrentRow.Cells[0].Value.ToString());
            if (cita.eliminarCita(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente", "Exito");
                //MostrarCitas();
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGestionCitas_Load(object sender, EventArgs e)
        {
            MostrarCitas();
            dtpFecha_ValueChanged();
            try
            {
                MostrarPacientes();  // Carga nombres, apellidos y correos desde la vista VerExpediente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
