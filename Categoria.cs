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

        public void CrearCategoria()
        {
            int filasAfectadas = 0;
            string sqlInsert = "INSERT INTO CategoriaCursos (IDCategoria, NombreCategoria) VALUES (@idCategoria, @nombreCate)";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlInsert, connection.Conn);
                command.Parameters.AddWithValue("@idCategoria", IdCategoria);
                command.Parameters.AddWithValue("@nombreCate", Nombre);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al crear la categoría en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0)
                MessageBox.Show("Se creó correctamente la categoría", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se creo la categoría, intente de nuevo o consulte con el administrador del sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //método que genera el Id del curso
        public void GenerarIDCategoria()
        {
            string sqlSelect = "SELECT TOP 1 IDCategoria FROM CategoriaCursos ORDER BY IDCategoria DESC";
            int code;
            string nuevoId;
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                dataReader.Read();
                code = Convert.ToInt32(dataReader["IDCategoria"].ToString());
                code++;
                if (code < 10)
                    nuevoId = "00" + code.ToString();
                else if (code < 100)
                    nuevoId = "0" + code.ToString();
                else
                    nuevoId = code.ToString();

                IdCategoria = nuevoId;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en creación del ID de la categoría: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }

        }

        public void ActualizarCategoria()
        {
            int filasAfectadas = 0;
            string sqlUpdate = "UPDATE CategoriaCursos SET NombreCategoria = @nombreCate WHERE IDCategoria = @idCategoria";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlUpdate, connection.Conn);
                command.Parameters.AddWithValue("@nombreCate", Nombre);
                command.Parameters.AddWithValue("@idCategoria", IdCategoria);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al actualizar la categoría en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0)
                MessageBox.Show("Se actualizó correctamente la categoría", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se actualizó la categoría, intente de nuevo o consulte con el administrador del sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BorrarCategoria(string idCategoria)
        {
            int filasAfectadas = 0;
            string sqlDelete = "DELETE FROM CategoriaCursos WHERE IDCategoria = @idCategoria";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlDelete, connection.Conn);
                command.Parameters.AddWithValue("@idCategoria", idCategoria);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al borrar el registro de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0)
                MessageBox.Show("Se borró correctamente la categoría", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se borró la categoría, intente de nuevo o consulte con el administrador del sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
