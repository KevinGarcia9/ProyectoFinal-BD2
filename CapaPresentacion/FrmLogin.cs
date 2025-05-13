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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            // Validación vacía  
            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación fija para pruebas  
            if (usuario == "admin" && clave == "1234")
            {
                Program.UsuarioActual = usuario;
                MessageBox.Show("Bienvenido", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmMenuPrincipal frm = new FrmMenuPrincipal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
