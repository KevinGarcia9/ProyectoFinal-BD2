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
            HOR.mtdAgregarHorario(
                int.Parse(txtCodigoEstacion.Text),
                TimeSpan.Parse(datetimeHoraSalida.Text),
                TimeSpan.Parse(datetimeHoraLLegada.Text),
                datetimeFechaInicio.Value,
                datetimeFechaFin.Value,
                cboxEstado.Text
            );
            MessageBox.Show("Horario agregado.");
            Refresh();
        }

        private void btnActualizarHrs_Click(object sender, EventArgs e)
        {
            HOR.mtdActualizarHorario(
              int.Parse(txtCodigoHorario.Text),
              int.Parse(txtCodigoEstacion.Text),
              TimeSpan.Parse(datetimeHoraSalida.Text),
              TimeSpan.Parse(datetimeHoraLLegada.Text),
              datetimeFechaInicio.Value,
              datetimeFechaFin.Value,
              cboxEstado.Text
          );
            MessageBox.Show("Horario actualizado.");
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            HOR.mtdEliminarHorario(int.Parse(txtCodigoHorario.Text));
            MessageBox.Show("Horario eliminado.");
            Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvHorarios.DataSource = HOR.BuscarHorarios(int.Parse(txtCodigoEstacion.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
