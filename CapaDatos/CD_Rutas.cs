using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rutas
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarRutas()
        {
            string Qry = "Alex_Usp_Rutas_Mostrar";  
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public void MtInsertarRuta(string nombre, string origen, string destino, decimal distancia, string tipoRuta, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Rutas_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Origen", origen);
            cmd.Parameters.AddWithValue("@Destino", destino);
            cmd.Parameters.AddWithValue("@Distancia", distancia);
            cmd.Parameters.AddWithValue("@TipoRuta", tipoRuta);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarRuta(int codigo, string nombre, string origen, string destino, decimal distancia, string tipoRuta, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Rutas_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoRuta", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Origen", origen);
            cmd.Parameters.AddWithValue("@Destino", destino);
            cmd.Parameters.AddWithValue("@Distancia", distancia);
            cmd.Parameters.AddWithValue("@TipoRuta", tipoRuta);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarRuta(int codigo)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Rutas_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoRuta", codigo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public DataTable MtBuscar(string criterio)
        {

            {
                SqlCommand cmd = new SqlCommand(
                    @"select CodigoRuta,Nombre,Origen,Destino,Distancia,TipoRuta,Estado from Rutas
              WHERE Nombre LIKE @criterio 
                or Origen LIKE @criterio 
                OR Destino LIKE @criterio 
                OR Distancia LIKE @criterio 
                OR TipoRuta LIKE @criterio 
                OR Estado LIKE @criterio 
              OR CAST(CodigoRuta AS VARCHAR) LIKE @criterio", db_conexion.MtdAbrirConexion());

                cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


    }
}
