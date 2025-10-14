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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionVenta));
            this.dgvMostrarPro = new System.Windows.Forms.DataGridView();
            this.pnlMostrarInv = new System.Windows.Forms.Panel();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblUnidadesVendidas = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtUnidadesActuales = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.tlpBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new Modelos.Botones.BotonesPSNLSD();
            this.btnActualizar = new Modelos.Botones.BotonesPSNLSD();
            this.btnEliminar = new Modelos.Botones.BotonesPSNLSD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).BeginInit();
            this.pnlMostrarInv.SuspendLayout();
            this.tlpBuscar.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarPro
            // 
            this.dgvMostrarPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPro.Location = new System.Drawing.Point(599, 372);
            this.dgvMostrarPro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMostrarPro.Name = "dgvMostrarPro";
            this.dgvMostrarPro.RowHeadersWidth = 51;
            this.dgvMostrarPro.RowTemplate.Height = 24;
            this.dgvMostrarPro.Size = new System.Drawing.Size(704, 309);
            this.dgvMostrarPro.TabIndex = 0;
            this.dgvMostrarPro.DoubleClick += new System.EventHandler(this.dgvMostrarPro_DoubleClick);
            // 
            // pnlMostrarInv
            // 
            this.pnlMostrarInv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlMostrarInv.BackColor = System.Drawing.Color.Silver;
            this.pnlMostrarInv.Controls.Add(this.cbProducto);
            this.pnlMostrarInv.Controls.Add(this.lblUnidadesVendidas);
            this.pnlMostrarInv.Controls.Add(this.lblPrecioProducto);
            this.pnlMostrarInv.Controls.Add(this.lblNombreProducto);
            this.pnlMostrarInv.Controls.Add(this.txtUnidadesActuales);
            this.pnlMostrarInv.Controls.Add(this.txtPrecioProducto);
            this.pnlMostrarInv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMostrarInv.Location = new System.Drawing.Point(102, 270);
            this.pnlMostrarInv.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMostrarInv.Name = "pnlMostrarInv";
            this.pnlMostrarInv.Size = new System.Drawing.Size(458, 411);
            this.pnlMostrarInv.TabIndex = 16;
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(43, 102);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(285, 31);
            this.cbProducto.TabIndex = 8;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // lblUnidadesVendidas
            // 
            this.lblUnidadesVendidas.AutoSize = true;
            this.lblUnidadesVendidas.Location = new System.Drawing.Point(38, 274);
            this.lblUnidadesVendidas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUnidadesVendidas.Name = "lblUnidadesVendidas";
            this.lblUnidadesVendidas.Size = new System.Drawing.Size(202, 23);
            this.lblUnidadesVendidas.TabIndex = 7;
            this.lblUnidadesVendidas.Text = "Unidades vendidas:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(38, 168);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(207, 23);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio del Producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(38, 48);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(225, 23);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // txtUnidadesActuales
            // 
            this.txtUnidadesActuales.Location = new System.Drawing.Point(43, 315);
            this.txtUnidadesActuales.Margin = new System.Windows.Forms.Padding(6);
            this.txtUnidadesActuales.Name = "txtUnidadesActuales";
            this.txtUnidadesActuales.ShortcutsEnabled = false;
            this.txtUnidadesActuales.Size = new System.Drawing.Size(285, 32);
            this.txtUnidadesActuales.TabIndex = 2;
            this.txtUnidadesActuales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesActuales_KeyPress);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(43, 199);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrecioProducto.MaxLength = 6;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.ShortcutsEnabled = false;
            this.txtPrecioProducto.Size = new System.Drawing.Size(285, 32);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // tlpBuscar
            // 
            this.tlpBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tlpBuscar.ColumnCount = 2;
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.53333F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.tlpBuscar.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpBuscar.Controls.Add(this.txtBuscar, 0, 1);
            this.tlpBuscar.Controls.Add(this.btnBuscar, 1, 1);
            this.tlpBuscar.Location = new System.Drawing.Point(508, 28);
            this.tlpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBuscar.Name = "tlpBuscar";
            this.tlpBuscar.RowCount = 2;
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpBuscar.Size = new System.Drawing.Size(562, 144);
            this.tlpBuscar.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Location = new System.Drawing.Point(105, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 34);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Gestion de Ventas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(5, 86);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(464, 30);
            this.txtBuscar.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Image = global::Vistas.Properties.Resources.icons8_buscar_50;
            this.btnBuscar.Location = new System.Drawing.Point(479, 67);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 68);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnAgregar, 0, 0);
            this.tlpBotones.Controls.Add(this.btnActualizar, 1, 0);
            this.tlpBotones.Controls.Add(this.btnEliminar, 2, 0);
            this.tlpBotones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tlpBotones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBotones.Location = new System.Drawing.Point(629, 270);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.Size = new System.Drawing.Size(642, 91);
            this.tlpBotones.TabIndex = 20;
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
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 65);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(169)))), ((int)(((byte)(27)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(169)))), ((int)(((byte)(27)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(217, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(208, 65);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(431, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 65);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmGestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Vistas.Properties.Resources.Desktop___1_1_;
            this.ClientSize = new System.Drawing.Size(1600, 796);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.tlpBuscar);
            this.Controls.Add(this.pnlMostrarInv);
            this.Controls.Add(this.dgvMostrarPro);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGestionVenta";
            this.Text = "Gestion Ventas";
            this.Load += new System.EventHandler(this.frmGestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPro)).EndInit();
            this.pnlMostrarInv.ResumeLayout(false);
            this.pnlMostrarInv.PerformLayout();
            this.tlpBuscar.ResumeLayout(false);
            this.tlpBuscar.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMostrarPro;
        private System.Windows.Forms.Panel pnlMostrarInv;
        private System.Windows.Forms.Label lblUnidadesVendidas;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtUnidadesActuales;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TableLayoutPanel tlpBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private Modelos.Botones.BotonesPSNLSD btnAgregar;
        private Modelos.Botones.BotonesPSNLSD btnActualizar;
        private Modelos.Botones.BotonesPSNLSD btnEliminar;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblTitulo;
    }
}