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
    public partial class FormTarjetasdetransportes : Form
    {
        public FormTarjetasdetransportes()
        {
            InitializeComponent();
        }
        CD_TarjetasDeTransporte cd_tarjetadetransporte = new CD_TarjetasDeTransporte();
        private void MtMostrarTarjetadeTransporte()
        {
            DataTable tabla = cd_tarjetadetransporte.MtMostrarTarjetadeTransporte();
            dataGridView1.DataSource = tabla;
        }
        private void MtdLimpiarCampos()
            
        {
            txtcodigotarjeta.Text = "";
            txtcodigopasajero.Text = "";
            txtfechaemision.Text = "";
            txtsaldo.Text = "";
            txtmoneda.Text = "";
            txttipodetarjeta.Text = "";
            cmbestado.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtcodigotarjeta.Text = fila.Cells["CodigoIncidente"].Value.ToString();
                txtcodigopasajero.Text = fila.Cells["CodigoTransporte"].Value.ToString();
                txtfechaemision.Text = fila.Cells["CodigoConductor"].Value.ToString();
                txtsaldo.Text = fila.Cells["Descripcion"].Value.ToString();
                txtmoneda.Text = fila.Cells["Fecha"].Value.ToString();
                txttipodetarjeta.Text = fila.Cells["Hora"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void FormTarjetasdetransportes_Load(object sender, EventArgs e)
        {
            MtMostrarTarjetadeTransporte();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_tarjetadetransporte.MtInsertarTarjetadeTransporte(
                int.Parse(txtcodigopasajero.Text),
                txtfechaemision.Text,
                decimal.Parse(txtsaldo.Text),
                txtmoneda.Text,
                 txttipodetarjeta.Text,    
                cmbestado.Text
                );
                MessageBox.Show("El Campo se agregó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtMostrarTarjetadeTransporte();
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
                cd_tarjetadetransporte.MtActualizarTarjetadeTransporte(
                    int.Parse(txtcodigotarjeta.Text),
                  int.Parse(txtcodigopasajero.Text),
                txtfechaemision.Text,
                decimal.Parse(txtsaldo.Text),
                txtmoneda.Text,
                 txttipodetarjeta.Text,
                cmbestado.Text
                
                );
                MessageBox.Show("!Actualización Exitosa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtMostrarTarjetadeTransporte();
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
                cd_tarjetadetransporte.MtEliminarTarjetadeTransporte(int.Parse(txtcodigotarjeta.Text));
                MessageBox.Show("!Eliminación completa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtMostrarTarjetadeTransporte();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }
}
