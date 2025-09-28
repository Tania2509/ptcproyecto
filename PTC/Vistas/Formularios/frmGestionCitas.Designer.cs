namespace Vistas.Formularios
{
    partial class frmGestionCitas
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cbCorreo = new System.Windows.Forms.ComboBox();
            this.cbApellido = new System.Windows.Forms.ComboBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.btnProgramarCita = new System.Windows.Forms.Button();
            this.lblRazonCita = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRazonCita = new System.Windows.Forms.TextBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminarJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnAgregarCitaJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.btnActualizarJSMN = new Modelos.Botones.BotonesPSNLSD();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarJSMN = new Modelos.Botones.BotonesPSNLSD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCitas)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerCitas
            // 
            this.dgvVerCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCitas.Location = new System.Drawing.Point(454, 220);
            this.dgvVerCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVerCitas.Name = "dgvVerCitas";
            this.dgvVerCitas.RowHeadersWidth = 51;
            this.dgvVerCitas.RowTemplate.Height = 24;
            this.dgvVerCitas.Size = new System.Drawing.Size(457, 244);
            this.dgvVerCitas.TabIndex = 0;
            this.dgvVerCitas.DoubleClick += new System.EventHandler(this.dgvVerCitas_DoubleClick);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.AutoScrollMargin = new System.Drawing.Size(5, 3);
            this.pnlDatos.AutoScrollMinSize = new System.Drawing.Size(300, 600);
            this.pnlDatos.BackColor = System.Drawing.Color.Silver;
            this.pnlDatos.Controls.Add(this.cbCorreo);
            this.pnlDatos.Controls.Add(this.cbApellido);
            this.pnlDatos.Controls.Add(this.cbNombre);
            this.pnlDatos.Controls.Add(this.dtpFechaHora);
            this.pnlDatos.Controls.Add(this.lblFecha);
            this.pnlDatos.Controls.Add(this.lblCorreoElectronico);
            this.pnlDatos.Controls.Add(this.btnProgramarCita);
            this.pnlDatos.Controls.Add(this.lblRazonCita);
            this.pnlDatos.Controls.Add(this.lblApellido);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtRazonCita);
            this.pnlDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDatos.Location = new System.Drawing.Point(13, 40);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(419, 476);
            this.pnlDatos.TabIndex = 4;
            // 
            // cbCorreo
            // 
            this.cbCorreo.FormattingEnabled = true;
            this.cbCorreo.Location = new System.Drawing.Point(7, 334);
            this.cbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCorreo.Name = "cbCorreo";
            this.cbCorreo.Size = new System.Drawing.Size(372, 33);
            this.cbCorreo.TabIndex = 17;
            // 
            // cbApellido
            // 
            this.cbApellido.FormattingEnabled = true;
            this.cbApellido.Location = new System.Drawing.Point(7, 161);
            this.cbApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbApellido.Name = "cbApellido";
            this.cbApellido.Size = new System.Drawing.Size(372, 33);
            this.cbApellido.TabIndex = 16;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(7, 63);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(372, 33);
            this.cbNombre.TabIndex = 15;
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHora.Location = new System.Drawing.Point(9, 441);
            this.dtpFechaHora.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(372, 30);
            this.dtpFechaHora.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(4, 399);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(155, 25);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de la cita:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(3, 309);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(173, 25);
            this.lblCorreoElectronico.TabIndex = 10;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // btnProgramarCita
            // 
            this.btnProgramarCita.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProgramarCita.ForeColor = System.Drawing.Color.White;
            this.btnProgramarCita.Location = new System.Drawing.Point(483, 505);
            this.btnProgramarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnProgramarCita.Name = "btnProgramarCita";
            this.btnProgramarCita.Size = new System.Drawing.Size(200, 65);
            this.btnProgramarCita.TabIndex = 9;
            this.btnProgramarCita.Text = "Programar Cita";
            this.btnProgramarCita.UseVisualStyleBackColor = false;
            // 
            // lblRazonCita
            // 
            this.lblRazonCita.AutoSize = true;
            this.lblRazonCita.Location = new System.Drawing.Point(1, 208);
            this.lblRazonCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonCita.Name = "lblRazonCita";
            this.lblRazonCita.Size = new System.Drawing.Size(152, 25);
            this.lblRazonCita.TabIndex = 8;
            this.lblRazonCita.Text = "Motivo de la cita";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(4, 117);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 25);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtRazonCita
            // 
            this.txtRazonCita.Location = new System.Drawing.Point(7, 236);
            this.txtRazonCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonCita.MaxLength = 100;
            this.txtRazonCita.Multiline = true;
            this.txtRazonCita.Name = "txtRazonCita";
            this.txtRazonCita.ShortcutsEnabled = false;
            this.txtRazonCita.Size = new System.Drawing.Size(372, 30);
            this.txtRazonCita.TabIndex = 3;
            this.txtRazonCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonCita_KeyPress);
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
            this.tlpBotones.Controls.Add(this.btnAgregarCitaJSMN, 0, 0);
            this.tlpBotones.Controls.Add(this.btnActualizarJSMN, 1, 0);
            this.tlpBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tlpBotones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBotones.Location = new System.Drawing.Point(464, 128);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(447, 86);
            this.tlpBotones.TabIndex = 6;
            // 
            // btnEliminarJSMN
            // 
            this.btnEliminarJSMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarJSMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.BorderRadius = 40;
            this.btnEliminarJSMN.BorderSize = 3;
            this.btnEliminarJSMN.FlatAppearance.BorderSize = 0;
            this.btnEliminarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.Location = new System.Drawing.Point(301, 3);
            this.btnEliminarJSMN.Name = "btnEliminarJSMN";
            this.btnEliminarJSMN.Size = new System.Drawing.Size(140, 74);
            this.btnEliminarJSMN.TabIndex = 20;
            this.btnEliminarJSMN.Text = "Eliminar";
            this.btnEliminarJSMN.TextColor = System.Drawing.Color.White;
            this.btnEliminarJSMN.UseVisualStyleBackColor = false;
            this.btnEliminarJSMN.Click += new System.EventHandler(this.btnEliminarJSMN_Click_1);
            // 
            // btnAgregarCitaJSMN
            // 
            this.btnAgregarCitaJSMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarCitaJSMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarCitaJSMN.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCitaJSMN.BorderRadius = 40;
            this.btnAgregarCitaJSMN.BorderSize = 3;
            this.btnAgregarCitaJSMN.FlatAppearance.BorderSize = 0;
            this.btnAgregarCitaJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCitaJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCitaJSMN.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCitaJSMN.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCitaJSMN.Name = "btnAgregarCitaJSMN";
            this.btnAgregarCitaJSMN.Size = new System.Drawing.Size(140, 75);
            this.btnAgregarCitaJSMN.TabIndex = 20;
            this.btnAgregarCitaJSMN.Text = "Agregar Cita";
            this.btnAgregarCitaJSMN.TextColor = System.Drawing.Color.White;
            this.btnAgregarCitaJSMN.UseVisualStyleBackColor = false;
            this.btnAgregarCitaJSMN.Click += new System.EventHandler(this.btnAgregarCitaJSMN_Click);
            // 
            // btnActualizarJSMN
            // 
            this.btnActualizarJSMN.BackColor = System.Drawing.Color.OrangeRed;
            this.btnActualizarJSMN.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnActualizarJSMN.BorderColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.BorderRadius = 40;
            this.btnActualizarJSMN.BorderSize = 3;
            this.btnActualizarJSMN.FlatAppearance.BorderSize = 0;
            this.btnActualizarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarJSMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.Location = new System.Drawing.Point(152, 3);
            this.btnActualizarJSMN.Name = "btnActualizarJSMN";
            this.btnActualizarJSMN.Size = new System.Drawing.Size(140, 77);
            this.btnActualizarJSMN.TabIndex = 20;
            this.btnActualizarJSMN.Text = "Actualizar";
            this.btnActualizarJSMN.TextColor = System.Drawing.Color.White;
            this.btnActualizarJSMN.UseVisualStyleBackColor = false;
            this.btnActualizarJSMN.Click += new System.EventHandler(this.btnActualizarJSMN_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.53333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscarJSMN, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(496, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 100);
            this.tableLayoutPanel1.TabIndex = 19;
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
            // btnBuscarJSMN
            // 
            this.btnBuscarJSMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarJSMN.BackColor = System.Drawing.Color.White;
            this.btnBuscarJSMN.BackgroundColor = System.Drawing.Color.White;
            this.btnBuscarJSMN.BackgroundImage = global::Vistas.Properties.Resources.icons8_buscar_50;
            this.btnBuscarJSMN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarJSMN.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarJSMN.BorderRadius = 30;
            this.btnBuscarJSMN.BorderSize = 3;
            this.btnBuscarJSMN.FlatAppearance.BorderSize = 0;
            this.btnBuscarJSMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarJSMN.ForeColor = System.Drawing.Color.White;
            this.btnBuscarJSMN.Location = new System.Drawing.Point(320, 21);
            this.btnBuscarJSMN.Name = "btnBuscarJSMN";
            this.btnBuscarJSMN.Size = new System.Drawing.Size(52, 57);
            this.btnBuscarJSMN.TabIndex = 20;
            this.btnBuscarJSMN.TextColor = System.Drawing.Color.White;
            this.btnBuscarJSMN.UseVisualStyleBackColor = false;
            this.btnBuscarJSMN.Click += new System.EventHandler(this.btnBuscarJSMN_Click);
            // 
            // frmGestionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(933, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.dgvVerCitas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionCitas";
            this.Text = "frmVerCitas";
            this.Load += new System.EventHandler(this.frmVerCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCitas)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerCitas;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.ComboBox cbCorreo;
        private System.Windows.Forms.ComboBox cbApellido;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Button btnProgramarCita;
        private System.Windows.Forms.Label lblRazonCita;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRazonCita;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private Modelos.Botones.BotonesPSNLSD btnAgregarCitaJSMN;
        private Modelos.Botones.BotonesPSNLSD btnActualizarJSMN;
        private Modelos.Botones.BotonesPSNLSD btnEliminarJSMN;
        private Modelos.Botones.BotonesPSNLSD btnBuscarJSMN;
    }
}