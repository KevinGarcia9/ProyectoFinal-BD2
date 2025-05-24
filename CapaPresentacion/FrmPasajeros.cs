using CapaDatos;
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
    public partial class FrmPasajeros : Form
    {
        CD_Pasajeros PAS = new CD_Pasajeros();

        public FrmPasajeros()
        {
            InitializeComponent();
        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PAS.mtdAgregarPasajero(
                txtNombre.Text,
                txtDpi.Text,
                txtNit.Text,
                datetimeFechaAlta.Value,
                txtTelefono.Text,
                cboxEstado.Text
            );
            MessageBox.Show("Pasajero agregado.");
            Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            PAS.mtdActualizarPasajero(
                codigo,
                txtNombre.Text,
                txtDpi.Text,
                txtNit.Text,
                datetimeFechaAlta.Value,
                txtTelefono.Text,
                cboxEstado.Text
            );
            MessageBox.Show("Pasajero actualizado.");
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            PAS.mtdEliminarPasajero(codigo);
            MessageBox.Show("Pasajero eliminado.");
            Refresh();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dtgvPasajeros.DataSource = PAS.BuscarPasajero(txtBuscar.Text);
        }
    }
}
