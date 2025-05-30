using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Transportes
    {
    
        CD_Conexion db_conexion = new CD_Conexion();
            public DataTable MtMostrarTransportes()
            {
                string QryMostrarTransportes = "Alex_Usp_Transportes_Mostrar"; 
                SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarTransportes, db_conexion.MtdAbrirConexion());
                DataTable dtMostrarTransportes = new DataTable();
                adapter.Fill(dtMostrarTransportes);
                return dtMostrarTransportes;
            }

            public void MtInsertarTransporte(string placa, string marca, string modelo, int año, int capacidad, string estado)
            {
                SqlCommand cmd = new SqlCommand("Alex_Usp_Transportes_Agregar", db_conexion.MtdAbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", placa);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            public void MtActualizarTransporte(int codigo, string placa, string marca, string modelo, int año, int capacidad, string estado)
            {
                SqlCommand cmd = new SqlCommand("Alex_Usp_Transportes_Actualizar", db_conexion.MtdAbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoTransporte", codigo);
                cmd.Parameters.AddWithValue("@Placa", placa);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            public void MtEliminarTransporte(int codigo)
            {
                SqlCommand cmd = new SqlCommand("Alex_Usp_Transportes_Eliminar", db_conexion.MtdAbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoTransporte", codigo);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

        public DataTable MtBuscar(string criterio)
        {
            
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT CodigoTransporte,Placa,Marca,Modelo,Año,Capacidad,Estado FROM Transportes
              WHERE Placa LIKE @criterio OR Marca LIKE @criterio
                OR Modelo LIKE @criterio
                OR CAST(Año AS VARCHAR) LIKE @criterio
                OR CAST(Capacidad AS VARCHAR) LIKE @criterio
                OR Estado LIKE @criterio
              OR CAST(CodigoTransporte AS VARCHAR) LIKE @criterio", db_conexion.MtdAbrirConexion());

                cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


    }
}
