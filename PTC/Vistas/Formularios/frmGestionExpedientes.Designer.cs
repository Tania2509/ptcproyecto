namespace Vistas.Formularios
{
    partial class frmGestionExpedientes
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
            this.dgvVerExpedientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.dtpFechaNaciPa = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbEnfermedades = new System.Windows.Forms.ComboBox();
            this.cbAlergias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnActualizarJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnEliminarJSMN = new Modelos.Botones.BotonesPSNLSD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerExpedientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerExpedientes
            // 
            this.dgvVerExpedientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerExpedientes.Location = new System.Drawing.Point(526, 242);
            this.dgvVerExpedientes.Name = "dgvVerExpedientes";
            this.dgvVerExpedientes.RowHeadersWidth = 51;
            this.dgvVerExpedientes.RowTemplate.Height = 24;
            this.dgvVerExpedientes.Size = new System.Drawing.Size(447, 289);
            this.dgvVerExpedientes.TabIndex = 0;
            this.dgvVerExpedientes.DoubleClick += new System.EventHandler(this.dgvVerExpedientes_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 2);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(300, 700);
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDui);
            this.panel1.Controls.Add(this.dtpFechaNaciPa);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.lblFechaNacimiento);
            this.panel1.Controls.Add(this.lblCorreoElectronico);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.cbEnfermedades);
            this.panel1.Controls.Add(this.cbAlergias);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumTelefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 499);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dui:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(36, 427);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4);
            this.txtDui.MaxLength = 10;
            this.txtDui.Name = "txtDui";
            this.txtDui.ShortcutsEnabled = false;
            this.txtDui.Size = new System.Drawing.Size(368, 30);
            this.txtDui.TabIndex = 40;
            this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
            // 
            // dtpFechaNaciPa
            // 
            this.dtpFechaNaciPa.Location = new System.Drawing.Point(37, 330);
            this.dtpFechaNaciPa.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNaciPa.Name = "dtpFechaNaciPa";
            this.dtpFechaNaciPa.Size = new System.Drawing.Size(368, 30);
            this.dtpFechaNaciPa.TabIndex = 39;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(36, 236);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.ShortcutsEnabled = false;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(369, 30);
            this.txtCorreoElectronico.TabIndex = 38;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(32, 301);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(196, 25);
            this.lblFechaNacimiento.TabIndex = 37;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(31, 207);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(173, 25);
            this.lblCorreoElectronico.TabIndex = 36;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(31, 114);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 25);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 17);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(38, 142);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(366, 30);
            this.txtApellido.TabIndex = 33;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(38, 45);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(366, 30);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cbEnfermedades
            // 
            this.cbEnfermedades.FormattingEnabled = true;
            this.cbEnfermedades.Location = new System.Drawing.Point(41, 822);
            this.cbEnfermedades.Name = "cbEnfermedades";
            this.cbEnfermedades.Size = new System.Drawing.Size(365, 33);
            this.cbEnfermedades.TabIndex = 31;
            // 
            // cbAlergias
            // 
            this.cbAlergias.FormattingEnabled = true;
            this.cbAlergias.Location = new System.Drawing.Point(40, 709);
            this.cbAlergias.Name = "cbAlergias";
            this.cbAlergias.Size = new System.Drawing.Size(366, 33);
            this.cbAlergias.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 784);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enfermedades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 671);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Alergias";
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(39, 611);
            this.txtNumTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTelefono.MaxLength = 8;
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.ShortcutsEnabled = false;
            this.txtNumTelefono.Size = new System.Drawing.Size(365, 30);
            this.txtNumTelefono.TabIndex = 27;
            this.txtNumTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número de Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(39, 507);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 90;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(368, 30);
            this.txtDireccion.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(475, 933);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 65);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.53333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(556, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 100);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnEliminarJSMN, 2, 0);
            this.tlpBotones.Controls.Add(this.btnActualizarJSMN, 1, 0);
            this.tlpBotones.Controls.Add(this.btnAgregarJSMN, 0, 0);
            this.tlpBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tlpBotones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBotones.Location = new System.Drawing.Point(526, 150);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(447, 86);
            this.tlpBotones.TabIndex = 19;
            // 
            // btnAgregarJSMN
            // 
            this.btnAgregarJSMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarJSMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarJSMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnAgregarJSMN.BorderRadius = 40;
            this.btnAgregarJSMN.BorderSize = 3;
            this.btnAgregarJSMN.FlatAppearance.BorderSize = 0;
            this.btnAgregarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnAgregarJSMN.Location = new System.Drawing.Point(3, 5);
            this.btnAgregarJSMN.Name = "btnAgregarJSMN";
            this.btnAgregarJSMN.Size = new System.Drawing.Size(143, 75);
            this.btnAgregarJSMN.TabIndex = 21;
            this.btnAgregarJSMN.Text = "Agregar ";
            this.btnAgregarJSMN.TextColor = System.Drawing.Color.White;
            this.btnAgregarJSMN.UseVisualStyleBackColor = false;
            this.btnAgregarJSMN.Click += new System.EventHandler(this.btnAgregarJSMN_Click_1);
            // 
            // btnActualizarJSMN
            // 
            this.btnActualizarJSMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarJSMN.BackColor = System.Drawing.Color.OrangeRed;
            this.btnActualizarJSMN.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnActualizarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.BorderRadius = 40;
            this.btnActualizarJSMN.BorderSize = 3;
            this.btnActualizarJSMN.FlatAppearance.BorderSize = 0;
            this.btnActualizarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.Location = new System.Drawing.Point(152, 4);
            this.btnActualizarJSMN.Name = "btnActualizarJSMN";
            this.btnActualizarJSMN.Size = new System.Drawing.Size(143, 77);
            this.btnActualizarJSMN.TabIndex = 21;
            this.btnActualizarJSMN.Text = "Actualizar";
            this.btnActualizarJSMN.TextColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.UseVisualStyleBackColor = false;
            this.btnActualizarJSMN.Click += new System.EventHandler(this.btnActualizarJSMN_Click);
            // 
            // btnEliminarJSMN
            // 
            this.btnEliminarJSMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarJSMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarJSMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.BorderRadius = 40;
            this.btnEliminarJSMN.BorderSize = 3;
            this.btnEliminarJSMN.FlatAppearance.BorderSize = 0;
            this.btnEliminarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.Location = new System.Drawing.Point(301, 4);
            this.btnEliminarJSMN.Name = "btnEliminarJSMN";
            this.btnEliminarJSMN.Size = new System.Drawing.Size(143, 77);
            this.btnEliminarJSMN.TabIndex = 21;
            this.btnEliminarJSMN.Text = "Eliminar";
            this.btnEliminarJSMN.TextColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.UseVisualStyleBackColor = false;
            this.btnEliminarJSMN.Click += new System.EventHandler(this.btnEliminarJSMN_Click);
            // 
            // frmGestionExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1031, 570);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVerExpedientes);
            this.Name = "frmGestionExpedientes";
            this.Text = "frmVerExpedientes";
            this.Load += new System.EventHandler(this.frmVerExpedientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerExpedientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerExpedientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.DateTimePicker dtpFechaNaciPa;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEnfermedades;
        private System.Windows.Forms.ComboBox cbAlergias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private Modelos.Botones.BotonesPSNLSD btnAgregarJSMN;
        private Modelos.Botones.BotonesPSNLSD btnActualizarJSMN;
        private Modelos.Botones.BotonesPSNLSD btnEliminarJSMN;
    }
}