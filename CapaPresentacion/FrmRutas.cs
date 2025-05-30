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
    public partial class FrmRutas : Form
    {
        public FrmRutas()
        {
            InitializeComponent();
        }

        CD_Rutas cd_rutas = new CD_Rutas();

        private void MtdMostrarRutas()
        {
            DataTable tabla = cd_rutas.MtMostrarRutas();
            dgvRutas.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtDistancia.Text = "";
            cmbTipoRuta.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal distancia;
                if (!decimal.TryParse(txtDistancia.Text, out distancia))
                {
                    MessageBox.Show("La distancia debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cd_rutas.MtInsertarRuta(
                    txtNombre.Text,
                    txtOrigen.Text,
                    txtDestino.Text,
                    distancia,
                    cmbTipoRuta.Text,
                    cmbEstado.Text
                );
                MessageBox.Show("!Guardad Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarRutas();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void FrmRutas_Load_1(object sender, EventArgs e)
        {
            MtdMostrarRutas();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal distancia;
                if (!decimal.TryParse(txtDistancia.Text, out distancia))
                {
                    MessageBox.Show("La distancia debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cd_rutas.MtActualizarRuta(
                    int.Parse(txtCodigo.Text),
                    txtNombre.Text,
                    txtOrigen.Text,
                    txtDestino.Text,
                    distancia,
                    cmbTipoRuta.Text,
                    cmbEstado.Text
                );
                MessageBox.Show("!Actualización Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarRutas();
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
                cd_rutas.MtEliminarRuta(int.Parse(txtCodigo.Text));
                MessageBox.Show("!Eliminado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarRutas();
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

        private void dgvRutas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRutas.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["CodigoRuta"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtOrigen.Text = fila.Cells["Origen"].Value.ToString();
                txtDestino.Text = fila.Cells["Destino"].Value.ToString();
                txtDistancia.Text = fila.Cells["Distancia"].Value.ToString();
                cmbTipoRuta.Text = fila.Cells["TipoRuta"].Value.ToString();
                cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MtdMostrarRutas(); // Si no hay búsqueda, recarga todo
            }
            else
            {
                DataTable dt = cd_rutas.MtBuscar(criterio);
                dgvRutas.DataSource = dt;
            }
        }
    }
}
