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
            this.cbxCodigoTarifa = new System.Windows.Forms.ComboBox();
            this.cbxCodigoPasajero = new System.Windows.Forms.ComboBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1146, 1060);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 91);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgvPagos
            // 
            this.dtgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPagos.Location = new System.Drawing.Point(44, 463);
            this.dtgvPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPagos.Name = "dtgvPagos";
            this.dtgvPagos.RowHeadersWidth = 62;
            this.dtgvPagos.RowTemplate.Height = 28;
            this.dtgvPagos.Size = new System.Drawing.Size(1245, 574);
            this.dtgvPagos.TabIndex = 24;
            this.dtgvPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPagos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBuscarP);
            this.groupBox1.Controls.Add(this.cbxCodigoTarifa);
            this.groupBox1.Controls.Add(this.cbxCodigoPasajero);
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(44, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1767, 431);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pagos";
            // 
            // cbxCodigoTarifa
            // 
            this.cbxCodigoTarifa.FormattingEnabled = true;
            this.cbxCodigoTarifa.Location = new System.Drawing.Point(235, 179);
            this.cbxCodigoTarifa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCodigoTarifa.Name = "cbxCodigoTarifa";
            this.cbxCodigoTarifa.Size = new System.Drawing.Size(422, 28);
            this.cbxCodigoTarifa.TabIndex = 25;
            this.cbxCodigoTarifa.Click += new System.EventHandler(this.cbxCodigoTarifa_Click);
            // 
            // cbxCodigoPasajero
            // 
            this.cbxCodigoPasajero.FormattingEnabled = true;
            this.cbxCodigoPasajero.Location = new System.Drawing.Point(235, 136);
            this.cbxCodigoPasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCodigoPasajero.Name = "cbxCodigoPasajero";
            this.cbxCodigoPasajero.Size = new System.Drawing.Size(422, 28);
            this.cbxCodigoPasajero.TabIndex = 24;
            this.cbxCodigoPasajero.Click += new System.EventHandler(this.cbxCodigoPasajero_Click);
            // 
            // txtCodigoPago
            // 
            this.txtCodigoPago.Location = new System.Drawing.Point(235, 90);
            this.txtCodigoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPago.Name = "txtCodigoPago";
            this.txtCodigoPago.Size = new System.Drawing.Size(103, 26);
            this.txtCodigoPago.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Código Pago";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1582, 343);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1285, 51);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(188, 38);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1582, 207);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 50);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnRegistroPago
            // 
            this.btnRegistroPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPago.Location = new System.Drawing.Point(1582, 273);
            this.btnRegistroPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistroPago.Name = "btnRegistroPago";
            this.btnRegistroPago.Size = new System.Drawing.Size(150, 50);
            this.btnRegistroPago.TabIndex = 18;
            this.btnRegistroPago.Text = "Registrar Pago";
            this.btnRegistroPago.UseVisualStyleBackColor = true;
            this.btnRegistroPago.Click += new System.EventHandler(this.btnRegistroPago_Click_1);
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFechaPago.Location = new System.Drawing.Point(729, 93);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(316, 26);
            this.datetimeFechaPago.TabIndex = 17;
            this.datetimeFechaPago.ValueChanged += new System.EventHandler(this.datetimeFechaPago_ValueChanged);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(235, 313);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(103, 26);
            this.txtBanco.TabIndex = 16;
            // 
            // cboxTipoPago
            // 
            this.cboxTipoPago.FormattingEnabled = true;
            this.cboxTipoPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "Transferencia"});
            this.cboxTipoPago.Location = new System.Drawing.Point(235, 267);
            this.cboxTipoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxTipoPago.Name = "cboxTipoPago";
            this.cboxTipoPago.Size = new System.Drawing.Size(103, 28);
            this.cboxTipoPago.TabIndex = 15;
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(235, 227);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(103, 28);
            this.cboxEstado.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código Tarifa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(796, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Pago";
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(1494, 57);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(258, 26);
            this.txtBuscarP.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1534, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ingresar codigo Pasajero";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1854, 1106);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvPagos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCodigoTarifa;
        private System.Windows.Forms.ComboBox cbxCodigoPasajero;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.Label label8;
    }
}