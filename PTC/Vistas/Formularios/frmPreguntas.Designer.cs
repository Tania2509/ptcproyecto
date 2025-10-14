namespace Vistas.Formularios
{
    partial class frmPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreguntas));
            this.pnlRegistrar = new Modelos.Metodos.PanelRedondeado();
            this.btnVerificar = new Modelos.Botones.BotonesPSNLSD();
            this.cbPregunta1 = new System.Windows.Forms.ComboBox();
            this.cbPregunta2 = new System.Windows.Forms.ComboBox();
            this.txtPregunta1 = new System.Windows.Forms.TextBox();
            this.cbPregunta3 = new System.Windows.Forms.ComboBox();
            this.txtPregunta2 = new System.Windows.Forms.TextBox();
            this.cbPregunta4 = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new Modelos.Botones.BotonesPSNLSD();
            this.btnAgregar = new Modelos.Botones.BotonesPSNLSD();
            this.txtPregunta4 = new System.Windows.Forms.TextBox();
            this.txtPregunta3 = new System.Windows.Forms.TextBox();
            this.panelRedondeado1 = new Modelos.Metodos.PanelRedondeado();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.pnlRegistrar.SuspendLayout();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.AnchoBorde = 1;
            this.pnlRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrar.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_49_1_;
            this.pnlRegistrar.ColorBorde = System.Drawing.Color.Gray;
            this.pnlRegistrar.Controls.Add(this.btnVerificar);
            this.pnlRegistrar.Controls.Add(this.cbPregunta1);
            this.pnlRegistrar.Controls.Add(this.cbPregunta2);
            this.pnlRegistrar.Controls.Add(this.txtPregunta1);
            this.pnlRegistrar.Controls.Add(this.cbPregunta3);
            this.pnlRegistrar.Controls.Add(this.txtPregunta2);
            this.pnlRegistrar.Controls.Add(this.cbPregunta4);
            this.pnlRegistrar.Controls.Add(this.btnCancelar);
            this.pnlRegistrar.Controls.Add(this.btnAgregar);
            this.pnlRegistrar.Controls.Add(this.txtPregunta4);
            this.pnlRegistrar.Controls.Add(this.txtPregunta3);
            this.pnlRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.pnlRegistrar.Location = new System.Drawing.Point(198, 140);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.RadioEsquinas = 40;
            this.pnlRegistrar.Size = new System.Drawing.Size(632, 746);
            this.pnlRegistrar.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(185)))));
            this.btnVerificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(185)))));
            this.btnVerificar.BorderColor = System.Drawing.Color.Azure;
            this.btnVerificar.BorderRadius = 40;
            this.btnVerificar.BorderSize = 0;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(213, 632);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(208, 65);
            this.btnVerificar.TabIndex = 53;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.TextColor = System.Drawing.Color.White;
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // cbPregunta1
            // 
            this.cbPregunta1.FormattingEnabled = true;
            this.cbPregunta1.Items.AddRange(new object[] {
            "¿Cuál es el nombre de tu primer mascota?",
            "¿En qué ciudad naciste?",
            "¿Cuál es tu comida favorita?",
            "¿Cuál es su deporte favorito?",
            "¿Cuál es su animal favorito?"});
            this.cbPregunta1.Location = new System.Drawing.Point(57, 89);
            this.cbPregunta1.Name = "cbPregunta1";
            this.cbPregunta1.Size = new System.Drawing.Size(511, 31);
            this.cbPregunta1.TabIndex = 52;
            // 
            // cbPregunta2
            // 
            this.cbPregunta2.FormattingEnabled = true;
            this.cbPregunta2.Items.AddRange(new object[] {
            "¿Cuál es el nombre de tu primer mascota?",
            "¿En qué ciudad naciste?",
            "¿Cuál es tu comida favorita?",
            "¿Cuál es su deporte favorito?",
            "¿Cuál es su animal favorito?"});
            this.cbPregunta2.Location = new System.Drawing.Point(57, 224);
            this.cbPregunta2.Name = "cbPregunta2";
            this.cbPregunta2.Size = new System.Drawing.Size(511, 31);
            this.cbPregunta2.TabIndex = 51;
            // 
            // txtPregunta1
            // 
            this.txtPregunta1.Location = new System.Drawing.Point(66, 141);
            this.txtPregunta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta1.MaxLength = 100;
            this.txtPregunta1.Name = "txtPregunta1";
            this.txtPregunta1.ShortcutsEnabled = false;
            this.txtPregunta1.Size = new System.Drawing.Size(491, 32);
            this.txtPregunta1.TabIndex = 50;
            // 
            // cbPregunta3
            // 
            this.cbPregunta3.FormattingEnabled = true;
            this.cbPregunta3.Items.AddRange(new object[] {
            "¿Cuál es el nombre de tu primer mascota?",
            "¿En qué ciudad naciste?",
            "¿Cuál es tu comida favorita?",
            "¿Cuál es su deporte favorito?",
            "¿Cuál es su animal favorito?"});
            this.cbPregunta3.Location = new System.Drawing.Point(57, 360);
            this.cbPregunta3.Name = "cbPregunta3";
            this.cbPregunta3.Size = new System.Drawing.Size(511, 31);
            this.cbPregunta3.TabIndex = 49;
            // 
            // txtPregunta2
            // 
            this.txtPregunta2.Location = new System.Drawing.Point(66, 276);
            this.txtPregunta2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta2.MaxLength = 100;
            this.txtPregunta2.Name = "txtPregunta2";
            this.txtPregunta2.ShortcutsEnabled = false;
            this.txtPregunta2.Size = new System.Drawing.Size(491, 32);
            this.txtPregunta2.TabIndex = 48;
            // 
            // cbPregunta4
            // 
            this.cbPregunta4.FormattingEnabled = true;
            this.cbPregunta4.Items.AddRange(new object[] {
            "¿Cuál es el nombre de tu primer mascota?",
            "¿En qué ciudad naciste?",
            "¿Cuál es tu comida favorita?",
            "¿Cuál es su deporte favorito?",
            "¿Cuál es su animal favorito?"});
            this.cbPregunta4.Location = new System.Drawing.Point(57, 487);
            this.cbPregunta4.Name = "cbPregunta4";
            this.cbPregunta4.Size = new System.Drawing.Size(511, 31);
            this.cbPregunta4.TabIndex = 47;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.BorderColor = System.Drawing.Color.Azure;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(57, 632);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(208, 65);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(185)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(185)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Azure;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(360, 632);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 65);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPregunta4
            // 
            this.txtPregunta4.Location = new System.Drawing.Point(66, 539);
            this.txtPregunta4.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta4.MaxLength = 100;
            this.txtPregunta4.Name = "txtPregunta4";
            this.txtPregunta4.ShortcutsEnabled = false;
            this.txtPregunta4.Size = new System.Drawing.Size(491, 32);
            this.txtPregunta4.TabIndex = 37;
            // 
            // txtPregunta3
            // 
            this.txtPregunta3.Location = new System.Drawing.Point(66, 411);
            this.txtPregunta3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta3.MaxLength = 100;
            this.txtPregunta3.Name = "txtPregunta3";
            this.txtPregunta3.ShortcutsEnabled = false;
            this.txtPregunta3.Size = new System.Drawing.Size(491, 32);
            this.txtPregunta3.TabIndex = 23;
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.AnchoBorde = 1;
            this.panelRedondeado1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelRedondeado1.ColorBorde = System.Drawing.Color.Transparent;
            this.panelRedondeado1.Controls.Add(this.lblDui);
            this.panelRedondeado1.Controls.Add(this.txtDUI);
            this.panelRedondeado1.Controls.Add(this.lblPregunta);
            this.panelRedondeado1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRedondeado1.Location = new System.Drawing.Point(198, 54);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.RadioEsquinas = 20;
            this.panelRedondeado1.Size = new System.Drawing.Size(632, 119);
            this.panelRedondeado1.TabIndex = 53;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(191, 15);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(261, 23);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Preguntas de Verificación";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(195, 77);
            this.txtDUI.MaxLength = 9;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(191, 32);
            this.txtDUI.TabIndex = 55;
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(98, 86);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(49, 23);
            this.lblDui.TabIndex = 56;
            this.lblDui.Text = "DUI:";
            // 
            // frmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Vistas.Properties.Resources.Desktop___26_1_;
            this.ClientSize = new System.Drawing.Size(1020, 921);
            this.Controls.Add(this.panelRedondeado1);
            this.Controls.Add(this.pnlRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPreguntas_Load);
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            this.panelRedondeado1.ResumeLayout(false);
            this.panelRedondeado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Modelos.Metodos.PanelRedondeado pnlRegistrar;
        private Modelos.Botones.BotonesPSNLSD btnCancelar;
        private Modelos.Botones.BotonesPSNLSD btnAgregar;
        private System.Windows.Forms.TextBox txtPregunta4;
        private System.Windows.Forms.TextBox txtPregunta3;
        private System.Windows.Forms.ComboBox cbPregunta1;
        private System.Windows.Forms.ComboBox cbPregunta2;
        private System.Windows.Forms.TextBox txtPregunta1;
        private System.Windows.Forms.ComboBox cbPregunta3;
        private System.Windows.Forms.TextBox txtPregunta2;
        private System.Windows.Forms.ComboBox cbPregunta4;
        private Modelos.Botones.BotonesPSNLSD btnVerificar;
        private Modelos.Metodos.PanelRedondeado panelRedondeado1;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblPregunta;
    }
}