namespace Vistas.Formularios
{
    partial class frmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreo));
            this.pnlRecuperacion = new Modelos.Metodos.PanelRedondeado();
            this.btnToken = new Modelos.Botones.BotonesPSNLSD();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnEnviarCorreo = new Modelos.Botones.BotonesPSNLSD();
            this.pnlRecuperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecuperacion
            // 
            this.pnlRecuperacion.AnchoBorde = 1;
            this.pnlRecuperacion.BackColor = System.Drawing.Color.White;
            this.pnlRecuperacion.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_49_1_;
            this.pnlRecuperacion.ColorBorde = System.Drawing.Color.Gray;
            this.pnlRecuperacion.Controls.Add(this.btnToken);
            this.pnlRecuperacion.Controls.Add(this.txtToken);
            this.pnlRecuperacion.Controls.Add(this.lblToken);
            this.pnlRecuperacion.Controls.Add(this.lblEnvio);
            this.pnlRecuperacion.Controls.Add(this.lblAviso);
            this.pnlRecuperacion.Controls.Add(this.txtCorreo);
            this.pnlRecuperacion.Controls.Add(this.lblCorreo);
            this.pnlRecuperacion.Controls.Add(this.btnEnviarCorreo);
            this.pnlRecuperacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRecuperacion.Location = new System.Drawing.Point(12, 8);
            this.pnlRecuperacion.Name = "pnlRecuperacion";
            this.pnlRecuperacion.RadioEsquinas = 20;
            this.pnlRecuperacion.Size = new System.Drawing.Size(491, 461);
            this.pnlRecuperacion.TabIndex = 2;
            // 
            // btnToken
            // 
            this.btnToken.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnToken.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnToken.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnToken.BorderRadius = 40;
            this.btnToken.BorderSize = 0;
            this.btnToken.FlatAppearance.BorderSize = 0;
            this.btnToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToken.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToken.ForeColor = System.Drawing.Color.White;
            this.btnToken.Location = new System.Drawing.Point(142, 379);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(162, 46);
            this.btnToken.TabIndex = 7;
            this.btnToken.Text = "Siguiente";
            this.btnToken.TextColor = System.Drawing.Color.White;
            this.btnToken.UseVisualStyleBackColor = false;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(142, 325);
            this.txtToken.MaxLength = 6;
            this.txtToken.Name = "txtToken";
            this.txtToken.ShortcutsEnabled = false;
            this.txtToken.Size = new System.Drawing.Size(162, 30);
            this.txtToken.TabIndex = 6;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.BackColor = System.Drawing.Color.Transparent;
            this.lblToken.Location = new System.Drawing.Point(24, 272);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(257, 22);
            this.lblToken.TabIndex = 5;
            this.lblToken.Text = "El token solo dura un minuto";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.BackColor = System.Drawing.Color.Transparent;
            this.lblEnvio.Location = new System.Drawing.Point(24, 250);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(460, 22);
            this.lblEnvio.TabIndex = 4;
            this.lblEnvio.Text = "Se le enviara a su correo un token de verificación. ";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(24, 55);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(270, 22);
            this.lblAviso.TabIndex = 3;
            this.lblAviso.Text = "Ingresa tu correo de trabajo. \r\n";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(132, 104);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(190, 30);
            this.txtCorreo.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Location = new System.Drawing.Point(24, 107);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(77, 22);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo:";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviarCorreo.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviarCorreo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviarCorreo.BorderRadius = 40;
            this.btnEnviarCorreo.BorderSize = 0;
            this.btnEnviarCorreo.FlatAppearance.BorderSize = 0;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(142, 167);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(162, 46);
            this.btnEnviarCorreo.TabIndex = 0;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.TextColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(525, 481);
            this.Controls.Add(this.pnlRecuperacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo";
            this.pnlRecuperacion.ResumeLayout(false);
            this.pnlRecuperacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Modelos.Metodos.PanelRedondeado pnlRecuperacion;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private Modelos.Botones.BotonesPSNLSD btnEnviarCorreo;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private Modelos.Botones.BotonesPSNLSD btnToken;
    }
}