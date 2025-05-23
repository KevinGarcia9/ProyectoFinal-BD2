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
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
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
            this.dgvestadisticas = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.gboxestadisticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxestadisticos
            // 
            this.gboxestadisticos.Controls.Add(this.btnlimpiar);
            this.gboxestadisticos.Controls.Add(this.cmbestado);
            this.gboxestadisticos.Controls.Add(this.btneliminar);
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
            this.gboxestadisticos.Size = new System.Drawing.Size(852, 187);
            this.gboxestadisticos.TabIndex = 0;
            this.gboxestadisticos.TabStop = false;
            this.gboxestadisticos.Text = "Datos Estadisticos";
            this.gboxestadisticos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(507, 110);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 14;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(752, 113);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 28);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txttotalincedentes
            // 
            this.txttotalincedentes.Location = new System.Drawing.Point(507, 67);
            this.txttotalincedentes.Name = "txttotalincedentes";
            this.txttotalincedentes.Size = new System.Drawing.Size(100, 20);
            this.txttotalincedentes.TabIndex = 13;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(752, 70);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(94, 29);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtmoneda
            // 
            this.txtmoneda.Location = new System.Drawing.Point(507, 27);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(49, 20);
            this.txtmoneda.TabIndex = 12;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(752, 30);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(94, 28);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtingresototal
            // 
            this.txtingresototal.Location = new System.Drawing.Point(185, 131);
            this.txtingresototal.Name = "txtingresototal";
            this.txtingresototal.Size = new System.Drawing.Size(100, 20);
            this.txtingresototal.TabIndex = 11;
            // 
            // txtpasajerostransp
            // 
            this.txtpasajerostransp.Location = new System.Drawing.Point(185, 93);
            this.txtpasajerostransp.Name = "txtpasajerostransp";
            this.txtpasajerostransp.Size = new System.Drawing.Size(91, 20);
            this.txtpasajerostransp.TabIndex = 10;
            // 
            // txtfechareporte
            // 
            this.txtfechareporte.Location = new System.Drawing.Point(185, 55);
            this.txtfechareporte.Name = "txtfechareporte";
            this.txtfechareporte.Size = new System.Drawing.Size(125, 20);
            this.txtfechareporte.TabIndex = 9;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(185, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(69, 20);
            this.txtcodigo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Incidentes ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingreso Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasajeros Transportados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Reporte";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // dgvestadisticas
            // 
            this.dgvestadisticas.BackgroundColor = System.Drawing.Color.White;
            this.dgvestadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestadisticas.Location = new System.Drawing.Point(25, 215);
            this.dgvestadisticas.Name = "dgvestadisticas";
            this.dgvestadisticas.Size = new System.Drawing.Size(751, 285);
            this.dgvestadisticas.TabIndex = 1;
            this.dgvestadisticas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestadisticas_CellClick);
            this.dgvestadisticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestadisticas_CellContentClick);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(752, 147);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(94, 24);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Cancelar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 627);
            this.Controls.Add(this.dgvestadisticas);
            this.Controls.Add(this.gboxestadisticos);
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
    }
}