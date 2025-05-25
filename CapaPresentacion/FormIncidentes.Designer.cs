namespace CapaPresentacion
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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txthora = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigoconductor = new System.Windows.Forms.TextBox();
            this.txtcodigotransporte = new System.Windows.Forms.TextBox();
            this.txtcodigoincidente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvincidentes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.datetimeFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxincidentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxincidentes
            // 
            this.gboxincidentes.Controls.Add(this.datetimeFechaPago);
            this.gboxincidentes.Controls.Add(this.btnBuscar);
            this.gboxincidentes.Controls.Add(this.btnlimpiar);
            this.gboxincidentes.Controls.Add(this.cmbestado);
            this.gboxincidentes.Controls.Add(this.txthora);
            this.gboxincidentes.Controls.Add(this.btneditar);
            this.gboxincidentes.Controls.Add(this.txtfecha);
            this.gboxincidentes.Controls.Add(this.btnguardar);
            this.gboxincidentes.Controls.Add(this.txtdescripcion);
            this.gboxincidentes.Controls.Add(this.txtcodigoconductor);
            this.gboxincidentes.Controls.Add(this.txtcodigotransporte);
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
            this.gboxincidentes.Size = new System.Drawing.Size(717, 152);
            this.gboxincidentes.TabIndex = 0;
            this.gboxincidentes.TabStop = false;
            this.gboxincidentes.Text = "Datos Incidentes";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(617, 121);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
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
            this.cmbestado.Location = new System.Drawing.Point(388, 84);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 13;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(541, 353);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(388, 56);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(100, 20);
            this.txthora.TabIndex = 12;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(617, 60);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(388, 27);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 11;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(617, 29);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(148, 114);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(457, 20);
            this.txtdescripcion.TabIndex = 10;
            // 
            // txtcodigoconductor
            // 
            this.txtcodigoconductor.Location = new System.Drawing.Point(148, 86);
            this.txtcodigoconductor.Name = "txtcodigoconductor";
            this.txtcodigoconductor.Size = new System.Drawing.Size(73, 20);
            this.txtcodigoconductor.TabIndex = 9;
            // 
            // txtcodigotransporte
            // 
            this.txtcodigotransporte.Location = new System.Drawing.Point(148, 60);
            this.txtcodigotransporte.Name = "txtcodigotransporte";
            this.txtcodigotransporte.Size = new System.Drawing.Size(73, 20);
            this.txtcodigotransporte.TabIndex = 8;
            // 
            // txtcodigoincidente
            // 
            this.txtcodigoincidente.Location = new System.Drawing.Point(148, 34);
            this.txtcodigoincidente.Name = "txtcodigoincidente";
            this.txtcodigoincidente.Size = new System.Drawing.Size(73, 20);
            this.txtcodigoincidente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Conductor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Incidente";
            // 
            // dgvincidentes
            // 
            this.dgvincidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvincidentes.Location = new System.Drawing.Point(36, 199);
            this.dgvincidentes.Name = "dgvincidentes";
            this.dgvincidentes.Size = new System.Drawing.Size(717, 148);
            this.dgvincidentes.TabIndex = 1;
            this.dgvincidentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvincidentes_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(617, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Location = new System.Drawing.Point(505, 5);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaPago.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(653, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.TextBox txtcodigoconductor;
        private System.Windows.Forms.TextBox txtcodigotransporte;
        private System.Windows.Forms.TextBox txtcodigoincidente;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker datetimeFechaPago;
        private System.Windows.Forms.Button btnSalir;
    }
}