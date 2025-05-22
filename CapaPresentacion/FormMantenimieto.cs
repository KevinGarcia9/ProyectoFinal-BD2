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
    public partial class FormMantenimieto : Form
    {
        public FormMantenimieto()
        {
            InitializeComponent();
        }

        CD_Mantenimiento cd_mantenimiento = new CD_Mantenimiento();
        private void MtdMostrarMantenimiento()
        {
            DataTable tabla = cd_mantenimiento.MtMostrarManteniminento();
            dgvmatenimiento.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtcodigomant.Text = "";
            txtcodigotransp.Text = "";
            txtfechaingreso.Text = "";
            txtfechasalida.Text = "";
            txtcosto.Text = "";
            txtmoneda.Text = "";
            cmbestado.SelectedIndex = -1;
        }
        private void FormMantenimieto_Load(object sender, EventArgs e)
        {
            MtdMostrarMantenimiento();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {


                cd_mantenimiento.MtInsertarMantenimiento(
                 int.Parse(txtcodigotransp.Text),
                    txtfechaingreso.Text,
                    txtfechasalida.Text,
                   decimal.Parse(txtcosto.Text),
                    txtmoneda.Text,
                    cmbestado.Text
                );
                MessageBox.Show(" Mantenimiento se agregó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarMantenimiento();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_mantenimiento.MtActualizarMantenimiento(
                    int.Parse(txtcodigomant.Text),
                   int.Parse(txtcodigotransp.Text),
                    txtfechaingreso.Text,
                    txtfechasalida.Text,
                    decimal.Parse(txtcosto.Text),
                    txtmoneda.Text,
                    cmbestado.Text
                );
                MessageBox.Show("!Actualización Exitosa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarMantenimiento();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_mantenimiento.MtEliminarMantenimiento(int.Parse(txtcodigomant.Text));
                MessageBox.Show("!Eliminación completa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarMantenimiento();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void dgvmatenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvmatenimiento.Rows[e.RowIndex];
                txtcodigomant.Text = fila.Cells["CodigoMantenimiento"].Value.ToString();
                txtcodigotransp.Text = fila.Cells["CodigoTransporte"].Value.ToString();
                txtfechaingreso.Text = fila.Cells["Fecha Ingreso"].Value.ToString();
                txtfechasalida.Text = fila.Cells["Fecha Salida"].Value.ToString();
                txtcosto.Text = fila.Cells["Costo"].Value.ToString();
                txtmoneda.Text = fila.Cells["Moneda"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
