using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TarjetasDeTransporte
    {
        CD_Conexion db_conexion = new CD_Conexion();
        public DataTable MtMostrarTarjetadeTransporte()
        {
            string Qry = "Usp_TarjeradeTransporte_Buscar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public void MtInsertarTarjetadeTransporte (int CodigoPasajero, string FechaEmision, decimal Saldo,string Moneda, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_TarjetadeTransporte_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", CodigoPasajero);
            cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarTarjetadeTransporte(int CodigoTarjeta,int CodigoPasajero, string FechaEmision, decimal Saldo, string Moneda, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_TarjetadeTransporte_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarjeta", CodigoTarjeta);
            cmd.Parameters.AddWithValue("@CodigoPasajero", CodigoPasajero);
            cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.Clear();
        }

        public void MtEliminarTarjetadeTransporte(int CodigoTarjeta)
        {
            SqlCommand cmd = new SqlCommand("Usp_TarjetadeTransporte_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarjeta", CodigoTarjeta);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
