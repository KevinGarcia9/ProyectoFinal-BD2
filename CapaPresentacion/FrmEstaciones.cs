using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmEstaciones : Form
    {
        public FrmEstaciones()
        {
            InitializeComponent();
        }

        CD_Estaciones cd_estaciones = new CD_Estaciones();

        private void MtdMostrarEstaciones()
        {
            DataTable tabla = cd_estaciones.MtMostrarEstaciones();
            dgvEstaciones.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtCodigoRuta.Text = "";
            txtNombre.Text = "";
            txtUbicacion.Text = "";
            txtSecuencia.Text = "";
            txtTiempoEspera.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void FrmEstaciones_Load_1(object sender, EventArgs e)
        {
            MtdMostrarEstaciones();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoRuta = int.Parse(txtCodigoRuta.Text);
                int secuencia = int.Parse(txtSecuencia.Text);
                int tiempoEspera = int.Parse(txtTiempoEspera.Text);

                cd_estaciones.MtInsertarEstacion(
                    codigoRuta,
                    txtNombre.Text,
                    txtUbicacion.Text,
                    secuencia,
                    tiempoEspera,
                    cmbEstado.Text
                );
                MessageBox.Show("!Guardado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigoEstacion = int.Parse(txtCodigo.Text);
                int codigoRuta = int.Parse(txtCodigoRuta.Text);
                int secuencia = int.Parse(txtSecuencia.Text);
                int tiempoEspera = int.Parse(txtTiempoEspera.Text);

                cd_estaciones.MtActualizarEstacion(
                    codigoEstacion,
                    codigoRuta,
                    txtNombre.Text,
                    txtUbicacion.Text,
                    secuencia,
                    tiempoEspera,
                    cmbEstado.Text
                );
                MessageBox.Show("!Actualizado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
                MtdLimpiarCampos();
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
                int codigoEstacion = int.Parse(txtCodigo.Text);
                cd_estaciones.MtEliminarEstacion(codigoEstacion);
                MessageBox.Show("!Eliminado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void dgvEstaciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEstaciones.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["CodigoEstacion"].Value.ToString();
                txtCodigoRuta.Text = fila.Cells["CodigoRuta"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUbicacion.Text = fila.Cells["Ubicación"].Value.ToString();
                txtSecuencia.Text = fila.Cells["Secuencia"].Value.ToString();
                txtTiempoEspera.Text = fila.Cells["TiempoEspera"].Value.ToString();
                cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }
    }
}
