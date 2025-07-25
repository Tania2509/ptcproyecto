namespace Vistas.Formularios
{
    partial class frmGestiondeCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiondeCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCorreo = new System.Windows.Forms.ComboBox();
            this.cbApellido = new System.Windows.Forms.ComboBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.btnProgramarCita = new System.Windows.Forms.Button();
            this.lblRazonCita = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxRazonCita = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 3);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(300, 600);
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cbCorreo);
            this.panel1.Controls.Add(this.cbApellido);
            this.panel1.Controls.Add(this.cbNombre);
            this.panel1.Controls.Add(this.dtpFechaHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblCorreoElectronico);
            this.panel1.Controls.Add(this.btnProgramarCita);
            this.panel1.Controls.Add(this.lblRazonCita);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.tbxRazonCita);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 360);
            this.panel1.TabIndex = 3;
            // 
            // cbCorreo
            // 
            this.cbCorreo.FormattingEnabled = true;
            this.cbCorreo.Location = new System.Drawing.Point(38, 271);
            this.cbCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCorreo.Name = "cbCorreo";
            this.cbCorreo.Size = new System.Drawing.Size(303, 28);
            this.cbCorreo.TabIndex = 17;
            // 
            // cbApellido
            // 
            this.cbApellido.FormattingEnabled = true;
            this.cbApellido.Location = new System.Drawing.Point(38, 131);
            this.cbApellido.Margin = new System.Windows.Forms.Padding(2);
            this.cbApellido.Name = "cbApellido";
            this.cbApellido.Size = new System.Drawing.Size(303, 28);
            this.cbApellido.TabIndex = 16;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(38, 51);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(303, 28);
            this.cbNombre.TabIndex = 15;
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHora.Location = new System.Drawing.Point(38, 360);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(303, 26);
            this.dtpFechaHora.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 324);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(125, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de la cita:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(35, 251);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(140, 20);
            this.lblCorreoElectronico.TabIndex = 10;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // btnProgramarCita
            // 
            this.btnProgramarCita.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProgramarCita.ForeColor = System.Drawing.Color.White;
            this.btnProgramarCita.Location = new System.Drawing.Point(362, 410);
            this.btnProgramarCita.Name = "btnProgramarCita";
            this.btnProgramarCita.Size = new System.Drawing.Size(150, 53);
            this.btnProgramarCita.TabIndex = 9;
            this.btnProgramarCita.Text = "Programar Cita";
            this.btnProgramarCita.UseVisualStyleBackColor = false;
            this.btnProgramarCita.Click += new System.EventHandler(this.btnProgramarCita_Click);
            // 
            // lblRazonCita
            // 
            this.lblRazonCita.AutoSize = true;
            this.lblRazonCita.Location = new System.Drawing.Point(34, 169);
            this.lblRazonCita.Name = "lblRazonCita";
            this.lblRazonCita.Size = new System.Drawing.Size(122, 20);
            this.lblRazonCita.TabIndex = 8;
            this.lblRazonCita.Text = "Motivo de la cita";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(36, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxRazonCita
            // 
            this.tbxRazonCita.Location = new System.Drawing.Point(38, 192);
            this.tbxRazonCita.Multiline = true;
            this.tbxRazonCita.Name = "tbxRazonCita";
            this.tbxRazonCita.Size = new System.Drawing.Size(303, 25);
            this.tbxRazonCita.TabIndex = 3;
            // 
            // frmGestiondeCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_49;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestiondeCitas";
            this.Text = "frmGestiondeCitas";
            this.Load += new System.EventHandler(this.frmGestiondeCitas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Button btnProgramarCita;
        private System.Windows.Forms.Label lblRazonCita;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxRazonCita;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.ComboBox cbApellido;
        private System.Windows.Forms.ComboBox cbCorreo;
    }
}