﻿namespace CapaPresentacion
{
    partial class FormIncidentes
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
            this.gboxincidentes = new System.Windows.Forms.GroupBox();
            this.cbxCodigoConductor = new System.Windows.Forms.ComboBox();
            this.cbxCodigoTransporte = new System.Windows.Forms.ComboBox();
            this.datetimeFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigoincidente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvincidentes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxincidentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxincidentes
            // 
            this.gboxincidentes.Controls.Add(this.cbxCodigoConductor);
            this.gboxincidentes.Controls.Add(this.cbxCodigoTransporte);
            this.gboxincidentes.Controls.Add(this.datetimeFechaPago);
            this.gboxincidentes.Controls.Add(this.btnBuscar);
            this.gboxincidentes.Controls.Add(this.btnlimpiar);
            this.gboxincidentes.Controls.Add(this.cmbestado);
            this.gboxincidentes.Controls.Add(this.txthora);
            this.gboxincidentes.Controls.Add(this.btneditar);
            this.gboxincidentes.Controls.Add(this.txtfecha);
            this.gboxincidentes.Controls.Add(this.btnguardar);
            this.gboxincidentes.Controls.Add(this.txtdescripcion);
            this.gboxincidentes.Controls.Add(this.txtcodigoincidente);
            this.gboxincidentes.Controls.Add(this.label7);
            this.gboxincidentes.Controls.Add(this.label6);
            this.gboxincidentes.Controls.Add(this.label5);
            this.gboxincidentes.Controls.Add(this.label4);
            this.gboxincidentes.Controls.Add(this.label3);
            this.gboxincidentes.Controls.Add(this.label2);
            this.gboxincidentes.Controls.Add(this.label1);
            this.gboxincidentes.Location = new System.Drawing.Point(36, 26);
            this.gboxincidentes.Name = "gboxincidentes";
            this.gboxincidentes.Size = new System.Drawing.Size(1128, 258);
            this.gboxincidentes.TabIndex = 0;
            this.gboxincidentes.TabStop = false;
            this.gboxincidentes.Text = "Datos Incidentes";
            // 
            // cbxCodigoConductor
            // 
            this.cbxCodigoConductor.FormattingEnabled = true;
            this.cbxCodigoConductor.Location = new System.Drawing.Point(174, 136);
            this.cbxCodigoConductor.Name = "cbxCodigoConductor";
            this.cbxCodigoConductor.Size = new System.Drawing.Size(243, 21);
            this.cbxCodigoConductor.TabIndex = 21;
            this.cbxCodigoConductor.Click += new System.EventHandler(this.cbxCodigoConductor_Click);
            // 
            // cbxCodigoTransporte
            // 
            this.cbxCodigoTransporte.FormattingEnabled = true;
            this.cbxCodigoTransporte.Location = new System.Drawing.Point(174, 101);
            this.cbxCodigoTransporte.Name = "cbxCodigoTransporte";
            this.cbxCodigoTransporte.Size = new System.Drawing.Size(243, 21);
            this.cbxCodigoTransporte.TabIndex = 20;
            this.cbxCodigoTransporte.Click += new System.EventHandler(this.cbxCodigoTransporte_Click);
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Location = new System.Drawing.Point(439, 19);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaPago.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1023, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 48);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1023, 187);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(90, 48);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Cancelar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(617, 128);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 13;
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(617, 100);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(100, 20);
            this.txthora.TabIndex = 12;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(1023, 79);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 48);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(617, 71);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 11;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(1023, 19);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 48);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(174, 170);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(457, 20);
            this.txtdescripcion.TabIndex = 10;
            // 
            // txtcodigoincidente
            // 
            this.txtcodigoincidente.Location = new System.Drawing.Point(174, 71);
            this.txtcodigoincidente.Name = "txtcodigoincidente";
            this.txtcodigoincidente.Size = new System.Drawing.Size(73, 20);
            this.txtcodigoincidente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Conductor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Incidente";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(1059, 302);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(104, 57);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvincidentes
            // 
            this.dgvincidentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvincidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvincidentes.Location = new System.Drawing.Point(36, 320);
            this.dgvincidentes.Name = "dgvincidentes";
            this.dgvincidentes.Size = new System.Drawing.Size(928, 342);
            this.dgvincidentes.TabIndex = 1;
            this.dgvincidentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvincidentes_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1060, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 57);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvincidentes);
            this.Controls.Add(this.gboxincidentes);
            this.Controls.Add(this.btneliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIncidentes";
            this.Text = "FormIncidentes";
            this.Load += new System.EventHandler(this.FormIncidentes_Load);
            this.gboxincidentes.ResumeLayout(false);
            this.gboxincidentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxincidentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvincidentes;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcodigoincidente;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker datetimeFechaPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxCodigoConductor;
        private System.Windows.Forms.ComboBox cbxCodigoTransporte;
    }
}