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
    public partial class FormIncidentes : Form
    {
        public FormIncidentes()
        {
            InitializeComponent();
        }


        CD_Incidentes cd_incidentes = new CD_Incidentes();
        private void MtdMostrarIncidentes()
        {
            DataTable tabla = cd_incidentes.MtMostrarIncidentes();
            dgvincidentes.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtcodigoincidente.Text = "";
            txtcodigotransporte.Text = "";
            txtcodigoconductor.Text = "";
            txtdescripcion.Text = "";
            txtfecha.Text = "";
            txthora.Text = "";
            cmbestado.SelectedIndex = -1;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                cd_incidentes.MtInsertarIncidentes(
                  int.Parse(  txtcodigotransporte.Text),
                   int.Parse( txtcodigoconductor.Text),
                    txtdescripcion.Text,
                    txtfecha.Text,
                    txthora.Text,
                    cmbestado.Text
                );
                MessageBox.Show("Incidente agregado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarIncidentes();
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
                cd_incidentes.MtActualizarIncidentes(
                    int.Parse(txtcodigoincidente.Text),
                 int.Parse(  txtcodigotransporte.Text),
                    int.Parse(txtcodigoconductor.Text),
                    txtdescripcion.Text,
                    txtfecha.Text,
                    txthora.Text,
                    cmbestado.Text
                );
                MessageBox.Show("!Actualización Exitosa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarIncidentes();
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
                cd_incidentes.MtEliminarIncidentes(int.Parse(txtcodigoincidente.Text));
                MessageBox.Show("!Eliminación completa!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarIncidentes();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void FormIncidentes_Load(object sender, EventArgs e)
        {
            MtdMostrarIncidentes();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }

}
    

