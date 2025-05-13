using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Estaciones
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarEstaciones()
        {
            string Qry = "Alex_Usp_Estaciones_Mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public void MtInsertarEstacion(int codigoRuta, string nombre, string ubicacion, int secuencia, int tiempoEspera, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Estaciones_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Ubicacion", ubicacion);
            cmd.Parameters.AddWithValue("@Secuencia", secuencia);
            cmd.Parameters.AddWithValue("@TiempoEspera", tiempoEspera);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarEstacion(int codigoEstacion, int codigoRuta, string nombre, string ubicacion, int secuencia, int tiempoEspera, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Estaciones_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoEstacion", codigoEstacion);
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Ubicacion", ubicacion);
            cmd.Parameters.AddWithValue("@Secuencia", secuencia);
            cmd.Parameters.AddWithValue("@TiempoEspera", tiempoEspera);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarEstacion(int codigoEstacion)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Estaciones_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoEstacion", codigoEstacion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
