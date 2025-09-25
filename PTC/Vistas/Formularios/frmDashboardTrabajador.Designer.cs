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
            this.btnVerExpedientes = new System.Windows.Forms.Button();
            this.btnDental = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnExpedientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.btnVerExpedientes);
            this.panel1.Controls.Add(this.btnDental);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnCitas);
            this.panel1.Controls.Add(this.btnExpedientes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 862);
            this.panel1.TabIndex = 1;
            // 
            // btnVerExpedientes
            // 
            this.btnVerExpedientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerExpedientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerExpedientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerExpedientes.ForeColor = System.Drawing.Color.White;
            this.btnVerExpedientes.Location = new System.Drawing.Point(0, 463);
            this.btnVerExpedientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerExpedientes.Name = "btnVerExpedientes";
            this.btnVerExpedientes.Size = new System.Drawing.Size(318, 63);
            this.btnVerExpedientes.TabIndex = 8;
            this.btnVerExpedientes.Text = "Ver Expedientes";
            this.btnVerExpedientes.UseVisualStyleBackColor = false;
            this.btnVerExpedientes.Click += new System.EventHandler(this.btnVerExpedientes_Click);
            // 
            // btnDental
            // 
            this.btnDental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDental.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDental.ForeColor = System.Drawing.Color.White;
            this.btnDental.Location = new System.Drawing.Point(0, 400);
            this.btnDental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDental.Name = "btnDental";
            this.btnDental.Size = new System.Drawing.Size(318, 63);
            this.btnDental.TabIndex = 7;
            this.btnDental.Text = "Historial Dental";
            this.btnDental.UseVisualStyleBackColor = false;
            this.btnDental.Click += new System.EventHandler(this.btnDental_Click);
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
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Location = new System.Drawing.Point(0, 337);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(318, 63);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnExpedientes
            // 
            this.btnExpedientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExpedientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpedientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedientes.ForeColor = System.Drawing.Color.White;
            this.btnExpedientes.Location = new System.Drawing.Point(0, 274);
            this.btnExpedientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpedientes.Name = "btnExpedientes";
            this.btnExpedientes.Size = new System.Drawing.Size(318, 63);
            this.btnExpedientes.TabIndex = 4;
            this.btnExpedientes.Text = "Expedientes";
            this.btnExpedientes.UseVisualStyleBackColor = false;
            this.btnExpedientes.Click += new System.EventHandler(this.btnExpedientes_Click);
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
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExpedientes;
        private System.Windows.Forms.Panel pnlCentralAsis;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDental;
        private System.Windows.Forms.Button btnVerExpedientes;
    }
}