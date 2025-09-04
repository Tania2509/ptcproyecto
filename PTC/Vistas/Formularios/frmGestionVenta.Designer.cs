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
            this.dgvMostrarPro = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarTrabajador = new System.Windows.Forms.Button();
            this.btnEliminarTrabajador = new System.Windows.Forms.Button();
            this.pnlMostrarInv = new System.Windows.Forms.Panel();
            this.lblUnidadesVendidas = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtUnidadesActuales = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).BeginInit();
            this.pnlMostrarInv.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarPro
            // 
            this.dgvMostrarPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPro.Location = new System.Drawing.Point(509, 256);
            this.dgvMostrarPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMostrarPro.Name = "dgvMostrarPro";
            this.dgvMostrarPro.RowHeadersWidth = 51;
            this.dgvMostrarPro.RowTemplate.Height = 24;
            this.dgvMostrarPro.Size = new System.Drawing.Size(501, 275);
            this.dgvMostrarPro.TabIndex = 0;
            this.dgvMostrarPro.DoubleClick += new System.EventHandler(this.dgvMostrarPro_DoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(153, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 76);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregarTrabajador
            // 
            this.btnAgregarTrabajador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarTrabajador.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAgregarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTrabajador.Location = new System.Drawing.Point(4, 6);
            this.btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            this.btnAgregarTrabajador.Size = new System.Drawing.Size(140, 74);
            this.btnAgregarTrabajador.TabIndex = 11;
            this.btnAgregarTrabajador.Text = "Agregar";
            this.btnAgregarTrabajador.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajador.Click += new System.EventHandler(this.btnAgregarTrabajador_Click);
            // 
            // btnEliminarTrabajador
            // 
            this.btnEliminarTrabajador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarTrabajador.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTrabajador.Location = new System.Drawing.Point(302, 5);
            this.btnEliminarTrabajador.Name = "btnEliminarTrabajador";
            this.btnEliminarTrabajador.Size = new System.Drawing.Size(140, 76);
            this.btnEliminarTrabajador.TabIndex = 12;
            this.btnEliminarTrabajador.Text = "Eliminar";
            this.btnEliminarTrabajador.UseVisualStyleBackColor = false;
            this.btnEliminarTrabajador.Click += new System.EventHandler(this.btnEliminarTrabajador_Click);
            // 
            // pnlMostrarInv
            // 
            this.pnlMostrarInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMostrarInv.BackColor = System.Drawing.Color.Silver;
            this.pnlMostrarInv.Controls.Add(this.lblUnidadesVendidas);
            this.pnlMostrarInv.Controls.Add(this.lblPrecioProducto);
            this.pnlMostrarInv.Controls.Add(this.lblNombreProducto);
            this.pnlMostrarInv.Controls.Add(this.txtUnidadesActuales);
            this.pnlMostrarInv.Controls.Add(this.txtPrecioProducto);
            this.pnlMostrarInv.Controls.Add(this.txtNombreProducto);
            this.pnlMostrarInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMostrarInv.Location = new System.Drawing.Point(22, 86);
            this.pnlMostrarInv.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMostrarInv.Name = "pnlMostrarInv";
            this.pnlMostrarInv.Size = new System.Drawing.Size(400, 342);
            this.pnlMostrarInv.TabIndex = 16;
            // 
            // lblUnidadesVendidas
            // 
            this.lblUnidadesVendidas.AutoSize = true;
            this.lblUnidadesVendidas.Location = new System.Drawing.Point(25, 220);
            this.lblUnidadesVendidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadesVendidas.Name = "lblUnidadesVendidas";
            this.lblUnidadesVendidas.Size = new System.Drawing.Size(185, 25);
            this.lblUnidadesVendidas.TabIndex = 7;
            this.lblUnidadesVendidas.Text = "Unidades vendidas:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(25, 134);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(187, 25);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio del Producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(25, 51);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(201, 25);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // txtUnidadesActuales
            // 
            this.txtUnidadesActuales.Location = new System.Drawing.Point(32, 247);
            this.txtUnidadesActuales.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadesActuales.Name = "txtUnidadesActuales";
            this.txtUnidadesActuales.ShortcutsEnabled = false;
            this.txtUnidadesActuales.Size = new System.Drawing.Size(328, 30);
            this.txtUnidadesActuales.TabIndex = 2;
            this.txtUnidadesActuales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesActuales_KeyPress);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(32, 159);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ShortcutsEnabled = false;
            this.txtPrecioProducto.Size = new System.Drawing.Size(327, 30);
            this.txtPrecioProducto.TabIndex = 1;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(30, 79);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ShortcutsEnabled = false;
            this.txtNombreProducto.Size = new System.Drawing.Size(328, 30);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.53333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(590, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Image = global::Vistas.Properties.Resources.icons8_buscar_50;
            this.btnBuscar.Location = new System.Drawing.Point(320, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 47);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(3, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(311, 30);
            this.txtBuscar.TabIndex = 16;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnAgregarTrabajador, 0, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarTrabajador, 2, 0);
            this.tlpBotones.Controls.Add(this.btnActualizar, 1, 0);
            this.tlpBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tlpBotones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBotones.Location = new System.Drawing.Point(539, 165);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(447, 86);
            this.tlpBotones.TabIndex = 20;
            // 
            // frmGestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlMostrarInv);
            this.Controls.Add(this.dgvMostrarPro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionVenta";
            this.Text = "frmGestionInventario";
            this.Load += new System.EventHandler(this.frmGestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).EndInit();
            this.pnlMostrarInv.ResumeLayout(false);
            this.pnlMostrarInv.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMostrarPro;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregarTrabajador;
        private System.Windows.Forms.Button btnEliminarTrabajador;
        private System.Windows.Forms.Panel pnlMostrarInv;
        private System.Windows.Forms.Label lblUnidadesVendidas;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtUnidadesActuales;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
    }
}