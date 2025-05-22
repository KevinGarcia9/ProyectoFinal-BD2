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
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }
        CD_Estadisticas cd_estadisticas = new CD_Estadisticas();
        private void MtdMostrarEstadistica()
        {
            DataTable tabla = cd_estadisticas.MtMostrarEstadisticas();
            dgvestadisticas.DataSource = tabla;
        }
        private void MtdLimpiarCampos()
        {
            txtcodigo.Text = "";
            txtfechareporte.Text = "";
            txtpasajerostransp.Text = "";
            txtingresototal.Text = "";
            txtmoneda.Text = "";
            txttotalincedentes.Text = "";
            cmbestado.SelectedIndex = -1;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            MtdMostrarEstadistica();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_estadisticas.MtInsertarEstadistica(
                  
                txtfechareporte.Text,
               int.Parse( txtpasajerostransp.Text),
                decimal.Parse(txtingresototal.Text ),
                txtmoneda.Text ,
                int.Parse(txttotalincedentes.Text ),
                cmbestado.Text
                );
                MessageBox.Show("El Campo se agregó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstadistica();
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
                cd_estadisticas.MtActualizarEstadistica(
                    int.Parse(txtcodigo.Text),
                   txtfechareporte.Text,
                int.Parse(  txtpasajerostransp.Text),
                decimal.Parse(txtingresototal.Text),
                txtmoneda.Text,
                int.Parse(txttotalincedentes.Text),
                cmbestado.Text
                );
                MessageBox.Show("!Actualización Exitosa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstadistica();
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
                cd_estadisticas.MtEliminarEstadistica(int.Parse(txtcodigo.Text));
                MessageBox.Show("!Eliminación completa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstadistica();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

