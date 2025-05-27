using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        private void MtdMostrarFK()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoPasajero,Nombre,Nit,Estado from Pasajeros", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoPasajero + ' - ' + Nombre + ' - ' + Nit + ' - ' + Estado");

            cbxCodigoPasajero.DataSource = dt;
            cbxCodigoPasajero.DisplayMember = "Descripcion";
            cbxCodigoPasajero.ValueMember = "CodigoPasajero";

        }

        private void MtdMostrarFK2()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoTarifa,Monto,Moneda,Estado from Tarifas", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoTarifa + ' - ' + Monto + ' - ' + Moneda + ' - ' + Estado");

            cbxCodigoTarifa.DataSource = dt;
            cbxCodigoTarifa.DisplayMember = "Descripcion";
            cbxCodigoTarifa.ValueMember = "CodigoTarifa";

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtBuscarP.Text))
            {
                dtgvPagos.DataSource = PAG.mtdMostrarPagos(); 
            }
            else
            {
                int codigoPasajero;
                if (int.TryParse(txtBuscarP.Text, out codigoPasajero))
                {
                    dtgvPagos.DataSource = PAG.mtdBuscarPagosPorPasajero(codigoPasajero);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido para el código de pasajero.");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarPagos()
        {
            dtgvPagos.DataSource = PAG.mtdMostrarPagos();
        }

        private void FrmPagos_Load_1(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void dtgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgvPagos.Rows[e.RowIndex];
                txtCodigoPago.Text = fila.Cells["CodigoPago"].Value.ToString();
                cbxCodigoPasajero.Text = fila.Cells["CodigoPasajero"].Value.ToString();
                cbxCodigoTarifa.Text = fila.Cells["CodigoTarifa"].Value.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value.ToString();
                cboxTipoPago.Text = fila.Cells["TipoPago"].Value.ToString();
                txtBanco.Text = fila.Cells["Banco"].Value.ToString();
                datetimeFechaPago.Text = fila.Cells["FechaPago"].Value.ToString();
            }
        }

        private void btnRegistroPago_Click_1(object sender, EventArgs e)
        {

            int FK = Convert.ToInt32(cbxCodigoPasajero.SelectedValue.ToString());
            int FK2 = Convert.ToInt32(cbxCodigoTarifa.SelectedValue.ToString());

            try
            {
                PAG.mtdAgregarPago(
               FK,
               FK2,
               datetimeFechaPago.Value,
               cboxTipoPago.Text,
               txtBanco.Text,
               cboxEstado.Text);

                MessageBox.Show("Pago agregado correctamente.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }


        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                PAG.mtdEliminarPago(int.Parse(txtCodigoPago.Text));
                MessageBox.Show("Pago eliminado.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            int FK = Convert.ToInt32(cbxCodigoPasajero.SelectedValue.ToString());
            int FK2 = Convert.ToInt32(cbxCodigoTarifa.SelectedValue.ToString());

            try
            {
                PAG.mtdActualizarPago(
               int.Parse(txtCodigoPago.Text),
               FK,
               FK2,
               datetimeFechaPago.Value,
               cboxTipoPago.Text,
               txtBanco.Text,
               cboxEstado.Text);

                MessageBox.Show("Pago actualizado correctamente.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void datetimeFechaPago_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxCodigoPasajero_Click(object sender, EventArgs e)
        {
            MtdMostrarFK();
        }

        private void cbxCodigoTarifa_Click(object sender, EventArgs e)
        {
            MtdMostrarFK2();
        }
    }
}
