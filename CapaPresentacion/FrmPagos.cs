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
    public partial class FrmPagos : Form
    {
        CD_Pagos PAG = new CD_Pagos();

        public FrmPagos()
        {
            InitializeComponent();
        }

        private void btnRegistroPago_Click(object sender, EventArgs e)
        {
            PAG.mtdAgregarPago(
                int.Parse(txtCodigoPasajero.Text),
                int.Parse(txtCodigoTarifa.Text),
                datetimeFechaPago.Value,
                cboxTipoPago.Text,
                txtBanco.Text,
                cboxEstado.Text
            );
            MessageBox.Show("Pago agregado correctamente.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PAG.mtdActualizarPago(
                int.Parse(txtCodigoPago.Text),
                int.Parse(txtCodigoPasajero.Text),
                int.Parse(txtCodigoTarifa.Text),
                datetimeFechaPago.Value,
                cboxTipoPago.Text,
                txtBanco.Text,
                cboxEstado.Text
            );
            MessageBox.Show("Pago actualizado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PAG.mtdEliminarPago(int.Parse(txtCodigoPago.Text));
            MessageBox.Show("Pago eliminado.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvPagos.DataSource = PAG.mtdBuscarPagosPorPasajero(int.Parse(txtCodigoPasajero.Text));
        }
    }
}
