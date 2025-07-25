namespace Vistas.Formularios
{
    partial class frmAgregarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarVenta));
            this.pnlMostrarInv = new System.Windows.Forms.Panel();
            this.btnCrearArt = new System.Windows.Forms.Button();
            this.lblUnidadesActuales = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUnidadesActuales = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.pnlMostrarInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMostrarInv
            // 
            this.pnlMostrarInv.BackColor = System.Drawing.Color.Silver;
            this.pnlMostrarInv.Controls.Add(this.btnCrearArt);
            this.pnlMostrarInv.Controls.Add(this.lblUnidadesActuales);
            this.pnlMostrarInv.Controls.Add(this.lblPrecioProducto);
            this.pnlMostrarInv.Controls.Add(this.lblNombreProducto);
            this.pnlMostrarInv.Controls.Add(this.pictureBox2);
            this.pnlMostrarInv.Controls.Add(this.txtUnidadesActuales);
            this.pnlMostrarInv.Controls.Add(this.txtPrecioProducto);
            this.pnlMostrarInv.Controls.Add(this.txtNombreProducto);
            this.pnlMostrarInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMostrarInv.Location = new System.Drawing.Point(88, 28);
            this.pnlMostrarInv.Name = "pnlMostrarInv";
            this.pnlMostrarInv.Size = new System.Drawing.Size(554, 321);
            this.pnlMostrarInv.TabIndex = 3;
            // 
            // btnCrearArt
            // 
            this.btnCrearArt.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCrearArt.ForeColor = System.Drawing.Color.White;
            this.btnCrearArt.Location = new System.Drawing.Point(399, 236);
            this.btnCrearArt.Name = "btnCrearArt";
            this.btnCrearArt.Size = new System.Drawing.Size(122, 53);
            this.btnCrearArt.TabIndex = 9;
            this.btnCrearArt.Text = "Crear artículo";
            this.btnCrearArt.UseVisualStyleBackColor = false;
            this.btnCrearArt.Click += new System.EventHandler(this.btnCrearArt_Click);
            // 
            // lblUnidadesActuales
            // 
            this.lblUnidadesActuales.AutoSize = true;
            this.lblUnidadesActuales.Location = new System.Drawing.Point(15, 227);
            this.lblUnidadesActuales.Name = "lblUnidadesActuales";
            this.lblUnidadesActuales.Size = new System.Drawing.Size(145, 20);
            this.lblUnidadesActuales.TabIndex = 7;
            this.lblUnidadesActuales.Text = "Unidades actuales:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(15, 157);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(150, 20);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio del Producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(15, 89);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(162, 20);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(241, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtUnidadesActuales
            // 
            this.txtUnidadesActuales.Location = new System.Drawing.Point(20, 249);
            this.txtUnidadesActuales.Name = "txtUnidadesActuales";
            this.txtUnidadesActuales.Size = new System.Drawing.Size(247, 26);
            this.txtUnidadesActuales.TabIndex = 2;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(20, 177);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(246, 26);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(19, 112);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(247, 26);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // frmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.Desktop___29;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMostrarInv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarVenta";
            this.Text = "frmGestiondeInventario";
            this.pnlMostrarInv.ResumeLayout(false);
            this.pnlMostrarInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMostrarInv;
        private System.Windows.Forms.Button btnCrearArt;
        private System.Windows.Forms.Label lblUnidadesActuales;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUnidadesActuales;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
    }
}