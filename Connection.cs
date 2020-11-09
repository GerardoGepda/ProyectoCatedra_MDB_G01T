﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Connection
    {
        private static string cadcon = "server=Localhost\\SQLEXPRESS; database=BD_ProyectoMDB; Integrated Security=yes";
        private SqlConnection conn = new SqlConnection(cadcon);

        public SqlConnection Conn { get => conn; }

        public void Conectar()
        {
            try
            {
                Conn.Open();
            }
            catch (Exception err)
            {

                MessageBox.Show("Error al conectar la BD: " + err.Message);
            }
        }

        public void Cerrar()
        {
            Conn.Close();
        }
    }
}
