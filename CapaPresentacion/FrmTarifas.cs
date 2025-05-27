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
    public partial class FrmTarifas : Form
    {
        CD_Tarifas TAR = new CD_Tarifas();
        public FrmTarifas()
        {
            InitializeComponent();
        }

        private void btnAgregarTarifa_Click(object sender, EventArgs e)
        {
            try
            {
               TAR.mtdAgregarTarifa(
               int.Parse(txtCodigoRuta.Text),
               decimal.Parse(txtMonto.Text),
               cboxMoneda.Text,
               datetimeFechaVigencia.Value,
               datetimeFechaVencimiento.Value,
               cboxEstado.Text);

                MessageBox.Show("Tarifa agregada correctamente.");
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

        private void CargarPagos()
        {
            dtgvTarifas.DataSource = TAR.mtdMostrarTarifas();
        }

        private void dtgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgvTarifas.Rows[e.RowIndex];
                txtCodigoTarifa.Text = fila.Cells["CodigoTarifa"].Value.ToString();
                txtCodigoRuta.Text = fila.Cells["CodigoRuta"].Value.ToString();
                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
                cboxMoneda.Text = fila.Cells["Moneda"].Value.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value.ToString();
                datetimeFechaVigencia.Text = fila.Cells["FechaVigencia"].Value.ToString();
                datetimeFechaVencimiento.Text = fila.Cells["FechaVencimiento"].Value.ToString();
            }
        }

        private void FrmTarifas_Load(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnActualizarTarifa_Click_1(object sender, EventArgs e)
        {
            try
            {
               TAR.mtdActualizarTarifa(
               int.Parse(txtCodigoTarifa.Text),
               int.Parse(txtCodigoRuta.Text),
               decimal.Parse(txtMonto.Text),
               cboxMoneda.Text,
               datetimeFechaVigencia.Value,
               datetimeFechaVencimiento.Value,
               cboxEstado.Text);

                MessageBox.Show("Tarifa actualizada correctamente.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                TAR.mtdEliminarTarifa(int.Parse(txtCodigoTarifa.Text));
                MessageBox.Show("Tarifa eliminada correctamente.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarT.Text))
            {
                // Si el campo está vacío, muestra todo
                dtgvTarifas.DataSource = TAR.mtdMostrarTarifas(); // <-- Asegúrate de tener este método
            }
            else
            {
                int codigoRuta;
                if (int.TryParse(txtBuscarT.Text, out codigoRuta))
                {
                    dtgvTarifas.DataSource = TAR.mtdBuscarTarifasPorRuta(codigoRuta);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido para el código de ruta.");
                }
            }
        }
    }
}
