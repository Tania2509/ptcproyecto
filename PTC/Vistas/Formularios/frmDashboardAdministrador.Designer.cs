namespace Vistas.Formularios
{
    partial class frmDashboardAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardAdministrador));
            this.pnlCentralAdmin = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonesPSNLSD1 = new Modelos.Botones.BotonesPSNLSD();
            this.btnInventario_ClickJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.pnlPrincipal.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentralAdmin
            // 
            this.pnlCentralAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCentralAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralAdmin.Location = new System.Drawing.Point(316, 0);
            this.pnlCentralAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCentralAdmin.Name = "pnlCentralAdmin";
            this.pnlCentralAdmin.Size = new System.Drawing.Size(981, 800);
            this.pnlCentralAdmin.TabIndex = 4;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlPrincipal.Controls.Add(this.btnInventario_ClickJSMN);
            this.pnlPrincipal.Controls.Add(this.botonesPSNLSD1);
            this.pnlPrincipal.Controls.Add(this.btnCerrar);
            this.pnlPrincipal.Controls.Add(this.pnlLogo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(316, 800);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Image = global::Vistas.Properties.Resources.icons8_cerrar_sesión_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(104, 718);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(191, 52);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(316, 265);
            this.pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Vistas.Properties.Resources.Desktop___29;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.icons8_user_64__2_;
            this.pictureBox1.Location = new System.Drawing.Point(53, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // botonesPSNLSD1
            // 
            this.botonesPSNLSD1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonesPSNLSD1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.botonesPSNLSD1.BorderColor = System.Drawing.Color.White;
            this.botonesPSNLSD1.BorderRadius = 40;
            this.botonesPSNLSD1.BorderSize = 5;
            this.botonesPSNLSD1.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonesPSNLSD1.FlatAppearance.BorderSize = 0;
            this.botonesPSNLSD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesPSNLSD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesPSNLSD1.ForeColor = System.Drawing.Color.White;
            this.botonesPSNLSD1.Location = new System.Drawing.Point(0, 265);
            this.botonesPSNLSD1.Name = "botonesPSNLSD1";
            this.botonesPSNLSD1.Size = new System.Drawing.Size(316, 85);
            this.botonesPSNLSD1.TabIndex = 0;
            this.botonesPSNLSD1.Text = "Trabajador";
            this.botonesPSNLSD1.TextColor = System.Drawing.Color.White;
            this.botonesPSNLSD1.UseVisualStyleBackColor = false;
            this.botonesPSNLSD1.Click += new System.EventHandler(this.botonesPSNLSD1_Click);
            // 
            // btnInventario_ClickJSMN
            // 
            this.btnInventario_ClickJSMN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInventario_ClickJSMN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnInventario_ClickJSMN.BorderColor = System.Drawing.Color.White;
            this.btnInventario_ClickJSMN.BorderRadius = 40;
            this.btnInventario_ClickJSMN.BorderSize = 5;
            this.btnInventario_ClickJSMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario_ClickJSMN.FlatAppearance.BorderSize = 0;
            this.btnInventario_ClickJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario_ClickJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario_ClickJSMN.ForeColor = System.Drawing.Color.White;
            this.btnInventario_ClickJSMN.Location = new System.Drawing.Point(0, 350);
            this.btnInventario_ClickJSMN.Name = "btnInventario_ClickJSMN";
            this.btnInventario_ClickJSMN.Size = new System.Drawing.Size(316, 85);
            this.btnInventario_ClickJSMN.TabIndex = 6;
            this.btnInventario_ClickJSMN.Text = "Inventario";
            this.btnInventario_ClickJSMN.TextColor = System.Drawing.Color.White;
            this.btnInventario_ClickJSMN.UseVisualStyleBackColor = false;
            this.btnInventario_ClickJSMN.Click += new System.EventHandler(this.btnInventario_ClickJSMN_Click);
            // 
            // frmDashboardAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1297, 800);
            this.Controls.Add(this.pnlCentralAdmin);
            this.Controls.Add(this.pnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboardAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardAdministrador_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlCentralAdmin;
        private System.Windows.Forms.Button btnCerrar;
        private Modelos.Botones.BotonesPSNLSD botonesPSNLSD1;
        private Modelos.Botones.BotonesPSNLSD btnInventario_ClickJSMN;
    }
}