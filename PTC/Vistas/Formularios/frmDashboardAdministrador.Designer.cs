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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlNavegador = new Modelos.Metodos.PanelRedondeado();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pnlCentralAdmin.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentralAdmin
            // 
            this.pnlCentralAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCentralAdmin.Controls.Add(this.pnlFormulario);
            this.pnlCentralAdmin.Controls.Add(this.pnlContenedor);
            this.pnlCentralAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlCentralAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCentralAdmin.Name = "pnlCentralAdmin";
            this.pnlCentralAdmin.Size = new System.Drawing.Size(1124, 688);
            this.pnlCentralAdmin.TabIndex = 5;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(267, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(857, 688);
            this.pnlFormulario.TabIndex = 2;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlNavegador);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(267, 688);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.AnchoBorde = 1;
            this.pnlNavegador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavegador.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavegador.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_1;
            this.pnlNavegador.ColorBorde = System.Drawing.Color.Gray;
            this.pnlNavegador.Controls.Add(this.lblCerrar);
            this.pnlNavegador.Controls.Add(this.lblManual);
            this.pnlNavegador.Controls.Add(this.lblInventario);
            this.pnlNavegador.Controls.Add(this.lblVentas);
            this.pnlNavegador.Controls.Add(this.lblUsuario);
            this.pnlNavegador.Controls.Add(this.pbUsuario);
            this.pnlNavegador.Location = new System.Drawing.Point(3, 0);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.RadioEsquinas = 60;
            this.pnlNavegador.Size = new System.Drawing.Size(260, 688);
            this.pnlNavegador.TabIndex = 0;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCerrar.Location = new System.Drawing.Point(139, 611);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(70, 23);
            this.lblCerrar.TabIndex = 12;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // lblManual
            // 
            this.lblManual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblManual.AutoSize = true;
            this.lblManual.BackColor = System.Drawing.Color.Transparent;
            this.lblManual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblManual.Location = new System.Drawing.Point(126, 558);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(83, 23);
            this.lblManual.TabIndex = 11;
            this.lblManual.Text = "Manual";
            this.lblManual.Click += new System.EventHandler(this.lblManual_Click);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Transparent;
            this.lblInventario.Location = new System.Drawing.Point(77, 275);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(107, 23);
            this.lblInventario.TabIndex = 10;
            this.lblInventario.Text = "Inventario";
            this.lblInventario.Click += new System.EventHandler(this.lblInventario_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblVentas.Location = new System.Drawing.Point(90, 331);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(68, 23);
            this.lblVentas.TabIndex = 7;
            this.lblVentas.Text = "Venta";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(77, 227);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(113, 23);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Trabajador";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuario.Image = global::Vistas.Properties.Resources.Group;
            this.pbUsuario.Location = new System.Drawing.Point(94, 60);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(80, 80);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuario.TabIndex = 5;
            this.pbUsuario.TabStop = false;
            // 
            // frmDashboardAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1124, 688);
            this.Controls.Add(this.pnlCentralAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmDashboardAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardAdministrador_Load);
            this.pnlCentralAdmin.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlNavegador.ResumeLayout(false);
            this.pnlNavegador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentralAdmin;
        private Modelos.Metodos.PanelRedondeado pnlNavegador;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label lblManual;
    }
}