using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conductores
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarConductores()
        {
            string Qry = "Alex_Usp_Conductores_Mostrar";  
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, db_conexion.MtdAbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public void MtInsertarConductor(string nombre, string licencia, string telefono, string fechaContratacion, string direccion, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Conductores_Agregar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Licencia", licencia);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtActualizarConductor(int codigo, string nombre, string licencia, string telefono, string fechaContratacion, string direccion, string estado)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Conductores_Actualizar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoConductor", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Licencia", licencia);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Estado", estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void MtEliminarConductor(int codigo)
        {
            SqlCommand cmd = new SqlCommand("Alex_Usp_Conductores_Eliminar", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodigoConductor", codigo);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
