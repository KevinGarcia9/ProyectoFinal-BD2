namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelSeleccion = new System.Windows.Forms.Panel();
            this.PanelMenuInferior = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.PanelMenuSuperior = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnOcultarMenu = new FontAwesome.Sharp.IconButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.lblMensajeMenu = new System.Windows.Forms.Label();
            this.cbxJosvin = new System.Windows.Forms.ComboBox();
            this.cbxAlex = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PanelMenu.SuspendLayout();
            this.PanelMenuInferior.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.comboBox1);
            this.PanelMenu.Controls.Add(this.cbxAlex);
            this.PanelMenu.Controls.Add(this.cbxJosvin);
            this.PanelMenu.Controls.Add(this.PanelSeleccion);
            this.PanelMenu.Controls.Add(this.PanelMenuInferior);
            this.PanelMenu.Controls.Add(this.PanelMenuSuperior);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(199, 709);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelSeleccion
            // 
            this.PanelSeleccion.BackColor = System.Drawing.Color.White;
            this.PanelSeleccion.Location = new System.Drawing.Point(1, 132);
            this.PanelSeleccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelSeleccion.Name = "PanelSeleccion";
            this.PanelSeleccion.Size = new System.Drawing.Size(5, 46);
            this.PanelSeleccion.TabIndex = 9;
            // 
            // PanelMenuInferior
            // 
            this.PanelMenuInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenuInferior.Controls.Add(this.btnConfiguracion);
            this.PanelMenuInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMenuInferior.Location = new System.Drawing.Point(0, 595);
            this.PanelMenuInferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenuInferior.Name = "PanelMenuInferior";
            this.PanelMenuInferior.Size = new System.Drawing.Size(197, 112);
            this.PanelMenuInferior.TabIndex = 1;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Black;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 35;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(1, 2);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(195, 108);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // PanelMenuSuperior
            // 
            this.PanelMenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelMenuSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenuSuperior.Name = "PanelMenuSuperior";
            this.PanelMenuSuperior.Size = new System.Drawing.Size(197, 97);
            this.PanelMenuSuperior.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSuperior.Controls.Add(this.lblUsuario);
            this.PanelSuperior.Controls.Add(this.btnOcultarMenu);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(199, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1172, 43);
            this.PanelSuperior.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calisto MT", 10.2F);
            this.lblUsuario.Location = new System.Drawing.Point(59, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 20);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "label1";
            // 
            // btnOcultarMenu
            // 
            this.btnOcultarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOcultarMenu.FlatAppearance.BorderSize = 0;
            this.btnOcultarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarMenu.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarMenu.ForeColor = System.Drawing.Color.Black;
            this.btnOcultarMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnOcultarMenu.IconColor = System.Drawing.Color.Black;
            this.btnOcultarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultarMenu.IconSize = 30;
            this.btnOcultarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcultarMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOcultarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOcultarMenu.Name = "btnOcultarMenu";
            this.btnOcultarMenu.Size = new System.Drawing.Size(52, 39);
            this.btnOcultarMenu.TabIndex = 11;
            this.btnOcultarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOcultarMenu.UseVisualStyleBackColor = true;
            this.btnOcultarMenu.Click += new System.EventHandler(this.btnOcultarMenu_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.DimGray;
            this.PanelContenedor.Controls.Add(this.lblMensajeMenu);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(199, 43);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1172, 666);
            this.PanelContenedor.TabIndex = 3;
            // 
            // lblMensajeMenu
            // 
            this.lblMensajeMenu.AutoSize = true;
            this.lblMensajeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeMenu.ForeColor = System.Drawing.Color.White;
            this.lblMensajeMenu.Location = new System.Drawing.Point(341, 203);
            this.lblMensajeMenu.Name = "lblMensajeMenu";
            this.lblMensajeMenu.Size = new System.Drawing.Size(492, 46);
            this.lblMensajeMenu.TabIndex = 0;
            this.lblMensajeMenu.Text = "Bienvenido Menu Principal";
            this.lblMensajeMenu.Click += new System.EventHandler(this.lblMensajeMenu_Click);
            // 
            // cbxJosvin
            // 
            this.cbxJosvin.FormattingEnabled = true;
            this.cbxJosvin.Items.AddRange(new object[] {
            "Tabla1",
            "Tabla2",
            "Tabla3"});
            this.cbxJosvin.Location = new System.Drawing.Point(12, 231);
            this.cbxJosvin.Name = "cbxJosvin";
            this.cbxJosvin.Size = new System.Drawing.Size(121, 24);
            this.cbxJosvin.TabIndex = 12;
            this.cbxJosvin.Text = "Josvin";
            // 
            // cbxAlex
            // 
            this.cbxAlex.FormattingEnabled = true;
            this.cbxAlex.Items.AddRange(new object[] {
            "Conductores"});
            this.cbxAlex.Location = new System.Drawing.Point(12, 123);
            this.cbxAlex.Name = "cbxAlex";
            this.cbxAlex.Size = new System.Drawing.Size(165, 24);
            this.cbxAlex.TabIndex = 13;
            this.cbxAlex.Text = "Alexander";
            this.cbxAlex.SelectedIndexChanged += new System.EventHandler(this.cbxAlex_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tabla1",
            "Tabla2",
            "Tabla3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Seleidy";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 709);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenuInferior.ResumeLayout(false);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelMenuInferior;
        private System.Windows.Forms.Panel PanelMenuSuperior;
        private System.Windows.Forms.Panel PanelSuperior;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnOcultarMenu;
        private System.Windows.Forms.Panel PanelSeleccion;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lblMensajeMenu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbxJosvin;
        private System.Windows.Forms.ComboBox cbxAlex;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}