using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Maestro : Usuario
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //variables
        private string idMatestro;

        //Propiedades
        public string IdMatestro { get => idMatestro; set => idMatestro = value; }

        //métodos
        public static Maestro ExtraerMaestro(string idMaestro)
        {
            Maestro maestro = new Maestro();
            string sqlSelect = "SELECT * FROM Maestros WHERE IDMaestro = @idMaestro";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idMaestro", idMaestro);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    maestro.IdMatestro = dataReader["IDMaestro"].ToString();
                    maestro.Nombre = dataReader["PrimerNombre"].ToString();
                    maestro.Apellido = dataReader["PrimerApellido"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer el maestros desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return maestro;
        }

        public static List<Maestro> ExtraerMaestros()
        {
            List<Maestro> maestros = new List<Maestro>();
            string sqlSelect = "SELECT * FROM Maestros";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Maestro maestro = new Maestro();
                        maestro.IdMatestro = dataReader["IDMaestro"].ToString();
                        maestro.Nombre = dataReader["PrimerNombre"].ToString();
                        maestro.Apellido = dataReader["PrimerApellido"].ToString();
                        maestros.Add(maestro);
                        maestro = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer los maestros desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return maestros;
        }

    }
}
