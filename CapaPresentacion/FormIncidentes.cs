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
    public partial class FormIncidentes : Form
    {
        public FormIncidentes()
        {
            InitializeComponent();
            
        }




        CD_Incidentes cd_incidentes = new CD_Incidentes();


        private void MtdMostrarFK()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoTransporte,Placa,Marca,Estado from Transportes", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoTransporte + ' - ' + Placa + ' - ' + Marca + ' - ' + Estado");

            cbxCodigoTransporte.DataSource = dt;
            cbxCodigoTransporte.DisplayMember = "Descripcion";
            cbxCodigoTransporte.ValueMember = "CodigoTransporte";

        }

        private void MtdMostrarFK2()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoConductor, Nombre,Licencia,Estado from Conductores", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoConductor + ' - ' + Nombre + ' - ' + Licencia + ' - ' + Estado");

            cbxCodigoConductor.DataSource = dt;
            cbxCodigoConductor.DisplayMember = "Descripcion";
            cbxCodigoConductor.ValueMember = "CodigoConductor";

        }



        private void MtdMostrarIncidentes()
        {
            DataTable tabla = cd_incidentes.MtMostrarIncidentes();
            dgvincidentes.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtcodigoincidente.Text = "";

            cbxCodigoTransporte.Text = "";
            cbxCodigoConductor.Text = "";
            txtdescripcion.Text = "";
            txtfecha.Text = "";
            txthora.Text = "";
            cmbestado.SelectedIndex = -1;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            int FK = Convert.ToInt32(cbxCodigoTransporte.SelectedValue.ToString());
            int FK2 = Convert.ToInt32(cbxCodigoConductor.SelectedValue.ToString());

            try
            {
                cd_incidentes.MtInsertarIncidentes(
                    FK,
                    FK2,
                    txtdescripcion.Text,
                  DateTime.Parse(  txtfecha.Text),
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
            int FK = Convert.ToInt32(cbxCodigoTransporte.SelectedValue.ToString());
            int FK2 = Convert.ToInt32(cbxCodigoConductor.SelectedValue.ToString());


            try
            {
                cd_incidentes.MtActualizarIncidentes(
                    int.Parse(txtcodigoincidente.Text),
                    FK,
                    FK2,
                    txtdescripcion.Text,
                   DateTime.Parse( txtfecha.Text),
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

        private void dgvincidentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvincidentes.Rows[e.RowIndex];
                txtcodigoincidente.Text = fila.Cells["CodigoIncidente"].Value.ToString();

                cbxCodigoTransporte.Text = fila.Cells["CodigoTransporte"].Value.ToString();
                cbxCodigoConductor.Text = fila.Cells["CodigoConductor"].Value.ToString();
                txtdescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                txtfecha.Text = fila.Cells["Fecha"].Value.ToString();
                txthora.Text = fila.Cells["Hora"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtcodigoincidente.Text))
            {
                dgvincidentes.DataSource = cd_incidentes.MtMostrarIncidentes ();
            }
            else
            {
                int CodigoIncidente;
                if (int.TryParse(txtcodigoincidente.Text, out CodigoIncidente))
                {
                    dgvincidentes.DataSource = cd_incidentes.mtdBuscarIncidentes(CodigoIncidente);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido para el código de incidente.");
                }
            }
        }

        private void cbxCodigoTransporte_Click(object sender, EventArgs e)
        {
            MtdMostrarFK();
        }

        private void cbxCodigoConductor_Click(object sender, EventArgs e)
        {
            MtdMostrarFK2();
        }
    }

}

