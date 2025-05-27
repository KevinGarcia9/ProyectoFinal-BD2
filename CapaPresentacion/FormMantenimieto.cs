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

        private void MtdMostrarFK()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoTransporte,Placa,Marca,Estado from Transportes", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoTransporte + ' - ' + Placa + ' - ' + Marca + ' - ' + Estado");

            cbxCodigoTrasnp.DataSource = dt;
            cbxCodigoTrasnp.DisplayMember = "Descripcion";
            cbxCodigoTrasnp.ValueMember = "CodigoTransporte";

        }




        private void MtdMostrarMantenimiento()
        {
            DataTable tabla = cd_mantenimiento.MtMostrarManteniminento();
            dgvmatenimiento.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtcodigomant.Text = "";
            
            cbxCodigoTrasnp.Text = "";
            txtfechaingreso.Text = "";
            txtfechasalida.Text = "";
            txtcosto.Text = "";
            txtmoneda.Text = "";
            cmbestado.SelectedIndex = -1;
            cmbestado.ResetText();
        }
        private void FormMantenimieto_Load(object sender, EventArgs e)
        {
            MtdMostrarMantenimiento();
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            int FK = Convert.ToInt32(cbxCodigoTrasnp.SelectedValue.ToString());

            try
            {
                cd_mantenimiento.MtActualizarMantenimiento(
                    int.Parse(txtcodigomant.Text),
                   FK,
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


        private void button1_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void dgvmatenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvmatenimiento.Rows[e.RowIndex];
                txtcodigomant.Text = fila.Cells["CodigoMant"].Value.ToString();
              
                cbxCodigoTrasnp.Text = fila.Cells["CodigoTransporte"].Value.ToString();
                txtfechaingreso.Text = fila.Cells["FechaIngreso"].Value.ToString();
                txtfechasalida.Text = fila.Cells["FechaSalida"].Value.ToString();
                txtcosto.Text = fila.Cells["Costo"].Value.ToString();
                txtmoneda.Text = fila.Cells["Moneda"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            int FK = Convert.ToInt32(cbxCodigoTrasnp.SelectedValue.ToString());

            try
            {


                cd_mantenimiento.MtInsertarMantenimiento(
                    FK,
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtcodigomant.Text))
            {
                dgvmatenimiento.DataSource = cd_mantenimiento.MtMostrarManteniminento();
            }
            else
            {
                int CodigoMant;
                if (int.TryParse(txtcodigomant.Text, out CodigoMant))
                {
                    dgvmatenimiento.DataSource = cd_mantenimiento.mtdBuscarMantenimiento(CodigoMant);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido para el código de mantenimiento.");
                }
            }
        }

        private void cbxCodigoTrasnp_Click(object sender, EventArgs e)
        {
            MtdMostrarFK();
        }
    }
}