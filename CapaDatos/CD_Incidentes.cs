using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Incidentes
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarIncidentes()
        {
            string Qry = "Usp_Incidentes_Buscar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public void MtInsertarIncidentes(int CodigoConductor, int CodigoTransporte, string Descripcion, string Fecha, string Hora, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Incidentes_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTransporte", CodigoTransporte);
            cmd.Parameters.AddWithValue("@CodigoConductor", CodigoConductor);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarIncidentes(int CodigoIncidente,int CodigoTransporte, int CodigoConductor, string Descripcion, string Fecha, string Hora, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Incidentes_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoIncidente", CodigoIncidente);
            cmd.Parameters.AddWithValue("@CodigoTransporte", CodigoTransporte);
            cmd.Parameters.AddWithValue("@CodigoConductor", CodigoConductor);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarIncidentes(int CodigoIncidente)
        {
            SqlCommand cmd = new SqlCommand("Usp_Incidentes_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoIncidente", CodigoIncidente);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

    }
}
