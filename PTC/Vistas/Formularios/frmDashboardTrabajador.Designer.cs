namespace Vistas.Formularios
{
    partial class frmDashboardTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardTrabajador));
            this.pnlNavegador = new Modelos.Metodos.PanelRedondeado();
            this.btnManual = new Modelos.Botones.BotonesPSNLSD();
            this.btnCerrar = new Modelos.Botones.BotonesPSNLSD();
            this.btnFinalizar = new Modelos.Botones.BotonesPSNLSD();
            this.lblVerExpedientes = new System.Windows.Forms.Label();
            this.lblDental = new System.Windows.Forms.Label();
            this.lblCita = new System.Windows.Forms.Label();
            this.lblExpedientes = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.AnchoBorde = 1;
            this.pnlNavegador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavegador.BackColor = System.Drawing.Color.White;
            this.pnlNavegador.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_1;
            this.pnlNavegador.ColorBorde = System.Drawing.Color.Gray;
            this.pnlNavegador.Controls.Add(this.btnManual);
            this.pnlNavegador.Controls.Add(this.btnCerrar);
            this.pnlNavegador.Controls.Add(this.btnFinalizar);
            this.pnlNavegador.Controls.Add(this.lblVerExpedientes);
            this.pnlNavegador.Controls.Add(this.lblDental);
            this.pnlNavegador.Controls.Add(this.lblCita);
            this.pnlNavegador.Controls.Add(this.lblExpedientes);
            this.pnlNavegador.Controls.Add(this.pictureBox2);
            this.pnlNavegador.Location = new System.Drawing.Point(3, 3);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.RadioEsquinas = 60;
            this.pnlNavegador.Size = new System.Drawing.Size(275, 1820);
            this.pnlNavegador.TabIndex = 2;
            // 
            // btnManual
            // 
            this.btnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnManual.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnManual.BorderRadius = 40;
            this.btnManual.BorderSize = 0;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(91, 870);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(150, 40);
            this.btnManual.TabIndex = 11;
            this.btnManual.Text = "Manual";
            this.btnManual.TextColor = System.Drawing.Color.White;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.BorderRadius = 40;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(91, 946);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinalizar.BorderRadius = 40;
            this.btnFinalizar.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(104, 1733);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 40);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Cerrar";
            this.btnFinalizar.TextColor = System.Drawing.Color.White;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // lblVerExpedientes
            // 
            this.lblVerExpedientes.AutoSize = true;
            this.lblVerExpedientes.BackColor = System.Drawing.Color.Transparent;
            this.lblVerExpedientes.Location = new System.Drawing.Point(56, 371);
            this.lblVerExpedientes.Name = "lblVerExpedientes";
            this.lblVerExpedientes.Size = new System.Drawing.Size(170, 23);
            this.lblVerExpedientes.TabIndex = 4;
            this.lblVerExpedientes.Text = "Ver expedientes";
            this.lblVerExpedientes.Click += new System.EventHandler(this.lblVerExpedientes_Click);
            // 
            // lblDental
            // 
            this.lblDental.AutoSize = true;
            this.lblDental.BackColor = System.Drawing.Color.Transparent;
            this.lblDental.Location = new System.Drawing.Point(56, 315);
            this.lblDental.Name = "lblDental";
            this.lblDental.Size = new System.Drawing.Size(148, 23);
            this.lblDental.TabIndex = 3;
            this.lblDental.Text = "Odontograma";
            this.lblDental.Click += new System.EventHandler(this.lblDental_Click);
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCita.Location = new System.Drawing.Point(56, 267);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(59, 23);
            this.lblCita.TabIndex = 2;
            this.lblCita.Text = "Citas";
            this.lblCita.Click += new System.EventHandler(this.lblCita_Click);
            // 
            // lblExpedientes
            // 
            this.lblExpedientes.AutoSize = true;
            this.lblExpedientes.BackColor = System.Drawing.Color.Transparent;
            this.lblExpedientes.Location = new System.Drawing.Point(56, 206);
            this.lblExpedientes.Name = "lblExpedientes";
            this.lblExpedientes.Size = new System.Drawing.Size(128, 23);
            this.lblExpedientes.TabIndex = 1;
            this.lblExpedientes.Text = "Expedientes";
            this.lblExpedientes.Click += new System.EventHandler(this.lblExpedientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Group;
            this.pictureBox2.Location = new System.Drawing.Point(104, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlNavegador);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(280, 1029);
            this.pnlContenedor.TabIndex = 2;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(280, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(695, 1029);
            this.pnlCentral.TabIndex = 3;
            // 
            // frmDashboardTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(975, 1029);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmDashboardTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardTrabajador_Load);
            this.pnlNavegador.ResumeLayout(false);
            this.pnlNavegador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Modelos.Metodos.PanelRedondeado pnlNavegador;
        private Modelos.Botones.BotonesPSNLSD btnFinalizar;
        private System.Windows.Forms.Label lblVerExpedientes;
        private System.Windows.Forms.Label lblDental;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Label lblExpedientes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlContenedor;
        private Modelos.Botones.BotonesPSNLSD btnCerrar;
        private System.Windows.Forms.Panel pnlCentral;
        private Modelos.Botones.BotonesPSNLSD btnManual;
    }
}