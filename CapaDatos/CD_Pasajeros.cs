using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Pasajeros
    {
        private SqlConnection conexion = new SqlConnection("Server=LAPTOP-6PG83GU4\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");

        public void mtdAgregarPasajero(string nombre, string dpi, string nit, DateTime fechaAlta, string telefono, string estado)
        {

            SqlCommand cmd = new SqlCommand("Usp_Agregar_Pasajero", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Dpi", dpi);
            cmd.Parameters.AddWithValue("@Nit", nit);
            cmd.Parameters.AddWithValue("@FechaAlta", fechaAlta);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();

        }

        public void mtdActualizarPasajero(int codigo, string nombre, string dpi, string nit, DateTime fechaAlta, string telefono, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Pasajero", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Dpi", dpi);
            cmd.Parameters.AddWithValue("@Nit", nit);
            cmd.Parameters.AddWithValue("@FechaAlta", fechaAlta);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();
        }

        public void mtdEliminarPasajero(int codigo)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Pasajero", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigo);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.Close();
        }

        public DataTable BuscarPasajero(string filtro)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Pasajero", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Filtro", filtro);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable mtdMostrarPasajeros()
        {
            SqlCommand comando = new SqlCommand("Usp_Mostrar_Pasajeros", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
