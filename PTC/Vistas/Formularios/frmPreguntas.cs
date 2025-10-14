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
using System.Xml.Linq;
using BCrypt.Net;

namespace Vistas.Formularios
{
    public partial class frmPreguntas : Form
    {

        public frmPreguntas()
        {
            InitializeComponent();

            // Habilitar double buffering para el formulario
            this.DoubleBuffered = true;

            // O también puedes usar:
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        private int preguntas;
        private int idUsuario;

        public int Preguntas { get => preguntas; set => preguntas = value; }



        #region Métodos auxiliares

        public static bool ExistenPreguntas()
        {
            string archivoXML = "preguntas_seguridad.xml";
            if (!System.IO.File.Exists(archivoXML))
                return false;

            var doc = XDocument.Load(archivoXML);
            return doc.Descendants("Pregunta").Any();
        }

        private bool ValidarCampos(IEnumerable<TextBox> txts, IEnumerable<ComboBox> combos = null)
        {
            if (txts.Any(t => string.IsNullOrWhiteSpace(t.Text)))
                return false;

            if (combos != null && combos.Any(c => c.SelectedIndex == -1))
                return false;

            return true;
        }

        private Dictionary<string, string> ObtenerPreguntasRespuestas()
        {
            return new Dictionary<string, string>
            {
                { cbPregunta1.Text, txtPregunta1.Text },
                { cbPregunta2.Text, txtPregunta2.Text },
                { cbPregunta3.Text, txtPregunta3.Text },
                { cbPregunta4.Text, txtPregunta4.Text }
            };
        }

        private XDocument ObtenerDocumentoXML(string archivoXML)
        {
            return System.IO.File.Exists(archivoXML)
                ? XDocument.Load(archivoXML)
                : new XDocument(new XElement("PreguntasSeguridad"));
        }

        private int ObtenerIdUsuarioPorDUI(string dui)
        {
            using (SqlConnection con = Conexion.conectar())
            using (SqlCommand cmd = new SqlCommand("SELECT idUsuario FROM Usuario WHERE dui = @dui", con))
            {
                cmd.Parameters.AddWithValue("@dui", dui);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            }
        }

        private string EncriptarRespuesta(string respuesta) => BCrypt.Net.BCrypt.HashPassword(respuesta);

        #endregion

        #region XML y BCrypt

        private void GuardarPreguntasEnXML(Dictionary<string, string> preguntasRespuestas)
        {
            try
            {
                string archivoXML = "preguntas_seguridad.xml";
                var doc = ObtenerDocumentoXML(archivoXML);

                var preguntasGlobales = doc.Descendants("PreguntasGlobales").FirstOrDefault();
                if (preguntasGlobales != null)
                    preguntasGlobales.RemoveNodes();
                else
                {
                    preguntasGlobales = new XElement("PreguntasGlobales");
                    doc.Root.Add(preguntasGlobales);
                }

                foreach (var pr in preguntasRespuestas)
                {
                    preguntasGlobales.Add(new XElement("Pregunta",
                        new XElement("Texto", pr.Key),
                        new XElement("RespuestaEncriptada", EncriptarRespuesta(pr.Value)),
                        new XElement("FechaCreacion", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}")
                    ));
                }

                doc.Save(archivoXML);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar en XML: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificarRespuestasDesdeXML(Dictionary<string, string> preguntasRespuestas)
        {
            try
            {
                string archivoXML = "preguntas_seguridad.xml";
                if (!System.IO.File.Exists(archivoXML)) return false;

                var doc = XDocument.Load(archivoXML);
                var preguntasGlobales = doc.Descendants("PreguntasGlobales").FirstOrDefault();
                if (preguntasGlobales == null) return false;

                foreach (var pr in preguntasRespuestas)
                {
                    var pregunta = preguntasGlobales.Elements("Pregunta")
                        .FirstOrDefault(p => p.Element("Texto").Value == pr.Key);

                    if (pregunta == null) return false;

                    string respuestaEncriptada = pregunta.Element("RespuestaEncriptada").Value;
                    if (!BCrypt.Net.BCrypt.Verify(pr.Value, respuestaEncriptada))
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar respuestas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CargarPreguntasDesdeXML()
        {
            try
            {
                string archivoXML = "preguntas_seguridad.xml";
                if (!System.IO.File.Exists(archivoXML))
                {
                    MessageBox.Show("No se han configurado preguntas de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var doc = XDocument.Load(archivoXML);
                var preguntas = doc.Descendants("PreguntasGlobales")
                                   .Elements("Pregunta")
                                   .Take(4).ToList();

                if (preguntas.Count < 4)
                {
                    MessageBox.Show("No hay suficientes preguntas configuradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cbPregunta1.Text = preguntas[0].Element("Texto").Value;
                cbPregunta2.Text = preguntas[1].Element("Texto").Value;
                cbPregunta3.Text = preguntas[2].Element("Texto").Value;
                cbPregunta4.Text = preguntas[3].Element("Texto").Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar preguntas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPregunta1.Text) || string.IsNullOrWhiteSpace(txtPregunta2.Text) ||
                string.IsNullOrWhiteSpace(txtPregunta3.Text) || string.IsNullOrWhiteSpace(txtPregunta4.Text) || 
                cbPregunta1.SelectedIndex == -1 || cbPregunta2.SelectedIndex == -1 || 
                cbPregunta3.SelectedIndex == -1 || cbPregunta4.SelectedIndex == -1) 
            { 
                MessageBox.Show("No dejes campos vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }

            try
            {
                GuardarPreguntasEnXML(ObtenerPreguntasRespuestas());
                MessageBox.Show("Preguntas de seguridad creadas exitosamente!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al guardar las preguntas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Preguntas = 1; // Cambiar el estado a 1 después de agregar preguntas
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(new[] { txtPregunta1, txtPregunta2, txtPregunta3, txtPregunta4 }))
            {
                MessageBox.Show("No dejes campos de respuesta vacíos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dui = txtDUI.Text.Trim();
            if (string.IsNullOrWhiteSpace(dui))
            {
                MessageBox.Show("Por favor ingrese su DUI para proceder.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idUsuario = ObtenerIdUsuarioPorDUI(dui);
            if (idUsuario == 0)
            {
                MessageBox.Show("No se encontró un usuario con ese DUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VerificarRespuestasDesdeXML(ObtenerPreguntasRespuestas()))
            {
                MessageBox.Show("Respuestas verificadas correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmCambioContraseña(idUsuario).ShowDialog();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Las respuestas no coinciden. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPreguntas_Load(object sender, EventArgs e)
        {

            if (Preguntas == 0)
            {
                // Agregar preguntas (Administrador)
                btnAgregar.Visible = true;
                btnCancelar.Visible = true;
                btnVerificar.Visible = false;
                lblDui.Visible = false;
                lblPregunta.Visible = true;
                txtDUI.Visible = false;
                btnVerificar.Enabled = false;

                cbPregunta1.Enabled = cbPregunta2.Enabled = cbPregunta3.Enabled = cbPregunta4.Enabled = true;
                cbPregunta1.SelectedIndex = cbPregunta2.SelectedIndex = cbPregunta3.SelectedIndex = cbPregunta4.SelectedIndex = -1;
                txtPregunta1.Clear(); txtPregunta2.Clear(); txtPregunta3.Clear(); txtPregunta4.Clear();
            }
            else if (Preguntas == 1)
            {
                // Verificar respuestas (Usuario)
                btnAgregar.Visible = false;
                btnCancelar.Visible = false;
                btnVerificar.Visible = true;
                lblDui.Visible = lblPregunta.Visible = txtDUI.Visible = true;
                lblDui.Text = "Ingrese su DUI:";

                CargarPreguntasDesdeXML();

                cbPregunta1.Enabled = cbPregunta2.Enabled = cbPregunta3.Enabled = cbPregunta4.Enabled = false;
            }
        }
    }
}

