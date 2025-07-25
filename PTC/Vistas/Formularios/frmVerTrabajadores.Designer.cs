namespace Vistas.Formularios
{
    partial class frmVerTrabajadores
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
            this.btnAgregarTrabajador = new System.Windows.Forms.Button();
            this.btnEliminarTrabajador = new System.Windows.Forms.Button();
            this.dgvVerTrabajador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTrabajador
            // 
            this.btnAgregarTrabajador.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAgregarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTrabajador.Location = new System.Drawing.Point(346, 67);
            this.btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            this.btnAgregarTrabajador.Size = new System.Drawing.Size(172, 76);
            this.btnAgregarTrabajador.TabIndex = 4;
            this.btnAgregarTrabajador.Text = "Agregar";
            this.btnAgregarTrabajador.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajador.Click += new System.EventHandler(this.btnAgregarTrabajador_Click);
            // 
            // btnEliminarTrabajador
            // 
            this.btnEliminarTrabajador.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTrabajador.Location = new System.Drawing.Point(637, 67);
            this.btnEliminarTrabajador.Name = "btnEliminarTrabajador";
            this.btnEliminarTrabajador.Size = new System.Drawing.Size(172, 76);
            this.btnEliminarTrabajador.TabIndex = 5;
            this.btnEliminarTrabajador.Text = "Eliminar";
            this.btnEliminarTrabajador.UseVisualStyleBackColor = false;
            this.btnEliminarTrabajador.Click += new System.EventHandler(this.btnEliminarTrabajador_Click);
            // 
            // dgvVerTrabajador
            // 
            this.dgvVerTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerTrabajador.Location = new System.Drawing.Point(123, 203);
            this.dgvVerTrabajador.Name = "dgvVerTrabajador";
            this.dgvVerTrabajador.RowHeadersWidth = 51;
            this.dgvVerTrabajador.RowTemplate.Height = 24;
            this.dgvVerTrabajador.Size = new System.Drawing.Size(878, 369);
            this.dgvVerTrabajador.TabIndex = 6;
            // 
            // frmVerTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 637);
            this.Controls.Add(this.dgvVerTrabajador);
            this.Controls.Add(this.btnAgregarTrabajador);
            this.Controls.Add(this.btnEliminarTrabajador);
            this.Name = "frmVerTrabajadores";
            this.Text = "frmVerTrabajadores";
            this.Load += new System.EventHandler(this.frmVerTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTrabajador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTrabajador;
        private System.Windows.Forms.Button btnEliminarTrabajador;
        private System.Windows.Forms.DataGridView dgvVerTrabajador;
    }
}