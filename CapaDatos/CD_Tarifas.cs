using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Tarifas
    {
        private SqlConnection conexion = new SqlConnection("Server=LAPTOP-6PG83GU4\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");

        public void mtdAgregarTarifa(int codigoRuta, decimal monto, string moneda, DateTime fechaVigencia, DateTime fechaVencimiento, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Agregar_Tarifas", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@Moneda", moneda);
            cmd.Parameters.AddWithValue("@FechaVigencia", fechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();
        }

        public void mtdActualizarTarifa(int codigoTarifa, int codigoRuta, decimal monto, string moneda, DateTime fechaVigencia, DateTime fechaVencimiento, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Tarifas", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@Moneda", moneda);
            cmd.Parameters.AddWithValue("@FechaVigencia", fechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();
        }

        public void mtdEliminarTarifa(int codigoTarifa)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Tarifas", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();
        }

        public DataTable mtdBuscarTarifasPorRuta(int codigoRuta)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Tarifas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }
    }


}
