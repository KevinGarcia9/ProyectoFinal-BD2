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
    public partial class FormTarjetasdetransportes : Form
    {
        public FormTarjetasdetransportes()
        {
            InitializeComponent();
            
        }


        CD_TarjetasDeTransporte cd_tarjetadetransporte = new CD_TarjetasDeTransporte();


        private void MtdMostrarFK()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("select CodigoPasajero,Nombre,Nit,Estado from Pasajeros", db_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            // Agrega columna para visualización combinada
            dt.Columns.Add("Descripcion", typeof(string), "CodigoPasajero + ' - ' + Nombre + ' - ' + Nit + ' - ' + Estado");

            cbxCodigoPasajero.DataSource = dt;
            cbxCodigoPasajero.DisplayMember = "Descripcion";
            cbxCodigoPasajero.ValueMember = "CodigoPasajero";

        }

        private void MtMostrarTarjetadeTransporte()
        {
            DataTable tabla = cd_tarjetadetransporte.MtMostrarTarjetadeTransporte();
            dataGridView1.DataSource = tabla;
        }
        private void MtdLimpiarCampos()
            
        {
            txtcodigotarjeta.Text = "";
            cbxCodigoPasajero.Text = "";
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
                txtcodigotarjeta.Text = fila.Cells["CodigoTarjeta"].Value.ToString();
                cbxCodigoPasajero.Text = fila.Cells["CodigoPasajero"].Value.ToString();
                txtfechaemision.Text = fila.Cells["FechaEmision"].Value.ToString();
                txtsaldo.Text = fila.Cells["Saldo"].Value.ToString();
                txtmoneda.Text = fila.Cells["Moneda"].Value.ToString();
                txttipodetarjeta.Text = fila.Cells["TipoTarjeta"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void FormTarjetasdetransportes_Load(object sender, EventArgs e)
        {
            MtMostrarTarjetadeTransporte();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int FK = Convert.ToInt32(cbxCodigoPasajero.SelectedValue.ToString());

            try
            {
                cd_tarjetadetransporte.MtInsertarTarjetadeTransporte(
                FK,
                DateTime.Parse( txtfechaemision.Text),
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
            int FK = Convert.ToInt32(cbxCodigoPasajero.SelectedValue.ToString());

            try
            {
                cd_tarjetadetransporte.MtActualizarTarjetadeTransporte(
                    int.Parse(txtcodigotarjeta.Text),
                  FK,
                  DateTime.Parse(txtfechaemision.Text),
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtcodigotarjeta.Text))
            {
                dataGridView1.DataSource = cd_tarjetadetransporte.MtMostrarTarjetadeTransporte();
            }
            else
            {
                int CodigoIncidente;
                if (int.TryParse(txtcodigotarjeta.Text, out CodigoIncidente))
                {
                    dataGridView1.DataSource = cd_tarjetadetransporte.mtdBuscarTarjetadetranspote (CodigoIncidente);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido para el código de tarjeta de transporte.");
                }
            }
        }

        private void cbxCodigoPasajero_Click(object sender, EventArgs e)
        {
            MtdMostrarFK();
        }
    }
}
