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
    public partial class FrmConductores : Form
    {
        public FrmConductores()
        {
            InitializeComponent();
        }

        CD_Conductores cd_conductores = new CD_Conductores();
        private void MtdMostrarConductores()
        {
            DataTable tabla = cd_conductores.MtMostrarConductores();
            dgvConductores.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtLicencia.Text = "";
            txtTelefono.Text = "";
            txtFechaContratacion.Text = "";
            txtDireccion.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void FrmConductores_Load(object sender, EventArgs e)
        {
            MtdMostrarConductores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_conductores.MtInsertarConductor(
                    txtNombre.Text,
                    txtLicencia.Text,
                    txtTelefono.Text,
                    txtFechaContratacion.Text,
                    txtDireccion.Text,
                    cmbEstado.Text
                );
                MessageBox.Show("El Conductor se agregó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarConductores();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_conductores.MtActualizarConductor(
                    int.Parse(txtCodigo.Text),
                    txtNombre.Text,
                    txtLicencia.Text,
                    txtTelefono.Text,
                    txtFechaContratacion.Text,
                    txtDireccion.Text,
                    cmbEstado.Text
                );
                MessageBox.Show("!Actualización Exitosa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarConductores();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_conductores.MtEliminarConductor(int.Parse(txtCodigo.Text));
                MessageBox.Show("!Eliminación completa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarConductores();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvConductores.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["CodigoConductor"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtLicencia.Text = fila.Cells["Licencia"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtFechaContratacion.Text = fila.Cells["FechaContratacion"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }
    }
}
