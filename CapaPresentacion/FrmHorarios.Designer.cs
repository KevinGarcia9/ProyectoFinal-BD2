namespace CapaPresentacion
{
    partial class FrmHorarios
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgvHorarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscarH = new System.Windows.Forms.TextBox();
            this.txtCodigoHorario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarHrs = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datetimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeHoraLLegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCodigoEstacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(761, 703);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 49);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgvHorarios
            // 
            this.dtgvHorarios.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHorarios.Location = new System.Drawing.Point(15, 303);
            this.dtgvHorarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvHorarios.Name = "dtgvHorarios";
            this.dtgvHorarios.RowHeadersWidth = 62;
            this.dtgvHorarios.RowTemplate.Height = 28;
            this.dtgvHorarios.Size = new System.Drawing.Size(847, 383);
            this.dtgvHorarios.TabIndex = 25;
            this.dtgvHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHorarios_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCodigoEstacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBuscarH);
            this.groupBox1.Controls.Add(this.txtCodigoHorario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnActualizarHrs);
            this.groupBox1.Controls.Add(this.btnAgregarHorario);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datetimeFechaFin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datetimeFechaInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datetimeHoraLLegada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datetimeHoraSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1156, 271);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Horarios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(959, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ingresar codigo Estacion";
            // 
            // txtBuscarH
            // 
            this.txtBuscarH.Location = new System.Drawing.Point(962, 54);
            this.txtBuscarH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarH.Name = "txtBuscarH";
            this.txtBuscarH.Size = new System.Drawing.Size(114, 20);
            this.txtBuscarH.TabIndex = 37;
            // 
            // txtCodigoHorario
            // 
            this.txtCodigoHorario.Location = new System.Drawing.Point(167, 76);
            this.txtCodigoHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoHorario.Name = "txtCodigoHorario";
            this.txtCodigoHorario.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoHorario.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Código Horario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1015, 202);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(874, 51);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnActualizarHrs
            // 
            this.btnActualizarHrs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarHrs.Location = new System.Drawing.Point(1015, 124);
            this.btnActualizarHrs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarHrs.Name = "btnActualizarHrs";
            this.btnActualizarHrs.Size = new System.Drawing.Size(84, 23);
            this.btnActualizarHrs.TabIndex = 27;
            this.btnActualizarHrs.Text = "Actualizar Hrs";
            this.btnActualizarHrs.UseVisualStyleBackColor = true;
            this.btnActualizarHrs.Click += new System.EventHandler(this.btnActualizarHrs_Click_1);
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHorario.Location = new System.Drawing.Point(1015, 163);
            this.btnAgregarHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(84, 23);
            this.btnAgregarHorario.TabIndex = 26;
            this.btnAgregarHorario.Text = "Agregar Hrs";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(167, 139);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(70, 21);
            this.cboxEstado.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // datetimeFechaFin
            // 
            this.datetimeFechaFin.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFechaFin.Location = new System.Drawing.Point(649, 183);
            this.datetimeFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeFechaFin.Name = "datetimeFechaFin";
            this.datetimeFechaFin.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaFin.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Fin";
            // 
            // datetimeFechaInicio
            // 
            this.datetimeFechaInicio.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFechaInicio.Location = new System.Drawing.Point(649, 146);
            this.datetimeFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeFechaInicio.Name = "datetimeFechaInicio";
            this.datetimeFechaInicio.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaInicio.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Inicio\r\n";
            // 
            // datetimeHoraLLegada
            // 
            this.datetimeHoraLLegada.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeHoraLLegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeHoraLLegada.Location = new System.Drawing.Point(649, 113);
            this.datetimeHoraLLegada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeHoraLLegada.Name = "datetimeHoraLLegada";
            this.datetimeHoraLLegada.Size = new System.Drawing.Size(80, 20);
            this.datetimeHoraLLegada.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hora Llegada";
            // 
            // datetimeHoraSalida
            // 
            this.datetimeHoraSalida.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeHoraSalida.Location = new System.Drawing.Point(649, 75);
            this.datetimeHoraSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeHoraSalida.Name = "datetimeHoraSalida";
            this.datetimeHoraSalida.Size = new System.Drawing.Size(80, 20);
            this.datetimeHoraSalida.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hora Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Estacion";
            // 
            // cbxCodigoEstacion
            // 
            this.cbxCodigoEstacion.FormattingEnabled = true;
            this.cbxCodigoEstacion.Location = new System.Drawing.Point(167, 105);
            this.cbxCodigoEstacion.Name = "cbxCodigoEstacion";
            this.cbxCodigoEstacion.Size = new System.Drawing.Size(237, 21);
            this.cbxCodigoEstacion.TabIndex = 39;
            this.cbxCodigoEstacion.Click += new System.EventHandler(this.cbxCodigoEstacion_Click);
            // 
            // FrmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvHorarios);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHorarios";
            this.Text = "FrmHorarios";
            this.Load += new System.EventHandler(this.FrmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgvHorarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarHrs;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetimeFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimeFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeHoraLLegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeHoraSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCodigoEstacion;
    }
}