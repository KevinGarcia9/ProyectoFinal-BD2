using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Pagos
    {
        //private SqlConnection conexion = new SqlConnection("Server=DESKTOP-9QF8HLG\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");
        CD_Conexion db_conexion = new CD_Conexion();


        public void mtdAgregarPago(int codigoPasajero, int codigoTarifa, DateTime fechaPago, string tipoPago, string banco, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Agregar_Pagos", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoPasajero", codigoPasajero);
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
            cmd.Parameters.AddWithValue("@TipoPago", tipoPago);
            cmd.Parameters.AddWithValue("@Banco", banco);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdActualizarPago(int codigoPago, int codigoPasajero, int codigoTarifa, DateTime fechaPago, string tipoPago, string banco, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Pagos", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoPago", codigoPago);
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigoPasajero);
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
            cmd.Parameters.AddWithValue("@TipoPago", tipoPago);
            cmd.Parameters.AddWithValue("@Banco", banco);
            cmd.Parameters.AddWithValue("@Estado", estado);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdEliminarPago(int codigoPago)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Pagos", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoPago", codigoPago);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
           
        }

        public DataTable mtdBuscarPagosPorPasajero(int codigoPasajero)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Pagos", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigoPasajero);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();

            da.Fill(tabla);
            return tabla;
        }

        public DataTable mtdMostrarPagos()
        {
            SqlCommand comando = new SqlCommand("Usp_Mostrar_Pagos", db_conexion.MtdAbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            return tabla;
        }

    }
}
