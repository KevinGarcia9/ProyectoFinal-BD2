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
    public partial class FrmEstaciones : Form
    {
        public FrmEstaciones()
        {
            InitializeComponent();
        }

        
        CD_Estaciones cd_estaciones = new CD_Estaciones();

        private void MtdMostrarRut()
        {
            CD_Conexion db_conexion = new CD_Conexion();

            SqlCommand cmd = new SqlCommand("SELECT CodigoRuta, Nombre, Origen, Destino,Estado FROM Rutas ", db_conexion.MtdAbrirConexion() );
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                // Agrega columna para visualización combinada
                dt.Columns.Add("DescripcionRuta", typeof(string), "CodigoRuta + ' - ' + Nombre + ' (' + Origen + ' - ' + Destino + ')' + ' ' + Estado");

                cbxCodigoRuta.DataSource = dt;
                cbxCodigoRuta.DisplayMember = "DescripcionRuta";
                cbxCodigoRuta.ValueMember = "CodigoRuta";
            
        }


        private void MtdMostrarEstaciones()
        {
            DataTable tabla = cd_estaciones.MtMostrarEstaciones();
            dgvEstaciones.DataSource = tabla;
        }

        private void MtdLimpiarCampos()
        {
            txtCodigo.Text = "";
           
            cbxCodigoRuta.SelectedIndex = -1; 
            txtNombre.Text = "";
            txtUbicacion.Text = "";
            txtSecuencia.Text = "";
            txtTiempoEspera.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void FrmEstaciones_Load_1(object sender, EventArgs e)
        {
            MtdMostrarEstaciones();
            MtdMostrarRut();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCodigoRuta.SelectedIndex == 0 || cbxCodigoRuta.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Debe seleccionar una ruta válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxCodigoRuta.Focus();
                    return;
                }

                int codigoruta = Convert.ToInt32(cbxCodigoRuta.SelectedValue.ToString());
                int secuencia = int.Parse(txtSecuencia.Text);
                int tiempoEspera = int.Parse(txtTiempoEspera.Text);

                cd_estaciones.MtInsertarEstacion(
                    codigoruta,
                    txtNombre.Text,
                    txtUbicacion.Text,
                    secuencia,
                    tiempoEspera,
                    cmbEstado.Text
                );
                MessageBox.Show("!Guardado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigoEstacion = int.Parse(txtCodigo.Text);
                int codigoruta = Convert.ToInt32(cbxCodigoRuta.SelectedValue.ToString());
                int secuencia = int.Parse(txtSecuencia.Text);
                int tiempoEspera = int.Parse(txtTiempoEspera.Text);

                cd_estaciones.MtActualizarEstacion(
                    codigoEstacion,
                    codigoruta,
                    txtNombre.Text,
                    txtUbicacion.Text,
                    secuencia,
                    tiempoEspera,
                    cmbEstado.Text
                );
                MessageBox.Show("!Actualizado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
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
                int codigoEstacion = int.Parse(txtCodigo.Text);
                cd_estaciones.MtEliminarEstacion(codigoEstacion);
                MessageBox.Show("!Eliminado Completado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEstaciones();
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

        private void dgvEstaciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEstaciones.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["CodigoEstacion"].Value.ToString();
                
                cbxCodigoRuta.Text = fila.Cells["CodigoRuta"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUbicacion.Text = fila.Cells["Ubicación"].Value.ToString();
                txtSecuencia.Text = fila.Cells["Secuencia"].Value.ToString();
                txtTiempoEspera.Text = fila.Cells["TiempoEspera"].Value.ToString();
                cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void cbxCodigoRuta_Click(object sender, EventArgs e)
        {
            MtdMostrarRut();
        }

        private void gboxEstaciones_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MtdMostrarEstaciones(); // Si no hay búsqueda, recarga todo
            }
            else
            {
                DataTable dt = cd_estaciones.MtBuscar(criterio);
                dgvEstaciones.DataSource = dt;
            }
        }
    }
}
