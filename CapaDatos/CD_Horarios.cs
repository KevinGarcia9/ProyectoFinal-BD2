using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class CD_Horarios
    {
        //private SqlConnection conexion = new SqlConnection("Server=DESKTOP-9QF8HLG\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");
        CD_Conexion db_conexion = new CD_Conexion();


        public void mtdAgregarHorario(int codigoEstacion, TimeSpan horaSalida, TimeSpan horaLlegada, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Agregar_Horarios", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEstacion", codigoEstacion);
            cmd.Parameters.AddWithValue("@HoraSalida", horaSalida);
            cmd.Parameters.AddWithValue("@HoraLlegada", horaLlegada);
            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
            cmd.Parameters.AddWithValue("@Estado", estado);

           
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdActualizarHorario(int codigoHorario, int codigoEstacion, TimeSpan horaSalida, TimeSpan horaLlegada, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Horarios", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoHorario", codigoHorario);
            cmd.Parameters.AddWithValue("@CodigoEstacion", codigoEstacion);
            cmd.Parameters.AddWithValue("@HoraSalida", horaSalida);
            cmd.Parameters.AddWithValue("@HoraLlegada", horaLlegada);
            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
            cmd.Parameters.AddWithValue("@Estado", estado);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdEliminarHorario(int codigoHorario)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Horarios", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoHorario", codigoHorario);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
           
        }

        public DataTable BuscarHorarios(int codigoEstacion)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Horarios", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEstacion", codigoEstacion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable mtdMostrarHorarios()
        {
            SqlCommand comando = new SqlCommand("Usp_Mostar_Horarios", db_conexion.MtdAbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
