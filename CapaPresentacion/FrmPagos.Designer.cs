namespace CapaPresentacion
{
    partial class FrmPagos
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
            this.dtgvPagos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistroPago = new System.Windows.Forms.Button();
            this.datetimeFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.cboxTipoPago = new System.Windows.Forms.ComboBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.txtCodigoTarifa = new System.Windows.Forms.TextBox();
            this.txtCodigoPasajero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(455, 397);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgvPagos
            // 
            this.dtgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPagos.Location = new System.Drawing.Point(29, 226);
            this.dtgvPagos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgvPagos.Name = "dtgvPagos";
            this.dtgvPagos.RowHeadersWidth = 62;
            this.dtgvPagos.RowTemplate.Height = 28;
            this.dtgvPagos.Size = new System.Drawing.Size(573, 161);
            this.dtgvPagos.TabIndex = 24;
            this.dtgvPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPagos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoPago);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnRegistroPago);
            this.groupBox1.Controls.Add(this.datetimeFechaPago);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.cboxTipoPago);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.txtCodigoTarifa);
            this.groupBox1.Controls.Add(this.txtCodigoPasajero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(573, 209);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pagos";
            // 
            // txtCodigoPago
            // 
            this.txtCodigoPago.Location = new System.Drawing.Point(136, 38);
            this.txtCodigoPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCodigoPago.Name = "txtCodigoPago";
            this.txtCodigoPago.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoPago.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Código Pago";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(427, 163);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(427, 84);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnRegistroPago
            // 
            this.btnRegistroPago.Location = new System.Drawing.Point(427, 123);
            this.btnRegistroPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRegistroPago.Name = "btnRegistroPago";
            this.btnRegistroPago.Size = new System.Drawing.Size(84, 23);
            this.btnRegistroPago.TabIndex = 18;
            this.btnRegistroPago.Text = "Registrar Pago";
            this.btnRegistroPago.UseVisualStyleBackColor = true;
            this.btnRegistroPago.Click += new System.EventHandler(this.btnRegistroPago_Click_1);
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Location = new System.Drawing.Point(340, 14);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaPago.TabIndex = 17;
            this.datetimeFechaPago.ValueChanged += new System.EventHandler(this.datetimeFechaPago_ValueChanged);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(136, 183);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(70, 20);
            this.txtBanco.TabIndex = 16;
            // 
            // cboxTipoPago
            // 
            this.cboxTipoPago.FormattingEnabled = true;
            this.cboxTipoPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "Transferencia"});
            this.cboxTipoPago.Location = new System.Drawing.Point(136, 153);
            this.cboxTipoPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboxTipoPago.Name = "cboxTipoPago";
            this.cboxTipoPago.Size = new System.Drawing.Size(70, 21);
            this.cboxTipoPago.TabIndex = 15;
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(136, 127);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(70, 21);
            this.cboxEstado.TabIndex = 14;
            // 
            // txtCodigoTarifa
            // 
            this.txtCodigoTarifa.Location = new System.Drawing.Point(136, 98);
            this.txtCodigoTarifa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCodigoTarifa.Name = "txtCodigoTarifa";
            this.txtCodigoTarifa.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoTarifa.TabIndex = 13;
            // 
            // txtCodigoPasajero
            // 
            this.txtCodigoPasajero.Location = new System.Drawing.Point(136, 64);
            this.txtCodigoPasajero.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCodigoPasajero.Name = "txtCodigoPasajero";
            this.txtCodigoPasajero.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoPasajero.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código Tarifa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Pago";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 432);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvPagos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgvPagos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistroPago;
        private System.Windows.Forms.DateTimePicker datetimeFechaPago;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.ComboBox cboxTipoPago;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.TextBox txtCodigoTarifa;
        private System.Windows.Forms.TextBox txtCodigoPasajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}