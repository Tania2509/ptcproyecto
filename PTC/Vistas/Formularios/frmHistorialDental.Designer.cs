namespace Vistas.Formularios
{
    partial class frmHistorialDental
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarJSMN = new Modelos.Botones.BotonesPSNLSD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(38, 127);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(408, 257);
            this.dgvHistorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(35, 59);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(136, 16);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Numero del Paciente:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(177, 56);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(255, 22);
            this.txtPaciente.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(530, 56);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // btnGuardarJSMN
            // 
            this.btnGuardarJSMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardarJSMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnGuardarJSMN.BorderRadius = 21;
            this.btnGuardarJSMN.BorderSize = 5;
            this.btnGuardarJSMN.FlatAppearance.BorderSize = 0;
            this.btnGuardarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnGuardarJSMN.Location = new System.Drawing.Point(594, 335);
            this.btnGuardarJSMN.Name = "btnGuardarJSMN";
            this.btnGuardarJSMN.Size = new System.Drawing.Size(185, 63);
            this.btnGuardarJSMN.TabIndex = 8;
            this.btnGuardarJSMN.Text = "Trabajador";
            this.btnGuardarJSMN.TextColor = System.Drawing.Color.White;
            this.btnGuardarJSMN.UseVisualStyleBackColor = false;
            this.btnGuardarJSMN.Click += new System.EventHandler(this.btnGuardarJSMN_Click);
            // 
            // frmHistorialDental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.Controls.Add(this.btnGuardarJSMN);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "frmHistorialDental";
            this.Text = "frmHistorialDental";
            this.Load += new System.EventHandler(this.frmHistorialDental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Modelos.Botones.BotonesPSNLSD btnGuardarJSMN;
    }
}