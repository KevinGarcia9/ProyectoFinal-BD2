﻿using System;
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

            // Llenar ComboBox con campos válidos
            cbxbuscarpor.Items.Add("Codigo");
            cbxbuscarpor.Items.Add("FechaReporte");
            cbxbuscarpor.Items.Add("PasajerosTransportados");
            cbxbuscarpor.Items.Add("IngresoTotal");
            cbxbuscarpor.Items.Add("Moneda");
            cbxbuscarpor.Items.Add("TotalIncidentes");
            cbxbuscarpor.Items.Add("Estado");

            cbxbuscarpor.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_estadisticas.MtInsertarEstadistica(
                  
                DateTime.Parse( txtfechareporte.Text),
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
                   DateTime.Parse(txtfechareporte.Text),
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

        private void dgvestadisticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvestadisticas.Rows[e.RowIndex];
                txtcodigo.Text = fila.Cells["Codigo"].Value.ToString();
                txtfechareporte.Text = fila.Cells["FechaReporte"].Value.ToString();
                txtpasajerostransp.Text = fila.Cells["PasajerosTransportados"].Value.ToString();
                txtingresototal.Text = fila.Cells["IngresoTotal"].Value.ToString();
                txtmoneda.Text = fila.Cells["Moneda"].Value.ToString();
                txttotalincedentes.Text = fila.Cells["TotalIncidentes"].Value.ToString();
                cmbestado.Text = fila.Cells["Estado"].Value.ToString();
            }
           
        }

        private void dgvestadisticas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)

        {
            string campo = cbxbuscarpor.SelectedItem.ToString();
            string valor = txtbuscarvalor.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                MtdMostrarEstadistica(); // Mostrar todo si está vacío
            }
            else
            {
                DataTable resultado = cd_estadisticas.mtdBuscarEstadisticas(campo, valor);
                dgvestadisticas.DataSource = resultado;
            }
           
        }
        /* {


             if (string.IsNullOrWhiteSpace(txtcodigo.Text))
             {
                 dgvestadisticas.DataSource = cd_estadisticas.MtMostrarEstadisticas();
             }
             else
             {
                 int Codigo;
                 if (int.TryParse(txtcodigo.Text, out Codigo))
                 {
                     dgvestadisticas.DataSource = cd_estadisticas.mtdBuscarEstadisticas(Codigo);
                 }
                 else
                 {
                     MessageBox.Show("Por favor ingresa un número válido para el código de estadisticas.");
                 }
             }
     }*/
    }

}
