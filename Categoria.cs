using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Categoria
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //vairables
        private string idCategoria;
        private string nombre;

        //propiedades
        public string IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //métodos
        public static List<Categoria> ExtraerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            string sqlSelect = "SELECT * FROM CategoriaCursos";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.IdCategoria = dataReader["IDCategoria"].ToString();
                        categoria.Nombre = dataReader["NombreCategoria"].ToString();
                        categorias.Add(categoria);
                        categoria = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer categorías desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return categorias;
        }
    }
}
