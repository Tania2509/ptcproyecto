namespace Vistas.Formularios
{
    partial class frmRegistrar
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
            this.pnlRegistrar = new Modelos.Metodos.PanelRedondeado();
            this.btnCancelar = new Modelos.Botones.BotonesPSNLSD();
            this.btnAgregar = new Modelos.Botones.BotonesPSNLSD();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.AnchoBorde = 1;
            this.pnlRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrar.BackgroundImage = global::Vistas.Properties.Resources.Rectangle_49_1_;
            this.pnlRegistrar.ColorBorde = System.Drawing.Color.Gray;
            this.pnlRegistrar.Controls.Add(this.btnCancelar);
            this.pnlRegistrar.Controls.Add(this.btnAgregar);
            this.pnlRegistrar.Controls.Add(this.cbRol);
            this.pnlRegistrar.Controls.Add(this.lblRol);
            this.pnlRegistrar.Controls.Add(this.lblCorreo);
            this.pnlRegistrar.Controls.Add(this.txtCorreo);
            this.pnlRegistrar.Controls.Add(this.cbEspecialidad);
            this.pnlRegistrar.Controls.Add(this.lblEspecialidad);
            this.pnlRegistrar.Controls.Add(this.dtpFechaNaci);
            this.pnlRegistrar.Controls.Add(this.label1);
            this.pnlRegistrar.Controls.Add(this.lblFecha);
            this.pnlRegistrar.Controls.Add(this.lblOcupacion);
            this.pnlRegistrar.Controls.Add(this.lblEdad);
            this.pnlRegistrar.Controls.Add(this.lblApellido);
            this.pnlRegistrar.Controls.Add(this.lblNombre);
            this.pnlRegistrar.Controls.Add(this.txtDui);
            this.pnlRegistrar.Controls.Add(this.txtTelefono);
            this.pnlRegistrar.Controls.Add(this.txtApellido);
            this.pnlRegistrar.Controls.Add(this.txtNombre);
            this.pnlRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.pnlRegistrar.Location = new System.Drawing.Point(266, 44);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.RadioEsquinas = 40;
            this.pnlRegistrar.Size = new System.Drawing.Size(632, 693);
            this.pnlRegistrar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.BorderColor = System.Drawing.Color.Azure;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(58, 589);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(208, 65);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.btnAgregar.Location = new System.Drawing.Point(361, 589);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 65);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Enabled = false;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(300, 500);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(250, 31);
            this.cbRol.TabIndex = 41;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(54, 503);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(46, 23);
            this.lblRol.TabIndex = 40;
            this.lblRol.Text = "Rol:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(54, 237);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(83, 23);
            this.lblCorreo.TabIndex = 38;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(300, 231);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(250, 32);
            this.txtCorreo.TabIndex = 37;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(302, 434);
            this.cbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(250, 31);
            this.cbEspecialidad.TabIndex = 20;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(56, 437);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(141, 23);
            this.lblEspecialidad.TabIndex = 19;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Location = new System.Drawing.Point(301, 361);
            this.dtpFechaNaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(250, 32);
            this.dtpFechaNaci.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 30;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(55, 366);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(226, 23);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Fecha de nacimiento:";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(54, 307);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(49, 23);
            this.lblOcupacion.TabIndex = 28;
            this.lblOcupacion.Text = "DUI:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(55, 179);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(99, 23);
            this.lblEdad.TabIndex = 27;
            this.lblEdad.Text = "Telefono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 119);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 23);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(56, 71);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(300, 296);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4);
            this.txtDui.MaxLength = 9;
            this.txtDui.Name = "txtDui";
            this.txtDui.ShortcutsEnabled = false;
            this.txtDui.Size = new System.Drawing.Size(250, 32);
            this.txtDui.TabIndex = 24;
            this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(301, 173);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(250, 32);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(302, 116);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(250, 32);
            this.txtApellido.TabIndex = 22;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(301, 62);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(251, 32);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Vistas.Properties.Resources.Desktop___26_1_;
            this.ClientSize = new System.Drawing.Size(1125, 924);
            this.Controls.Add(this.pnlRegistrar);
            this.MinimizeBox = false;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Modelos.Metodos.PanelRedondeado pnlRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblRol;
        private Modelos.Botones.BotonesPSNLSD btnCancelar;
        private Modelos.Botones.BotonesPSNLSD btnAgregar;
    }
}