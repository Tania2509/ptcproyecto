namespace Vistas.Formularios
{
    partial class frmGestionTrabajadores
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTrabajador)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAgregarTrabajador.TabIndex = 4;
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
            this.btnEliminarTrabajador.TabIndex = 5;
            this.btnEliminarTrabajador.Text = "Eliminar";
            this.btnEliminarTrabajador.UseVisualStyleBackColor = false;
            this.btnEliminarTrabajador.Click += new System.EventHandler(this.btnEliminarTrabajador_Click);
            // 
            // dgvVerTrabajador
            // 
            this.dgvVerTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerTrabajador.Location = new System.Drawing.Point(599, 243);
            this.dgvVerTrabajador.Name = "dgvVerTrabajador";
            this.dgvVerTrabajador.RowHeadersWidth = 51;
            this.dgvVerTrabajador.RowTemplate.Height = 24;
            this.dgvVerTrabajador.Size = new System.Drawing.Size(452, 324);
            this.dgvVerTrabajador.TabIndex = 6;
            this.dgvVerTrabajador.DoubleClick += new System.EventHandler(this.dgvVerTrabajador_DoubleClick);
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
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUsuarios.AutoScroll = true;
            this.pnlUsuarios.AutoScrollMargin = new System.Drawing.Size(5, 4);
            this.pnlUsuarios.AutoScrollMinSize = new System.Drawing.Size(300, 120);
            this.pnlUsuarios.BackColor = System.Drawing.Color.Silver;
            this.pnlUsuarios.Controls.Add(this.label4);
            this.pnlUsuarios.Controls.Add(this.txtContraseña);
            this.pnlUsuarios.Controls.Add(this.cbEspecialidad);
            this.pnlUsuarios.Controls.Add(this.cbRol);
            this.pnlUsuarios.Controls.Add(this.dtpFechaNaci);
            this.pnlUsuarios.Controls.Add(this.label3);
            this.pnlUsuarios.Controls.Add(this.label1);
            this.pnlUsuarios.Controls.Add(this.label2);
            this.pnlUsuarios.Controls.Add(this.lblOcupacion);
            this.pnlUsuarios.Controls.Add(this.lblEdad);
            this.pnlUsuarios.Controls.Add(this.lblApellido);
            this.pnlUsuarios.Controls.Add(this.lblNombre);
            this.pnlUsuarios.Controls.Add(this.txtDui);
            this.pnlUsuarios.Controls.Add(this.txtTelefono);
            this.pnlUsuarios.Controls.Add(this.txtApellido);
            this.pnlUsuarios.Controls.Add(this.txtNombre);
            this.pnlUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUsuarios.Location = new System.Drawing.Point(13, 29);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(547, 569);
            this.pnlUsuarios.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(248, 350);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(250, 30);
            this.txtContraseña.TabIndex = 19;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(247, 487);
            this.cbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(250, 33);
            this.cbEspecialidad.TabIndex = 18;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Asistente",
            "Doctor"});
            this.cbRol.Location = new System.Drawing.Point(247, 414);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(250, 33);
            this.cbRol.TabIndex = 17;
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Location = new System.Drawing.Point(248, 286);
            this.dtpFechaNaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(250, 30);
            this.dtpFechaNaci.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(30, 229);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(51, 25);
            this.lblOcupacion.TabIndex = 8;
            this.lblOcupacion.Text = "DUI:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(30, 156);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(95, 25);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Telefono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 90);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 25);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(248, 224);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4);
            this.txtDui.MaxLength = 20;
            this.txtDui.Name = "txtDui";
            this.txtDui.ShortcutsEnabled = false;
            this.txtDui.Size = new System.Drawing.Size(250, 30);
            this.txtDui.TabIndex = 3;
            this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(248, 156);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 25;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(250, 30);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(248, 87);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(250, 30);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(247, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(251, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.53333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.46667F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(638, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 100);
            this.tableLayoutPanel1.TabIndex = 21;
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
            this.tlpBotones.Controls.Add(this.btnActualizar, 1, 0);
            this.tlpBotones.Controls.Add(this.btnEliminarTrabajador, 2, 0);
            this.tlpBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tlpBotones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBotones.Location = new System.Drawing.Point(604, 151);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(447, 86);
            this.tlpBotones.TabIndex = 22;
            // 
            // frmGestionTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1077, 637);
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.dgvVerTrabajador);
            this.Name = "frmGestionTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerTrabajadores";
            this.Load += new System.EventHandler(this.frmVerTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTrabajador)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTrabajador;
        private System.Windows.Forms.Button btnEliminarTrabajador;
        private System.Windows.Forms.DataGridView dgvVerTrabajador;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
    }
}