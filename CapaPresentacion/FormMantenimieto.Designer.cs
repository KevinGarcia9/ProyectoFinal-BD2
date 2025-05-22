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
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtfechasalida = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfechaingreso = new System.Windows.Forms.TextBox();
            this.txtcodigotransp = new System.Windows.Forms.TextBox();
            this.txtcodigomant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvmatenimiento = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodigoMantenimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CodigoTransporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbestado);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.txtmoneda);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtfechasalida);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtfechaingreso);
            this.groupBox1.Controls.Add(this.txtcodigotransp);
            this.groupBox1.Controls.Add(this.txtcodigomant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(56, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(931, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Mantenimiento";
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(616, 124);
            this.cmbestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(160, 24);
            this.cmbestado.TabIndex = 13;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(823, 174);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtmoneda
            // 
            this.txtmoneda.Location = new System.Drawing.Point(616, 70);
            this.txtmoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(53, 22);
            this.txtmoneda.TabIndex = 12;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(823, 118);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(616, 34);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(132, 22);
            this.txtcosto.TabIndex = 11;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(823, 66);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // txtfechasalida
            // 
            this.txtfechasalida.Location = new System.Drawing.Point(197, 174);
            this.txtfechasalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfechasalida.Name = "txtfechasalida";
            this.txtfechasalida.Size = new System.Drawing.Size(132, 22);
            this.txtfechasalida.TabIndex = 10;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(823, 23);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 28);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtfechaingreso
            // 
            this.txtfechaingreso.Location = new System.Drawing.Point(197, 135);
            this.txtfechaingreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfechaingreso.Name = "txtfechaingreso";
            this.txtfechaingreso.Size = new System.Drawing.Size(132, 22);
            this.txtfechaingreso.TabIndex = 9;
            // 
            // txtcodigotransp
            // 
            this.txtcodigotransp.Location = new System.Drawing.Point(197, 80);
            this.txtcodigotransp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigotransp.Name = "txtcodigotransp";
            this.txtcodigotransp.Size = new System.Drawing.Size(77, 22);
            this.txtcodigotransp.TabIndex = 8;
            // 
            // txtcodigomant
            // 
            this.txtcodigomant.Location = new System.Drawing.Point(197, 34);
            this.txtcodigomant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigomant.Name = "txtcodigomant";
            this.txtcodigomant.Size = new System.Drawing.Size(77, 22);
            this.txtcodigomant.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Moneda";
            // 
            // dgvmatenimiento
            // 
            this.dgvmatenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatenimiento.Location = new System.Drawing.Point(56, 238);
            this.dgvmatenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvmatenimiento.Name = "dgvmatenimiento";
            this.dgvmatenimiento.RowHeadersWidth = 51;
            this.dgvmatenimiento.Size = new System.Drawing.Size(931, 226);
            this.dgvmatenimiento.TabIndex = 6;
            this.dgvmatenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmatenimiento_CellClick);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(879, 485);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 28);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(733, 485);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Cancelar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMantenimieto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvmatenimiento);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtcodigotransp;
        private System.Windows.Forms.TextBox txtcodigomant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvmatenimiento;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
    }
}