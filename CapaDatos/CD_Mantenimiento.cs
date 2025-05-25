using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class CD_Mantenimiento
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarManteniminento()
        {
            string Qry = "Usp_Mantenimiento_Mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
        public DataTable mtdBuscarMantenimiento (int CodigoMant)
        {
            SqlCommand cmd = new SqlCommand("Usp_Mantenimiento_Buscar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoMant", CodigoMant);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            da.Fill(tabla);
            return tabla;
        }

        public void MtInsertarMantenimiento( int Codigotransporte,string FechaIngreso, string FechaSalida, decimal Costo, string Moneda, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Mantenimiento_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTransporte", Codigotransporte);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarMantenimiento (int CodigoMant, int CodigoTransporte, string FechaIngreso, string FechaSalida, decimal Costo, string Moneda, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Mantenimiento_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoMant", CodigoMant);
            cmd.Parameters.AddWithValue("@CodigoTransporte", CodigoTransporte);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarMantenimiento(int CodigoMant)
        {
            SqlCommand cmd = new SqlCommand("Usp_Mantenimiento_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoMant", CodigoMant);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
