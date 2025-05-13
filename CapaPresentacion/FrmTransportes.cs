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
    public partial class FrmTransportes : Form
    {

        CD_Transportes cd_transportes = new CD_Transportes();
        public FrmTransportes()
        {
            InitializeComponent();
        }

        public void MtdMostrarTransportes()
        {
            DataTable dt = cd_transportes.MtMostrarTransportes();
            dgvTransportes.DataSource = dt;
        }

        private void MtdLimpiarCampos()
        {
            txtCodigo.Text = "";
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAño.Text = "";
            txtCapacidad.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MtdMostrarTransportes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
               cd_transportes.MtInsertarTransporte(
               txtPlaca.Text,
               txtMarca.Text,
               txtModelo.Text,
               int.Parse(txtAño.Text),
               int.Parse(txtCapacidad.Text),
               cmbEstado.Text
           );
                MessageBox.Show("El Transporte se agregó con éxito","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MtdLimpiarCampos();
                MtdMostrarTransportes();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
       }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvTransportes.SelectedCells[0].Value.ToString();
            txtPlaca.Text = dgvTransportes.SelectedCells[1].Value.ToString();
            txtMarca.Text = dgvTransportes.SelectedCells[2].Value.ToString();
            txtModelo.Text = dgvTransportes.SelectedCells[3].Value.ToString();
            txtAño.Text = dgvTransportes.SelectedCells[4].Value.ToString();
            txtCapacidad.Text = dgvTransportes.SelectedCells[5].Value.ToString();
            cmbEstado.Text = dgvTransportes.SelectedCells[6].Value.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

           try
          {
                cd_transportes.MtActualizarTransporte(
               int.Parse(txtCodigo.Text),
               txtPlaca.Text,
               txtMarca.Text,
               txtModelo.Text,
               int.Parse(txtAño.Text),
               int.Parse(txtCapacidad.Text),
               cmbEstado.Text
           );
                MessageBox.Show("El Transporte se actualizó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();
                MtdMostrarTransportes();
          }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                cd_transportes.MtEliminarTransporte(int.Parse(txtCodigo.Text));
                MessageBox.Show("El cliente se eliminó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();
                MtdMostrarTransportes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }
}
