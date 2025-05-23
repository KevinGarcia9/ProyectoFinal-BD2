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
            diseño();
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

   

        FrmLogin frm = new FrmLogin();

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bienvenido Usuario: " + Program.UsuarioActual; // Cambia esto para que use la propiedad UsuarioActual de la sesión
        }

        private void lblMensajeMenu_Click(object sender, EventArgs e)
        {

        }

        private void diseño()
        {
            panelAlex.Visible = false;
            panelSay.Visible = false;
            panelJosvin.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (panelAlex.Visible == true)
            {
                panelAlex.Visible = false;
            }
            if (panelSay.Visible == true)
            {
                panelSay.Visible = false;
            }
            if (panelJosvin.Visible == true)
            {
                panelJosvin.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btngAlexander_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelAlex);
        }

        private void btnAlex1_Click(object sender, EventArgs e)
        {
           
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

            ocultarSubmenu();
        }

        private void btnAlex2_Click(object sender, EventArgs e)
        {
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

            ocultarSubmenu();
        }

        private void btnAlex3_Click(object sender, EventArgs e)
        {
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

            ocultarSubmenu();
        }

        private void btnAlex4_Click(object sender, EventArgs e)
        {
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

            ocultarSubmenu();
        }

        private void btnJosvin_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelJosvin);
        }

        private void btnJosvin1_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }

        private void btnJosvin2_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }

        private void btnJosvin3_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }

        private void btnJosvin4_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }

        private void btngSeleidy_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSay);
        }

        private void btnSay1_Click(object sender, EventArgs e)
        {
            FormMantenimieto frmClie = new FormMantenimieto();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }

            ocultarSubmenu();
        }

        private void btnSay2_Click(object sender, EventArgs e)
        {
            FormIncidentes frmClie = new FormIncidentes();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }

            ocultarSubmenu();

        }

        private void btnSay3_Click(object sender, EventArgs e)
        {
            FormEstadisticas frmClie = new FormEstadisticas();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }

            ocultarSubmenu();
        }

        private void btnSay4_Click(object sender, EventArgs e)
        {
            FormTarjetasdetransportes frmClie = new FormTarjetasdetransportes();
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frmClie.TopLevel = false;
                frmClie.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frmClie);
                this.PanelContenedor.Tag = frmClie;
                frmClie.Show();
            }

            ocultarSubmenu();
        }
    }
}