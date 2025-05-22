using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Estadisticas
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarEstadisticas()
        {
            string Qry = "Usp_Estadisticas_Buscar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public void MtInsertarEstadistica(string FechaReporte, int pasajeros, decimal IngresoTotal, string Moneda, int TotalIncidentes, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Estadisticas_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FechaReporte", FechaReporte);
            cmd.Parameters.AddWithValue("@pasajeros", pasajeros);
            cmd.Parameters.AddWithValue("@IngresoTotal", IngresoTotal);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@TotalIncidentes", TotalIncidentes);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarEstadistica(int codigo, string FechaReporte, int pasajeros, decimal IngresoTotal, string Moneda, int TotalIncidentes, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Estadisticas_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            cmd.Parameters.AddWithValue("@FechaReporte", FechaReporte);
            cmd.Parameters.AddWithValue("@pasajeros", pasajeros);
            cmd.Parameters.AddWithValue("@IngresoTotal", IngresoTotal);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@TotalIncidentes", TotalIncidentes);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarEstadistica(int codigo)
        {
            SqlCommand cmd = new SqlCommand("Usp_Estadisticas_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

    }
}
