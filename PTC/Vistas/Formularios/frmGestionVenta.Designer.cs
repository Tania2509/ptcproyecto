namespace Vistas.Formularios
{
    partial class frmGestionVenta
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
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvMostrarPro = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProducto.Location = new System.Drawing.Point(490, 28);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(109, 48);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgvMostrarPro
            // 
            this.dgvMostrarPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPro.Location = new System.Drawing.Point(172, 111);
            this.dgvMostrarPro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarPro.Name = "dgvMostrarPro";
            this.dgvMostrarPro.RowHeadersWidth = 51;
            this.dgvMostrarPro.RowTemplate.Height = 24;
            this.dgvMostrarPro.Size = new System.Drawing.Size(458, 280);
            this.dgvMostrarPro.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(212, 28);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(109, 48);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmGestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.Desktop___29;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMostrarPro);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionVenta";
            this.Text = "frmGestionInventario";
            this.Load += new System.EventHandler(this.frmGestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvMostrarPro;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}