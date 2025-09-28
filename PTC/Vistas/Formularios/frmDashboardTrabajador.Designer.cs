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
            this.pnlCentralAsis = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExpedientesJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnCitasJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnDentalJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnVerExpedientesJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentralAsis
            // 
            this.pnlCentralAsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralAsis.Location = new System.Drawing.Point(318, 0);
            this.pnlCentralAsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCentralAsis.Name = "pnlCentralAsis";
            this.pnlCentralAsis.Size = new System.Drawing.Size(979, 862);
            this.pnlCentralAsis.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnVerExpedientesJSMN);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnDentalJSMN);
            this.panel1.Controls.Add(this.btnCitasJSMN);
            this.panel1.Controls.Add(this.btnExpedientesJSMN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 862);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Image = global::Vistas.Properties.Resources.icons8_cerrar_sesión_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(102, 767);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(196, 52);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 274);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vistas.Properties.Resources.Desktop___29;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.icons8_user_64__2_;
            this.pictureBox1.Location = new System.Drawing.Point(39, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExpedientesJSMN
            // 
            this.btnExpedientesJSMN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExpedientesJSMN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnExpedientesJSMN.BorderColor = System.Drawing.Color.White;
            this.btnExpedientesJSMN.BorderRadius = 40;
            this.btnExpedientesJSMN.BorderSize = 5;
            this.btnExpedientesJSMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpedientesJSMN.FlatAppearance.BorderSize = 0;
            this.btnExpedientesJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedientesJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedientesJSMN.ForeColor = System.Drawing.Color.White;
            this.btnExpedientesJSMN.Location = new System.Drawing.Point(0, 274);
            this.btnExpedientesJSMN.Name = "btnExpedientesJSMN";
            this.btnExpedientesJSMN.Size = new System.Drawing.Size(318, 71);
            this.btnExpedientesJSMN.TabIndex = 0;
            this.btnExpedientesJSMN.Text = "Expedientes";
            this.btnExpedientesJSMN.TextColor = System.Drawing.Color.White;
            this.btnExpedientesJSMN.UseVisualStyleBackColor = false;
            this.btnExpedientesJSMN.Click += new System.EventHandler(this.btnExpedientesJSMN_Click);
            // 
            // btnCitasJSMN
            // 
            this.btnCitasJSMN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCitasJSMN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnCitasJSMN.BorderColor = System.Drawing.Color.White;
            this.btnCitasJSMN.BorderRadius = 40;
            this.btnCitasJSMN.BorderSize = 5;
            this.btnCitasJSMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasJSMN.FlatAppearance.BorderSize = 0;
            this.btnCitasJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasJSMN.ForeColor = System.Drawing.Color.White;
            this.btnCitasJSMN.Location = new System.Drawing.Point(0, 345);
            this.btnCitasJSMN.Name = "btnCitasJSMN";
            this.btnCitasJSMN.Size = new System.Drawing.Size(318, 71);
            this.btnCitasJSMN.TabIndex = 1;
            this.btnCitasJSMN.Text = "Citas";
            this.btnCitasJSMN.TextColor = System.Drawing.Color.White;
            this.btnCitasJSMN.UseVisualStyleBackColor = false;
            this.btnCitasJSMN.Click += new System.EventHandler(this.btnCitasJSMN_Click);
            // 
            // btnDentalJSMN
            // 
            this.btnDentalJSMN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDentalJSMN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnDentalJSMN.BorderColor = System.Drawing.Color.White;
            this.btnDentalJSMN.BorderRadius = 40;
            this.btnDentalJSMN.BorderSize = 5;
            this.btnDentalJSMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDentalJSMN.FlatAppearance.BorderSize = 0;
            this.btnDentalJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDentalJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentalJSMN.ForeColor = System.Drawing.Color.White;
            this.btnDentalJSMN.Location = new System.Drawing.Point(0, 416);
            this.btnDentalJSMN.Name = "btnDentalJSMN";
            this.btnDentalJSMN.Size = new System.Drawing.Size(318, 71);
            this.btnDentalJSMN.TabIndex = 2;
            this.btnDentalJSMN.Text = "Historial Dental";
            this.btnDentalJSMN.TextColor = System.Drawing.Color.White;
            this.btnDentalJSMN.UseVisualStyleBackColor = false;
            this.btnDentalJSMN.Click += new System.EventHandler(this.btnDentalJSMN_Click);
            // 
            // btnVerExpedientesJSMN
            // 
            this.btnVerExpedientesJSMN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerExpedientesJSMN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerExpedientesJSMN.BorderColor = System.Drawing.Color.White;
            this.btnVerExpedientesJSMN.BorderRadius = 40;
            this.btnVerExpedientesJSMN.BorderSize = 5;
            this.btnVerExpedientesJSMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerExpedientesJSMN.FlatAppearance.BorderSize = 0;
            this.btnVerExpedientesJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerExpedientesJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerExpedientesJSMN.ForeColor = System.Drawing.Color.White;
            this.btnVerExpedientesJSMN.Location = new System.Drawing.Point(0, 487);
            this.btnVerExpedientesJSMN.Name = "btnVerExpedientesJSMN";
            this.btnVerExpedientesJSMN.Size = new System.Drawing.Size(318, 71);
            this.btnVerExpedientesJSMN.TabIndex = 3;
            this.btnVerExpedientesJSMN.Text = "Ver Expedientes";
            this.btnVerExpedientesJSMN.TextColor = System.Drawing.Color.White;
            this.btnVerExpedientesJSMN.UseVisualStyleBackColor = false;
            this.btnVerExpedientesJSMN.Click += new System.EventHandler(this.btnVerExpedientesJSMN_Click);
            // 
            // frmDashboardTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1297, 862);
            this.Controls.Add(this.pnlCentralAsis);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDashboardTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardAsistente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCentralAsis;
        private System.Windows.Forms.Button btnCerrar;
        private Modelos.Botones.BotonesPSNLSD btnVerExpedientesJSMN;
        private Modelos.Botones.BotonesPSNLSD btnDentalJSMN;
        private Modelos.Botones.BotonesPSNLSD btnCitasJSMN;
        private Modelos.Botones.BotonesPSNLSD btnExpedientesJSMN;
    }
}