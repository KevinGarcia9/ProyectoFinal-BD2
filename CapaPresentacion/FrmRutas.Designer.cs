using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmRutas
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
            this.gboxRutas = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoRuta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.gboxRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxRutas
            // 
            this.gboxRutas.Controls.Add(this.btnGuardar);
            this.gboxRutas.Controls.Add(this.btnActualizar);
            this.gboxRutas.Controls.Add(this.btnCancelar);
            this.gboxRutas.Controls.Add(this.cmbEstado);
            this.gboxRutas.Controls.Add(this.label7);
            this.gboxRutas.Controls.Add(this.cmbTipoRuta);
            this.gboxRutas.Controls.Add(this.label6);
            this.gboxRutas.Controls.Add(this.txtDistancia);
            this.gboxRutas.Controls.Add(this.label5);
            this.gboxRutas.Controls.Add(this.txtDestino);
            this.gboxRutas.Controls.Add(this.label4);
            this.gboxRutas.Controls.Add(this.txtOrigen);
            this.gboxRutas.Controls.Add(this.label3);
            this.gboxRutas.Controls.Add(this.txtNombre);
            this.gboxRutas.Controls.Add(this.label2);
            this.gboxRutas.Controls.Add(this.txtCodigo);
            this.gboxRutas.Controls.Add(this.label1);
            this.gboxRutas.Location = new System.Drawing.Point(12, 12);
            this.gboxRutas.Name = "gboxRutas";
            this.gboxRutas.Size = new System.Drawing.Size(1052, 264);
            this.gboxRutas.TabIndex = 0;
            this.gboxRutas.TabStop = false;
            this.gboxRutas.Text = "DATOS RUTAS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnGuardar.IconColor = System.Drawing.Color.Green;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(874, 81);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 30;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(874, 121);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 35);
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
            this.btnCancelar.Location = new System.Drawing.Point(874, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
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
            this.cmbEstado.Location = new System.Drawing.Point(204, 222);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estado:";
            // 
            // cmbTipoRuta
            // 
            this.cmbTipoRuta.FormattingEnabled = true;
            this.cmbTipoRuta.Items.AddRange(new object[] {
            "Urbana",
            "Interurbana"});
            this.cmbTipoRuta.Location = new System.Drawing.Point(204, 186);
            this.cmbTipoRuta.Name = "cmbTipoRuta";
            this.cmbTipoRuta.Size = new System.Drawing.Size(200, 24);
            this.cmbTipoRuta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de Ruta:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(204, 150);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(200, 22);
            this.txtDistancia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Distancia:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(204, 114);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(200, 22);
            this.txtDestino.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destino:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(204, 78);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(200, 22);
            this.txtOrigen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Origen:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(854, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 22);
            this.txtCodigo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Ruta:";
            // 
            // dgvRutas
            // 
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRutas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(12, 294);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersWidth = 51;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(1052, 270);
            this.dgvRutas.TabIndex = 1;
            this.dgvRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellClick_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(914, 588);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // FrmRutas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 666);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.gboxRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRutas";
            this.Text = "FrmRutas";
            this.Load += new System.EventHandler(this.FrmRutas_Load_1);
            this.gboxRutas.ResumeLayout(false);
            this.gboxRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void FrmRutas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.GroupBox gboxRutas;
        private System.Windows.Forms.TextBox txtCodigo, txtNombre, txtOrigen, txtDestino, txtDistancia;
        private System.Windows.Forms.ComboBox cmbTipoRuta, cmbEstado;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private System.Windows.Forms.DataGridView dgvRutas;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}