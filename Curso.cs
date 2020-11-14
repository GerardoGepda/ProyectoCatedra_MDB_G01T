using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Curso
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;

        //variables
        private string idCurso;
        private string nombreCurso;
        private string descripcion;
        private int duracionSemanas;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string idCategoria;

        //propiedades
        public string IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int DuracionSemanas { get => duracionSemanas; set => duracionSemanas = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string IdCategoria { get => idCategoria; set => idCategoria = value; }

        //métodos
        public static List<Curso> ExtraerCursos()
        {
            List<Curso> cursos = new List<Curso>();
            string sqlSelect = "SELECT * FROM Cursos";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Curso curso = new Curso();
                        curso.IdCurso = dataReader["IDCurso"].ToString();
                        curso.NombreCurso = dataReader["NombreCurso"].ToString();
                        curso.Descripcion = dataReader["Descripcion"].ToString();
                        curso.DuracionSemanas = (int)dataReader["DuracionSemanas"];
                        curso.FechaInicio = Convert.ToDateTime(dataReader["FechaInicio"]);
                        curso.FechaFin = Convert.ToDateTime(dataReader["FechaFin"]);
                        curso.IdCategoria = dataReader["IDCategoria"].ToString();
                        cursos.Add(curso);
                        curso = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer cursos de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return cursos;
        }

        public void CrearCurso()
        {
            int rowsAffected = 0;
            string sqlInsert = "INSERT INTO Cursos (IDCurso, NombreCurso, Descripcion, DuracionSemanas, FechaInicio, FechaFin, IDCategoria) " +
                                "VALUES (@idCurso, @nombreCurso, @descripcion, @duracionSemanas, @fechaInicio, @fechaFin, @idCategoria)";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlInsert, connection.Conn);
                command.Parameters.AddWithValue("@idCurso", IdCurso);
                command.Parameters.AddWithValue("@nombreCurso", NombreCurso);
                command.Parameters.AddWithValue("@descripcion", Descripcion);
                command.Parameters.AddWithValue("@duracionSemanas", DuracionSemanas);
                command.Parameters.AddWithValue("@fechaInicio", FechaInicio);
                command.Parameters.AddWithValue("@fechaFin", FechaFin);
                command.Parameters.AddWithValue("@idCategoria", IdCategoria);
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al crear un nuevo curso en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (rowsAffected != 0)
                MessageBox.Show("Se creo el curso exitosamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se creo el curso, consulte con el administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //método que genera el Id del curso
        public void GenerarIDCurso()
        {
            string sqlSelect = "SELECT TOP 1 IDCurso FROM Cursos ORDER BY IDCurso DESC";
            int code;
            string nuevoId;
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                dataReader.Read();
                code = Convert.ToInt32(dataReader["IDCurso"].ToString().Substring(2));
                code++;
                if (code < 10)
                    nuevoId = "C00" + code.ToString();
                else if (code < 100)
                    nuevoId = "C0" + code.ToString();
                else
                    nuevoId = "C" + code.ToString();

                IdCurso = nuevoId;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en creación del ID del Curso: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }

        }

        public static Curso ExtraerCurso(string idCurso)
        {
            Curso curso = new Curso();
            string sqlSelect = "SELECT * FROM Cursos WHERE IDCurso = @idCurso";
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idCurso", idCurso);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        curso.IdCurso = dataReader["IDCurso"].ToString();
                        curso.NombreCurso = dataReader["NombreCurso"].ToString();
                        curso.Descripcion = dataReader["Descripcion"].ToString();
                        curso.DuracionSemanas = (int)dataReader["DuracionSemanas"];
                        curso.FechaInicio = Convert.ToDateTime(dataReader["FechaInicio"]);
                        curso.FechaFin = Convert.ToDateTime(dataReader["FechaFin"]);
                        curso.IdCategoria = dataReader["IDCategoria"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer el curso de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return curso;
        }

        public void ActualizarCurso()
        {
            int rowsAffected = 0;
            string sqlUpdate = "UPDATE Cursos SET NombreCurso = @nombreCurso, Descripcion = @descripcion, ";
            sqlUpdate += "DuracionSemanas = @duracionSemanas, FechaInicio = @fechaInicio, FechaFin = @fechaFin, ";
            sqlUpdate += "IDCategoria = @idCategoria WHERE IDCurso = @idCurso";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlUpdate, connection.Conn);
                command.Parameters.AddWithValue("@nombreCurso", NombreCurso);
                command.Parameters.AddWithValue("@descripcion", Descripcion);
                command.Parameters.AddWithValue("@duracionSemanas", DuracionSemanas);
                command.Parameters.AddWithValue("@fechaInicio", FechaInicio);
                command.Parameters.AddWithValue("@fechaFin", FechaFin);
                command.Parameters.AddWithValue("@idCategoria", IdCategoria);
                command.Parameters.AddWithValue("@idCurso", IdCurso);
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error el actualizar curso en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (rowsAffected != 0)
                MessageBox.Show("Se actualiazo el curso satisfatoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se actualizo el curso, consulte con el administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BorrarCurso(string idCurso)
        {
            int filasAfectadas = 0;
            string sqlDelete = "DELETE FROM Cursos WHERE IDCurso = @idCurso";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlDelete, connection.Conn);
                command.Parameters.AddWithValue("@idCurso", idCurso);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al borrar curso en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas != 0)
                MessageBox.Show("El curso se borró satisfactoriamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo borrar el registro, intente de nuevo o consulte con el administrador del sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
