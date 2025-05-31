namespace CapaPresentacion
{
    partial class FormMantenimieto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCodigoTrasnp = new System.Windows.Forms.ComboBox();
            this.datetimeFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtfechasalida = new System.Windows.Forms.TextBox();
            this.txtfechaingreso = new System.Windows.Forms.TextBox();
            this.txtcodigomant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvmatenimiento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodigoMantenimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CodigoTransporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCodigoTrasnp);
            this.groupBox1.Controls.Add(this.datetimeFechaPago);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.cmbestado);
            this.groupBox1.Controls.Add(this.txtmoneda);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtfechasalida);
            this.groupBox1.Controls.Add(this.txtfechaingreso);
            this.groupBox1.Controls.Add(this.txtcodigomant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Mantenimiento";
            // 
            // cbxCodigoTrasnp
            // 
            this.cbxCodigoTrasnp.FormattingEnabled = true;
            this.cbxCodigoTrasnp.Location = new System.Drawing.Point(175, 104);
            this.cbxCodigoTrasnp.Name = "cbxCodigoTrasnp";
            this.cbxCodigoTrasnp.Size = new System.Drawing.Size(243, 21);
            this.cbxCodigoTrasnp.TabIndex = 19;
            this.cbxCodigoTrasnp.Click += new System.EventHandler(this.cbxCodigoTrasnp_Click);
            // 
            // datetimeFechaPago
            // 
            this.datetimeFechaPago.Location = new System.Drawing.Point(399, 10);
            this.datetimeFechaPago.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeFechaPago.Name = "datetimeFechaPago";
            this.datetimeFechaPago.Size = new System.Drawing.Size(212, 20);
            this.datetimeFechaPago.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(925, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 46);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(925, 182);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(112, 46);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Cancelar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(530, 132);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 13;
            // 
            // txtmoneda
            // 
            this.txtmoneda.Location = new System.Drawing.Point(530, 94);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(41, 20);
            this.txtmoneda.TabIndex = 12;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(925, 71);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(112, 46);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(530, 58);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 11;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(925, 19);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(112, 46);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // txtfechasalida
            // 
            this.txtfechasalida.Location = new System.Drawing.Point(175, 180);
            this.txtfechasalida.Name = "txtfechasalida";
            this.txtfechasalida.Size = new System.Drawing.Size(100, 20);
            this.txtfechasalida.TabIndex = 10;
            // 
            // txtfechaingreso
            // 
            this.txtfechaingreso.Location = new System.Drawing.Point(175, 149);
            this.txtfechaingreso.Name = "txtfechaingreso";
            this.txtfechaingreso.Size = new System.Drawing.Size(100, 20);
            this.txtfechaingreso.TabIndex = 9;
            // 
            // txtcodigomant
            // 
            this.txtcodigomant.Location = new System.Drawing.Point(175, 67);
            this.txtcodigomant.Name = "txtcodigomant";
            this.txtcodigomant.Size = new System.Drawing.Size(59, 20);
            this.txtcodigomant.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Moneda";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(967, 272);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(121, 50);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvmatenimiento
            // 
            this.dgvmatenimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvmatenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatenimiento.Location = new System.Drawing.Point(42, 295);
            this.dgvmatenimiento.Name = "dgvmatenimiento";
            this.dgvmatenimiento.RowHeadersWidth = 51;
            this.dgvmatenimiento.Size = new System.Drawing.Size(873, 386);
            this.dgvmatenimiento.TabIndex = 6;
            this.dgvmatenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmatenimiento_CellClick);
            // 
            // FormMantenimieto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.dgvmatenimiento);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantenimieto";
            this.Text = "FormMantenimieto";
            this.Load += new System.EventHandler(this.FormMantenimieto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.TextBox txtmoneda;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtfechasalida;
        private System.Windows.Forms.TextBox txtfechaingreso;
        private System.Windows.Forms.TextBox txtcodigomant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvmatenimiento;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker datetimeFechaPago;
        private System.Windows.Forms.ComboBox cbxCodigoTrasnp;
    }
}