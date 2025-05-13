namespace CapaPresentacion
{
    partial class FrmConductores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gboxConductores = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaContratacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.dgvConductores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.gboxConductores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxConductores
            // 
            this.gboxConductores.Controls.Add(this.cmbEstado);
            this.gboxConductores.Controls.Add(this.label7);
            this.gboxConductores.Controls.Add(this.txtDireccion);
            this.gboxConductores.Controls.Add(this.label6);
            this.gboxConductores.Controls.Add(this.txtFechaContratacion);
            this.gboxConductores.Controls.Add(this.label5);
            this.gboxConductores.Controls.Add(this.txtTelefono);
            this.gboxConductores.Controls.Add(this.label4);
            this.gboxConductores.Controls.Add(this.txtLicencia);
            this.gboxConductores.Controls.Add(this.label3);
            this.gboxConductores.Controls.Add(this.txtNombre);
            this.gboxConductores.Controls.Add(this.label2);
            this.gboxConductores.Controls.Add(this.txtCodigo);
            this.gboxConductores.Controls.Add(this.label1);
            this.gboxConductores.Controls.Add(this.btnGuardar);
            this.gboxConductores.Controls.Add(this.btnActualizar);
            this.gboxConductores.Controls.Add(this.btnCancelar);
            this.gboxConductores.Location = new System.Drawing.Point(12, 12);
            this.gboxConductores.Name = "gboxConductores";
            this.gboxConductores.Size = new System.Drawing.Size(1052, 264);
            this.gboxConductores.TabIndex = 0;
            this.gboxConductores.TabStop = false;
            this.gboxConductores.Text = "DATOS CONDUCTORES";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(204, 222);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(204, 186);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(400, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dirección:";
            // 
            // txtFechaContratacion
            // 
            this.txtFechaContratacion.Location = new System.Drawing.Point(204, 150);
            this.txtFechaContratacion.Name = "txtFechaContratacion";
            this.txtFechaContratacion.Size = new System.Drawing.Size(200, 22);
            this.txtFechaContratacion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Contratación:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(204, 114);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono:";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(204, 78);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(200, 22);
            this.txtLicencia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Licencia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(854, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código Conductor:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnGuardar.IconColor = System.Drawing.Color.Green;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(854, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 30;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(854, 130);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 35);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.btnCancelar.IconColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(854, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvConductores
            // 
            this.dgvConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConductores.BackgroundColor = System.Drawing.Color.White;
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductores.GridColor = System.Drawing.Color.White;
            this.dgvConductores.Location = new System.Drawing.Point(12, 294);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.ReadOnly = true;
            this.dgvConductores.RowHeadersWidth = 51;
            this.dgvConductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConductores.Size = new System.Drawing.Size(1052, 270);
            this.dgvConductores.TabIndex = 1;
            this.dgvConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(966, 592);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 35);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmConductores
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 666);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvConductores);
            this.Controls.Add(this.gboxConductores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConductores";
            this.Text = "FrmConductores";
            this.Load += new System.EventHandler(this.FrmConductores_Load);
            this.gboxConductores.ResumeLayout(false);
            this.gboxConductores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox gboxConductores;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaContratacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvConductores;
    }
}