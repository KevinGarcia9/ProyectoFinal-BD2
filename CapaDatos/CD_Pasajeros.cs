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
        //private SqlConnection conexion = new SqlConnection("Server=DESKTOP-9QF8HLG\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");
        CD_Conexion db_conexion = new CD_Conexion();

        public void mtdAgregarPasajero(string nombre, string dpi, string nit, DateTime fechaAlta, string telefono, string estado)
        {

            SqlCommand cmd = new SqlCommand("Usp_Agregar_Pasajero", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Dpi", dpi);
            cmd.Parameters.AddWithValue("@Nit", nit);
            cmd.Parameters.AddWithValue("@FechaAlta", fechaAlta);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Estado", estado);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            

        }

        public void mtdActualizarPasajero(int codigo, string nombre, string dpi, string nit, DateTime fechaAlta, string telefono, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Pasajero", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Dpi", dpi);
            cmd.Parameters.AddWithValue("@Nit", nit);
            cmd.Parameters.AddWithValue("@FechaAlta", fechaAlta);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Estado", estado);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
           
        }

        public void mtdEliminarPasajero(int codigo)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Pasajero", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoPasajero", codigo);

         
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public DataTable mtdBuscarPasajero(string filtro)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Pasajero", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Filtro", filtro);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable mtdMostrarPasajeros()
        {
            SqlCommand comando = new SqlCommand("Usp_Mostrar_Pasajeros", db_conexion.MtdAbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
