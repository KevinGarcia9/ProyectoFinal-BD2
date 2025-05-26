using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmHorarios : Form
    {
        CD_Horarios HOR = new CD_Horarios();

        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                HOR.mtdAgregarHorario(
                  int.Parse(txtCodigoEstacion.Text),
                  TimeSpan.Parse(datetimeHoraSalida.Text),
                  TimeSpan.Parse(datetimeHoraLLegada.Text),
                  datetimeFechaInicio.Value,
                  datetimeFechaFin.Value,
                  cboxEstado.Text);

                MessageBox.Show("Horario agregado.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgvHorarios.Rows[e.RowIndex];
                txtCodigoHorario.Text = fila.Cells["CodigoHorario"].Value.ToString();
                txtCodigoEstacion.Text = fila.Cells["CodigoEstacion"].Value.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value.ToString();
                datetimeHoraLLegada.Text = fila.Cells["HoraLlegada"].Value.ToString();
                datetimeHoraSalida.Text = fila.Cells["HoraSalida"].Value.ToString();
                datetimeFechaFin.Text = fila.Cells["FechaFin"].Value.ToString();
                datetimeFechaInicio.Text = fila.Cells["FechaInicio"].Value.ToString();
            }
        }
        private void CargarPagos()
        {
            dtgvHorarios.DataSource = HOR.mtdMostrarHorarios();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigoEstacion.Text))
            {
                dtgvHorarios.DataSource = HOR.mtdMostrarHorarios(); 
            }
            else
            {
                int codigoEstacion;
                if (int.TryParse(txtCodigoEstacion.Text, out codigoEstacion))
                {
                    dtgvHorarios.DataSource = HOR.BuscarHorarios(codigoEstacion);
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido para el código de estación.");
                }
            }
        }

        private void btnActualizarHrs_Click_1(object sender, EventArgs e)
        {
            try
            {
              HOR.mtdActualizarHorario(
              int.Parse(txtCodigoHorario.Text),
              int.Parse(txtCodigoEstacion.Text),
              TimeSpan.Parse(datetimeHoraSalida.Text),
              TimeSpan.Parse(datetimeHoraLLegada.Text),
              datetimeFechaInicio.Value,
              datetimeFechaFin.Value,
              cboxEstado.Text);

                MessageBox.Show("Horario actualizado.");
                CargarPagos();
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
                HOR.mtdEliminarHorario(int.Parse(txtCodigoHorario.Text));
                MessageBox.Show("Horario eliminado.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
