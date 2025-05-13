using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmEstaciones
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
            this.gboxEstaciones = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTiempoEspera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstaciones = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.gboxEstaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxEstaciones
            // 
            this.gboxEstaciones.Controls.Add(this.iconButton1);
            this.gboxEstaciones.Controls.Add(this.btnActualizar);
            this.gboxEstaciones.Controls.Add(this.btnCancelar);
            this.gboxEstaciones.Controls.Add(this.cmbEstado);
            this.gboxEstaciones.Controls.Add(this.label7);
            this.gboxEstaciones.Controls.Add(this.txtTiempoEspera);
            this.gboxEstaciones.Controls.Add(this.label6);
            this.gboxEstaciones.Controls.Add(this.txtSecuencia);
            this.gboxEstaciones.Controls.Add(this.label5);
            this.gboxEstaciones.Controls.Add(this.txtUbicacion);
            this.gboxEstaciones.Controls.Add(this.label4);
            this.gboxEstaciones.Controls.Add(this.txtNombre);
            this.gboxEstaciones.Controls.Add(this.label3);
            this.gboxEstaciones.Controls.Add(this.txtCodigoRuta);
            this.gboxEstaciones.Controls.Add(this.label2);
            this.gboxEstaciones.Controls.Add(this.txtCodigo);
            this.gboxEstaciones.Controls.Add(this.label1);
            this.gboxEstaciones.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.gboxEstaciones.Location = new System.Drawing.Point(12, 12);
            this.gboxEstaciones.Name = "gboxEstaciones";
            this.gboxEstaciones.Size = new System.Drawing.Size(1052, 300);
            this.gboxEstaciones.TabIndex = 0;
            this.gboxEstaciones.TabStop = false;
            this.gboxEstaciones.Text = "DATOS ESTACIONES";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(860, 36);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(155, 61);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 30;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(860, 108);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(155, 61);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.btnCancelar.IconColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(860, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 61);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(204, 252);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 30);
            this.cmbEstado.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estado:";
            // 
            // txtTiempoEspera
            // 
            this.txtTiempoEspera.Location = new System.Drawing.Point(204, 216);
            this.txtTiempoEspera.Name = "txtTiempoEspera";
            this.txtTiempoEspera.Size = new System.Drawing.Size(200, 31);
            this.txtTiempoEspera.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tiempo de Espera:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(204, 180);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(200, 31);
            this.txtSecuencia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Secuencia:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(204, 144);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(400, 31);
            this.txtUbicacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ubicación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 31);
            this.txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // txtCodigoRuta
            // 
            this.txtCodigoRuta.Location = new System.Drawing.Point(204, 72);
            this.txtCodigoRuta.Name = "txtCodigoRuta";
            this.txtCodigoRuta.Size = new System.Drawing.Size(200, 31);
            this.txtCodigoRuta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código Ruta:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(204, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 31);
            this.txtCodigo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Estación:";
            // 
            // dgvEstaciones
            // 
            this.dgvEstaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstaciones.ColumnHeadersHeight = 29;
            this.dgvEstaciones.Location = new System.Drawing.Point(12, 330);
            this.dgvEstaciones.Name = "dgvEstaciones";
            this.dgvEstaciones.ReadOnly = true;
            this.dgvEstaciones.RowHeadersWidth = 51;
            this.dgvEstaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstaciones.Size = new System.Drawing.Size(1052, 260);
            this.dgvEstaciones.TabIndex = 1;
            this.dgvEstaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstaciones_CellClick_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(900, 596);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // FrmEstaciones
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEstaciones);
            this.Controls.Add(this.gboxEstaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstaciones";
            this.Text = "FrmEstaciones";
            this.Load += new System.EventHandler(this.FrmEstaciones_Load_1);
            this.gboxEstaciones.ResumeLayout(false);
            this.gboxEstaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvEstaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FrmEstaciones_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.GroupBox gboxEstaciones;
        private System.Windows.Forms.TextBox txtCodigo, txtCodigoRuta, txtNombre, txtUbicacion, txtSecuencia, txtTiempoEspera;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private System.Windows.Forms.DataGridView dgvEstaciones;

        #region Windows Form Designer generated code

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}