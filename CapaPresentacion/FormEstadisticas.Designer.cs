namespace CapaPresentacion
{
    partial class FormEstadisticas
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
            this.gboxestadisticos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.datetimeFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txttotalincedentes = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtingresototal = new System.Windows.Forms.TextBox();
            this.txtpasajerostransp = new System.Windows.Forms.TextBox();
            this.txtfechareporte = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvestadisticas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxestadisticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxestadisticos
            // 
            this.gboxestadisticos.Controls.Add(this.btnBuscar);
            this.gboxestadisticos.Controls.Add(this.label9);
            this.gboxestadisticos.Controls.Add(this.datetimeFechaPago);
            this.gboxestadisticos.Controls.Add(this.btnlimpiar);
            this.gboxestadisticos.Controls.Add(this.cmbestado);
            this.gboxestadisticos.Controls.Add(this.txttotalincedentes);
            this.gboxestadisticos.Controls.Add(this.btneditar);
            this.gboxestadisticos.Controls.Add(this.txtmoneda);
            this.gboxestadisticos.Controls.Add(this.btnguardar);
            this.gboxestadisticos.Controls.Add(this.txtingresototal);
            this.gboxestadisticos.Controls.Add(this.txtpasajerostransp);
            this.gboxestadisticos.Controls.Add(this.txtfechareporte);
            this.gboxestadisticos.Controls.Add(this.txtcodigo);
            this.gboxestadisticos.Controls.Add(this.label8);
            this.gboxestadisticos.Controls.Add(this.label7);
            this.gboxestadisticos.Controls.Add(this.label6);
            this.gboxestadisticos.Controls.Add(this.label5);
            this.gboxestadisticos.Controls.Add(this.label4);
            this.gboxestadisticos.Controls.Add(this.label3);
            this.gboxestadisticos.Controls.Add(this.label2);
            this.gboxestadisticos.Controls.Add(this.label1);
            this.gboxestadisticos.Location = new System.Drawing.Point(25, 12);
            this.gboxestadisticos.Name = "gboxestadisticos";
            this.gboxestadisticos.Size = new System.Drawing.Size(1172, 296);
            this.gboxestadisticos.TabIndex = 0;
            this.gboxestadisticos.TabStop = false;
            this.gboxestadisticos.Text = "Datos Estadisticos";
            this.gboxestadisticos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1024, 161);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 58);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha ";
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Location = new System.Drawing.Point(465, 17);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaPago.TabIndex = 18;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(1024, 222);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(125, 59);
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
            this.cmbestado.Location = new System.Drawing.Point(613, 195);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 14;
            // 
            // txttotalincedentes
            // 
            this.txttotalincedentes.Location = new System.Drawing.Point(613, 152);
            this.txttotalincedentes.Name = "txttotalincedentes";
            this.txttotalincedentes.Size = new System.Drawing.Size(100, 20);
            this.txttotalincedentes.TabIndex = 13;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(1024, 93);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(125, 64);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtmoneda
            // 
            this.txtmoneda.Location = new System.Drawing.Point(613, 112);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(49, 20);
            this.txtmoneda.TabIndex = 12;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(1024, 24);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(125, 63);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtingresototal
            // 
            this.txtingresototal.Location = new System.Drawing.Point(221, 202);
            this.txtingresototal.Name = "txtingresototal";
            this.txtingresototal.Size = new System.Drawing.Size(100, 20);
            this.txtingresototal.TabIndex = 11;
            // 
            // txtpasajerostransp
            // 
            this.txtpasajerostransp.Location = new System.Drawing.Point(221, 164);
            this.txtpasajerostransp.Name = "txtpasajerostransp";
            this.txtpasajerostransp.Size = new System.Drawing.Size(91, 20);
            this.txtpasajerostransp.TabIndex = 10;
            // 
            // txtfechareporte
            // 
            this.txtfechareporte.Location = new System.Drawing.Point(221, 126);
            this.txtfechareporte.Name = "txtfechareporte";
            this.txtfechareporte.Size = new System.Drawing.Size(125, 20);
            this.txtfechareporte.TabIndex = 9;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(221, 91);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(69, 20);
            this.txtcodigo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Incidentes ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingreso Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasajeros Transportados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Reporte";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(737, 674);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(134, 46);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvestadisticas
            // 
            this.dgvestadisticas.BackgroundColor = System.Drawing.Color.White;
            this.dgvestadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestadisticas.Location = new System.Drawing.Point(25, 333);
            this.dgvestadisticas.Name = "dgvestadisticas";
            this.dgvestadisticas.Size = new System.Drawing.Size(922, 316);
            this.dgvestadisticas.TabIndex = 1;
            this.dgvestadisticas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestadisticas_CellClick);
            this.dgvestadisticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestadisticas_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(887, 674);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 46);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvestadisticas);
            this.Controls.Add(this.gboxestadisticos);
            this.Controls.Add(this.btneliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.gboxestadisticos.ResumeLayout(false);
            this.gboxestadisticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxestadisticos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txttotalincedentes;
        private System.Windows.Forms.TextBox txtmoneda;
        private System.Windows.Forms.TextBox txtingresototal;
        private System.Windows.Forms.TextBox txtpasajerostransp;
        private System.Windows.Forms.TextBox txtfechareporte;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.DataGridView dgvestadisticas;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DateTimePicker datetimeFechaPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
    }
}