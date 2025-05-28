namespace CapaPresentacion
{
    partial class FrmTarifas
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
            this.dtgvTarifas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCodigoRuta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.txtCodigoTarifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxMoneda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarTarifa = new System.Windows.Forms.Button();
            this.btnAgregarTarifa = new System.Windows.Forms.Button();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datetimeFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeFechaVigencia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTarifas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(818, 712);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 47);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgvTarifas
            // 
            this.dtgvTarifas.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dtgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTarifas.Location = new System.Drawing.Point(30, 326);
            this.dtgvTarifas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTarifas.Name = "dtgvTarifas";
            this.dtgvTarifas.RowHeadersWidth = 62;
            this.dtgvTarifas.RowTemplate.Height = 28;
            this.dtgvTarifas.Size = new System.Drawing.Size(873, 360);
            this.dtgvTarifas.TabIndex = 25;
            this.dtgvTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTarifas_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCodigoRuta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBuscarT);
            this.groupBox1.Controls.Add(this.txtCodigoTarifa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxMoneda);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnActualizarTarifa);
            this.groupBox1.Controls.Add(this.btnAgregarTarifa);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datetimeFechaVencimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datetimeFechaVigencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1134, 284);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Tarifas";
            // 
            // cbxCodigoRuta
            // 
            this.cbxCodigoRuta.FormattingEnabled = true;
            this.cbxCodigoRuta.Location = new System.Drawing.Point(154, 106);
            this.cbxCodigoRuta.Name = "cbxCodigoRuta";
            this.cbxCodigoRuta.Size = new System.Drawing.Size(232, 21);
            this.cbxCodigoRuta.TabIndex = 38;
            this.cbxCodigoRuta.Click += new System.EventHandler(this.cbxCodigoRuta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(944, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ingresar codigo Rutas";
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(915, 57);
            this.txtBuscarT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(173, 20);
            this.txtBuscarT.TabIndex = 36;
            // 
            // txtCodigoTarifa
            // 
            this.txtCodigoTarifa.Location = new System.Drawing.Point(154, 74);
            this.txtCodigoTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoTarifa.Name = "txtCodigoTarifa";
            this.txtCodigoTarifa.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoTarifa.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Código Tarifa";
            // 
            // cboxMoneda
            // 
            this.cboxMoneda.FormattingEnabled = true;
            this.cboxMoneda.Items.AddRange(new object[] {
            "GTQ",
            "USD",
            "EUR"});
            this.cboxMoneda.Location = new System.Drawing.Point(154, 171);
            this.cboxMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMoneda.Name = "cboxMoneda";
            this.cboxMoneda.Size = new System.Drawing.Size(70, 21);
            this.cboxMoneda.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Moneda";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(154, 139);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(70, 20);
            this.txtMonto.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Monto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(979, 215);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(810, 54);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnActualizarTarifa
            // 
            this.btnActualizarTarifa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTarifa.Location = new System.Drawing.Point(979, 137);
            this.btnActualizarTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarTarifa.Name = "btnActualizarTarifa";
            this.btnActualizarTarifa.Size = new System.Drawing.Size(93, 23);
            this.btnActualizarTarifa.TabIndex = 27;
            this.btnActualizarTarifa.Text = "Actualizar Tarifa";
            this.btnActualizarTarifa.UseVisualStyleBackColor = true;
            this.btnActualizarTarifa.Click += new System.EventHandler(this.btnActualizarTarifa_Click_1);
            // 
            // btnAgregarTarifa
            // 
            this.btnAgregarTarifa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarifa.Location = new System.Drawing.Point(979, 176);
            this.btnAgregarTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTarifa.Name = "btnAgregarTarifa";
            this.btnAgregarTarifa.Size = new System.Drawing.Size(93, 23);
            this.btnAgregarTarifa.TabIndex = 26;
            this.btnAgregarTarifa.Text = "Agregar Tarifa";
            this.btnAgregarTarifa.UseVisualStyleBackColor = true;
            this.btnAgregarTarifa.Click += new System.EventHandler(this.btnAgregarTarifa_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(154, 205);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(70, 21);
            this.cboxEstado.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // datetimeFechaVencimiento
            // 
            this.datetimeFechaVencimiento.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFechaVencimiento.Location = new System.Drawing.Point(512, 61);
            this.datetimeFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeFechaVencimiento.Name = "datetimeFechaVencimiento";
            this.datetimeFechaVencimiento.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaVencimiento.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // datetimeFechaVigencia
            // 
            this.datetimeFechaVigencia.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFechaVigencia.Location = new System.Drawing.Point(496, 27);
            this.datetimeFechaVigencia.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeFechaVigencia.Name = "datetimeFechaVigencia";
            this.datetimeFechaVigencia.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaVigencia.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha Vigencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Ruta";
            // 
            // FrmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvTarifas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTarifas";
            this.Text = "FrmTarifas";
            this.Load += new System.EventHandler(this.FrmTarifas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTarifas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgvTarifas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoTarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxMoneda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizarTarifa;
        private System.Windows.Forms.Button btnAgregarTarifa;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetimeFechaVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeFechaVigencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCodigoRuta;
    }
}