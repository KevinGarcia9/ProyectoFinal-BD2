﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class CD_Conexion
    {

        // DESKTOP-9QF8HLG\\SQLEXPRESS Seleidy
        //DESKTOP-TGA3FFT\\SQLEXPRESS  Alexander
        private SqlConnection db_conexion = new SqlConnection("Data Source=DESKTOP-9QF8HLG\\SQLEXPRESS;" +
            "Initial Catalog=ElIngeVeloz;" +
            "Integrated Security=True;Encrypt=False") ;

        public SqlConnection MtdAbrirConexion()
        {
            if(db_conexion.State == ConnectionState.Closed)
                db_conexion.Open();
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
                db_conexion.Close();
            return db_conexion;
        }
    }
}
