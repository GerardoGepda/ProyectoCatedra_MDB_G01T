using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Material
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //variables
        private string idMaterial;
        private string nombre;
        private int unidadesDisponibles;

        //propiedades
        public string IdMaterial { get => idMaterial; set => idMaterial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int UnidadesDisponibles { get => unidadesDisponibles; set => unidadesDisponibles = value; }

        //métodos
        public static List<Material> extraerMateriales()
        {
            List<Material> materiales = new List<Material>();
            string sqlSelect = "SELECT * FROM Materiales";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Material material = new Material();
                        material.IdMaterial = dataReader["IDMaterial"].ToString();
                        material.Nombre = dataReader["NombreMaterial"].ToString();
                        material.UnidadesDisponibles = Convert.ToInt32(dataReader["UnidadesDisponibles"]);
                        materiales.Add(material);
                        material = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer materiales de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return materiales;
        }
    }
}
