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
            try
            {
               PAS.mtdAgregarPasajero(
               txtNombre.Text,
               txtDpi.Text,
               txtNit.Text,
               datetimeFechaAlta.Value,
               txtTelefono.Text,
               cboxEstado.Text);

               MessageBox.Show("Pasajero agregado.");
               CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dtgvPasajeros.DataSource = PAS.mtdBuscarPasajero(txtBuscar.Text);
        }
        private void CargarPagos()
        {
            dtgvPasajeros.DataSource = PAS.mtdMostrarPasajeros();
        }
        private void dtgvPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgvPasajeros.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["CodigoPasajero"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDpi.Text = fila.Cells["Dpi"].Value.ToString();
                txtNit.Text = fila.Cells["Nit"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value.ToString();
                datetimeFechaAlta.Text = fila.Cells["FechaAlta"].Value.ToString();
            }
        }

        private void FrmPasajeros_Load_1(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
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
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                PAS.mtdEliminarPasajero(codigo);
                MessageBox.Show("Pasajero eliminado.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
