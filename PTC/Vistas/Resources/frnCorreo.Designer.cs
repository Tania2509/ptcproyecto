namespace Vistas.Resources
{
    partial class frnCorreo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRedondeado1 = new Modelos.Metodos.PanelRedondeado();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new Modelos.Botones.BotonesPSNLSD();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.AnchoBorde = 1;
            this.panelRedondeado1.BackColor = System.Drawing.Color.White;
            this.panelRedondeado1.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_49_1_;
            this.panelRedondeado1.ColorBorde = System.Drawing.Color.Gray;
            this.panelRedondeado1.Controls.Add(this.label2);
            this.panelRedondeado1.Controls.Add(this.textBox1);
            this.panelRedondeado1.Controls.Add(this.label1);
            this.panelRedondeado1.Controls.Add(this.btnEnviar);
            this.panelRedondeado1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRedondeado1.Location = new System.Drawing.Point(13, 3);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.RadioEsquinas = 20;
            this.panelRedondeado1.Size = new System.Drawing.Size(491, 466);
            this.panelRedondeado1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa tu correo de trabajo. \r\nSe le enviara un token de verificación";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 40;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Wheat;
            this.btnEnviar.Location = new System.Drawing.Point(132, 361);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(184, 55);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.Wheat;
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // frnCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRedondeado1);
            this.Name = "frnCorreo";
            this.Size = new System.Drawing.Size(507, 470);
            this.panelRedondeado1.ResumeLayout(false);
            this.panelRedondeado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Modelos.Metodos.PanelRedondeado panelRedondeado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Modelos.Botones.BotonesPSNLSD btnEnviar;
    }
}
