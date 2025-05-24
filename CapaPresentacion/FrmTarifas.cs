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
            TAR.mtdAgregarTarifa(
               int.Parse(txtCodigoRuta.Text),
               decimal.Parse(txtMonto.Text),
               cboxMoneda.Text,
               datetimeFechaVigencia.Value,
               datetimeFechaVencimiento.Value,
               cboxEstado.Text
           );
            MessageBox.Show("Tarifa agregada correctamente.");
        }

        private void btnActualizarTarifa_Click(object sender, EventArgs e)
        {
            TAR.mtdActualizarTarifa(
               int.Parse(txtCodigoTarifa.Text),
               int.Parse(txtCodigoRuta.Text),
               decimal.Parse(txtMonto.Text),
               cboxMoneda.Text,
               datetimeFechaVigencia.Value,
               datetimeFechaVencimiento.Value,
               cboxEstado.Text
           );
            MessageBox.Show("Tarifa actualizada correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TAR.mtdEliminarTarifa(int.Parse(txtCodigoTarifa.Text));
            MessageBox.Show("Tarifa eliminada correctamente.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvTarifas.DataSource = TAR.mtdBuscarTarifasPorRuta(int.Parse(txtCodigoRuta.Text));
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
    }
}
