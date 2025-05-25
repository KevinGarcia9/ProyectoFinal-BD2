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
            string Qry = "Usp_TarjetadeTrasporte_Mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public void MtInsertarTarjetadeTransporte (int CodigoPasajero, DateTime FechaEmision, decimal Saldo,string Moneda,string TipoTarjeta, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Tarjetas_de_transporte_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", CodigoPasajero);
            cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@TipoTarjeta", TipoTarjeta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarTarjetadeTransporte(int CodigoTarjeta,int CodigoPasajero, DateTime FechaEmision, decimal Saldo, string Moneda,string TipoTarjeta, string Estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_TarjetadeTrasporte_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarjeta", CodigoTarjeta);
            cmd.Parameters.AddWithValue("@CodigoPasajero", CodigoPasajero);
            cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);
            cmd.Parameters.AddWithValue("@Moneda", Moneda);
            cmd.Parameters.AddWithValue("@TipoTarjeta", TipoTarjeta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.Clear();
        }

        public DataTable mtdBuscarTarjetadetranspote (int CodigoTarjeta)
        {
            SqlCommand cmd = new SqlCommand("Usp_Tarjetadetransporte_Buscar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarjeta", CodigoTarjeta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            da.Fill(tabla);
            return tabla;
        }

        public void MtEliminarTarjetadeTransporte(int CodigoTarjeta)
        {
            SqlCommand cmd = new SqlCommand("Usp_TarjetadeTrasporte_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarjeta", CodigoTarjeta);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
