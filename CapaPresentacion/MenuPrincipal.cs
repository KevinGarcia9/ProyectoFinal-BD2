using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            PanelSeleccion.Visible = false;
        }


        FrmLogin frmLogin = new FrmLogin(); 

        private void btnOcultarMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 200)
            {
                PanelMenu.Width = 40;
            }
            else
            {
                PanelMenu.Width = 200;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            PanelSeleccion.Visible = true; // hacer visible el boton

            FrmTransportes frmClie = new FrmTransportes();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        FrmLogin frm = new FrmLogin();

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bienvenido Usuario: " + Program.UsuarioActual; // Cambia esto para que use la propiedad UsuarioActual de la sesión
        }

        private void lblMensajeMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            PanelSeleccion.Visible = true; // hacer visible el boton

            FrmConductores frmClie = new FrmConductores();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }

        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            PanelSeleccion.Visible = true; // hacer visible el boton

            FrmRutas frmClie = new FrmRutas();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }
        }

        private void btnEstaciones_Click(object sender, EventArgs e)
        {
            PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            PanelSeleccion.Visible = true; // hacer visible el boton

            FrmEstaciones frmClie = new FrmEstaciones();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}