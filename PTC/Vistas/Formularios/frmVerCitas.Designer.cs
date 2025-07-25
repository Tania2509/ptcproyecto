namespace Vistas.Formularios
{
    partial class frmVerCitas
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
            this.dgvVerCitas = new System.Windows.Forms.DataGridView();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerCitas
            // 
            this.dgvVerCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCitas.Location = new System.Drawing.Point(67, 106);
            this.dgvVerCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVerCitas.Name = "dgvVerCitas";
            this.dgvVerCitas.RowHeadersWidth = 51;
            this.dgvVerCitas.RowTemplate.Height = 24;
            this.dgvVerCitas.Size = new System.Drawing.Size(562, 303);
            this.dgvVerCitas.TabIndex = 0;
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.Location = new System.Drawing.Point(149, 32);
            this.btnAgregarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(144, 41);
            this.btnAgregarCita.TabIndex = 1;
            this.btnAgregarCita.Text = "Agregar Cita";
            this.btnAgregarCita.UseVisualStyleBackColor = true;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(393, 32);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 41);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmVerCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarCita);
            this.Controls.Add(this.dgvVerCitas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVerCitas";
            this.Text = "frmVerCitas";
            this.Load += new System.EventHandler(this.frmVerCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerCitas;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.Button btnEliminar;
    }
}