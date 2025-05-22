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
            this.btnEstaciones = new FontAwesome.Sharp.IconButton();
            this.PanelSeleccion = new System.Windows.Forms.Panel();
            this.btnRutas = new FontAwesome.Sharp.IconButton();
            this.btnCuentas = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.PanelMenuInferior = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.PanelMenuSuperior = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnOcultarMenu = new FontAwesome.Sharp.IconButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.lblMensajeMenu = new System.Windows.Forms.Label();
            this.btnmantenimiento = new FontAwesome.Sharp.IconButton();
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
            this.PanelMenu.Controls.Add(this.btnmantenimiento);
            this.PanelMenu.Controls.Add(this.btnEstaciones);
            this.PanelMenu.Controls.Add(this.PanelSeleccion);
            this.PanelMenu.Controls.Add(this.btnRutas);
            this.PanelMenu.Controls.Add(this.btnCuentas);
            this.PanelMenu.Controls.Add(this.btnClientes);
            this.PanelMenu.Controls.Add(this.PanelMenuInferior);
            this.PanelMenu.Controls.Add(this.PanelMenuSuperior);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(150, 576);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnEstaciones
            // 
            this.btnEstaciones.FlatAppearance.BorderSize = 0;
            this.btnEstaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstaciones.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstaciones.ForeColor = System.Drawing.Color.Black;
            this.btnEstaciones.IconChar = FontAwesome.Sharp.IconChar.Timeline;
            this.btnEstaciones.IconColor = System.Drawing.Color.Black;
            this.btnEstaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstaciones.IconSize = 35;
            this.btnEstaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstaciones.Location = new System.Drawing.Point(2, 240);
            this.btnEstaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEstaciones.Name = "btnEstaciones";
            this.btnEstaciones.Size = new System.Drawing.Size(146, 41);
            this.btnEstaciones.TabIndex = 10;
            this.btnEstaciones.Text = "Estaciones";
            this.btnEstaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstaciones.UseVisualStyleBackColor = true;
            this.btnEstaciones.Click += new System.EventHandler(this.btnEstaciones_Click);
            // 
            // PanelSeleccion
            // 
            this.PanelSeleccion.BackColor = System.Drawing.Color.White;
            this.PanelSeleccion.Location = new System.Drawing.Point(1, 107);
            this.PanelSeleccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelSeleccion.Name = "PanelSeleccion";
            this.PanelSeleccion.Size = new System.Drawing.Size(4, 37);
            this.PanelSeleccion.TabIndex = 9;
            // 
            // btnRutas
            // 
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.Black;
            this.btnRutas.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnRutas.IconColor = System.Drawing.Color.Black;
            this.btnRutas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRutas.IconSize = 35;
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(2, 196);
            this.btnRutas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(146, 41);
            this.btnRutas.TabIndex = 4;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.Color.Black;
            this.btnCuentas.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            this.btnCuentas.IconColor = System.Drawing.Color.Black;
            this.btnCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuentas.IconSize = 35;
            this.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.Location = new System.Drawing.Point(2, 151);
            this.btnCuentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(146, 41);
            this.btnCuentas.TabIndex = 3;
            this.btnCuentas.Text = "Conductores";
            this.btnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(2, 106);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(146, 41);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Transportes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // PanelMenuInferior
            // 
            this.PanelMenuInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenuInferior.Controls.Add(this.btnConfiguracion);
            this.PanelMenuInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMenuInferior.Location = new System.Drawing.Point(0, 483);
            this.PanelMenuInferior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenuInferior.Name = "PanelMenuInferior";
            this.PanelMenuInferior.Size = new System.Drawing.Size(148, 91);
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
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(146, 88);
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
            this.PanelMenuSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenuSuperior.Name = "PanelMenuSuperior";
            this.PanelMenuSuperior.Size = new System.Drawing.Size(148, 79);
            this.PanelMenuSuperior.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSuperior.Controls.Add(this.lblUsuario);
            this.PanelSuperior.Controls.Add(this.btnOcultarMenu);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(150, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(878, 36);
            this.PanelSuperior.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calisto MT", 10.2F);
            this.lblUsuario.Location = new System.Drawing.Point(44, 7);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(42, 16);
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
            this.btnOcultarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOcultarMenu.Name = "btnOcultarMenu";
            this.btnOcultarMenu.Size = new System.Drawing.Size(39, 32);
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
            this.PanelContenedor.Location = new System.Drawing.Point(150, 36);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(878, 540);
            this.PanelContenedor.TabIndex = 3;
            // 
            // lblMensajeMenu
            // 
            this.lblMensajeMenu.AutoSize = true;
            this.lblMensajeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeMenu.ForeColor = System.Drawing.Color.White;
            this.lblMensajeMenu.Location = new System.Drawing.Point(256, 165);
            this.lblMensajeMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeMenu.Name = "lblMensajeMenu";
            this.lblMensajeMenu.Size = new System.Drawing.Size(393, 37);
            this.lblMensajeMenu.TabIndex = 0;
            this.lblMensajeMenu.Text = "Bienvenido Menu Principal";
            this.lblMensajeMenu.Click += new System.EventHandler(this.lblMensajeMenu_Click);
            // 
            // btnmantenimiento
            // 
            this.btnmantenimiento.FlatAppearance.BorderSize = 0;
            this.btnmantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmantenimiento.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmantenimiento.ForeColor = System.Drawing.Color.Black;
            this.btnmantenimiento.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnmantenimiento.IconColor = System.Drawing.Color.Black;
            this.btnmantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmantenimiento.IconSize = 35;
            this.btnmantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmantenimiento.Location = new System.Drawing.Point(-1, 294);
            this.btnmantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnmantenimiento.Name = "btnmantenimiento";
            this.btnmantenimiento.Size = new System.Drawing.Size(146, 41);
            this.btnmantenimiento.TabIndex = 11;
            this.btnmantenimiento.Text = "Mantenimiento";
            this.btnmantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmantenimiento.UseVisualStyleBackColor = true;
            this.btnmantenimiento.Click += new System.EventHandler(this.btnmantenimiento_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 576);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnRutas;
        private FontAwesome.Sharp.IconButton btnCuentas;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnOcultarMenu;
        private System.Windows.Forms.Panel PanelSeleccion;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lblMensajeMenu;
        private FontAwesome.Sharp.IconButton btnEstaciones;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconButton btnmantenimiento;
    }
}