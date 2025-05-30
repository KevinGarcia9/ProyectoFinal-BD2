﻿using FontAwesome.Sharp;
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
        //private SqlConnection conexion = new SqlConnection("Server=DESKTOP-9QF8HLG\\SQLEXPRESS;Database=ElIngeVeloz;Trusted_Connection=True;");
        CD_Conexion db_conexion = new CD_Conexion();

        public void mtdAgregarTarifa(int codigoRuta, decimal monto, string moneda, DateTime fechaVigencia, DateTime fechaVencimiento, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Agregar_Tarifas", db_conexion.MtdAbrirConexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@Moneda", moneda);
            cmd.Parameters.AddWithValue("@FechaVigencia", fechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", estado);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdActualizarTarifa(int codigoTarifa, int codigoRuta, decimal monto, string moneda, DateTime fechaVigencia, DateTime fechaVencimiento, string estado)
        {
            SqlCommand cmd = new SqlCommand("Usp_Actualizar_Tarifas", db_conexion.MtdAbrirConexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@Moneda", moneda);
            cmd.Parameters.AddWithValue("@FechaVigencia", fechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", estado);

          
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public void mtdEliminarTarifa(int codigoTarifa)
        {
            SqlCommand cmd = new SqlCommand("Usp_Eliminar_Tarifas", db_conexion.MtdAbrirConexion());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoTarifa", codigoTarifa);

            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            
        }

        public DataTable mtdBuscarTarifasPorRuta(int codigoRuta)
        {
            SqlCommand cmd = new SqlCommand("Usp_Buscar_Tarifas", db_conexion.MtdAbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoRuta", codigoRuta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable mtdMostrarTarifas()
        {
            SqlCommand comando = new SqlCommand("Usp_Mostrar_Tarifas", db_conexion.MtdAbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            return tabla;
        }
    }


}
