﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PrototipoMenu
{
    class Conexion
    {
        public OdbcConnection connection()
        {
            //OdbcConnection conn = new OdbcConnection("Dsn=HotelSConexion");
            OdbcConnection conn = new OdbcConnection("Dsn=siu");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No desconectó");
            }
        }
    }
}

