using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Prestamo
    {
        //Elementos para conexión y queries
        private static Connection connection = new Connection();
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;
        

        //Variables
        private string idPrestamo;
        private string fechaPrestamos;
        private string fechaDevolución;
        private string idAlumno;
        private string nombreMaterial;
        private string idMaterial;

        //Propiedades
        public string IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamos { get => fechaPrestamos; set => fechaPrestamos = value; }
        public string FechaDevolución { get => fechaDevolución; set => fechaDevolución = value; }
        public string IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreMaterial { get => nombreMaterial; set => nombreMaterial = value; }
        public string IdMaterial { get => idMaterial; set => idMaterial = value; }

        //métodos
        public void GenerarIDPrestamo()
        {
            string sqlSelect = "SELECT TOP 1 IDPrestamo FROM Prestamos ORDER BY IDPrestamo DESC";
            int code;
            string nuevoId;
            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                dataReader.Read();
                code = Convert.ToInt32(dataReader["IDPrestamo"].ToString().Substring(2));
                code++;
                if (code < 10)
                    nuevoId = "P00" + code.ToString();
                else if (code < 100)
                    nuevoId = "P0" + code.ToString();
                else
                    nuevoId = "P" + code.ToString();

                IdPrestamo = nuevoId;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en creación del ID del Prestamo: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }

        }

        public void crearPrestamo()
        {
            int filasAfectadas1 = 0;
            int filasAfectadas2 = 0;
            string sqlInsert = "INSERT INTO Prestamos (IDPrestamo, FechaDevolucion, IDMaterial) VALUES (@idprestamo, @devolucion, @idmaterial)";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlInsert, connection.Conn);
                command.Parameters.AddWithValue("@idprestamo", IdPrestamo);
                command.Parameters.AddWithValue("@devolucion", Convert.ToDateTime(FechaDevolución));
                command.Parameters.AddWithValue("@idmaterial", IdMaterial);
                filasAfectadas1 = command.ExecuteNonQuery();
                filasAfectadas2 = guardarDetallePrestamo(IdPrestamo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al guardar el registro en la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }
            if (filasAfectadas1 != 0 && filasAfectadas2 != 0)
                MessageBox.Show("Se registro su prestamo exitosamente, fecha de devolución: " + FechaDevolución, "¡Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar el prestamo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private int guardarDetallePrestamo(string idPrestamo)
        {
            string sqlInsert = "INSERT INTO Detalle_Prestamos (IDPrestamo, IDAlumno) VALUES (@idprestamo, @idalumno)";
            command = new SqlCommand(sqlInsert, connection.Conn);
            command.Parameters.AddWithValue("@idprestamo", idPrestamo);
            command.Parameters.AddWithValue("@idalumno", IdAlumno);           
            return command.ExecuteNonQuery();
        }

        public static void cancelarPrestamo(string idPrestamo)
        {
            int filasAfectadas = 0;
            string sqlDelete = "DELETE FROM Prestamos WHERE IDPrestamo = @idprestamo";
            try
            {
                connection.Conectar();
                command = new SqlCommand(sqlDelete, connection.Conn);
                command.Parameters.AddWithValue("@idprestamo", idPrestamo);
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al borrar prestamo de la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
            }

            if (filasAfectadas != 0)
                MessageBox.Show("¡El prestamo se canceló satisfactoriamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puedo cancelar el prestamo, intentelo de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static List<Prestamo> ExtraerPrestamos(string idAlumno)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            string sqlSelect = "SELECT prs.IDPrestamo, FechaPrestamo, FechaDevolucion, NombreMaterial FROM Prestamos prs ";
            sqlSelect += "INNER JOIN Detalle_Prestamos dtp ";
            sqlSelect += "ON dtp.IDPrestamo = prs.IDPrestamo ";
            sqlSelect += "LEFT JOIN Alumnos alm ";
            sqlSelect += "ON alm.IDAlumno = dtp.IDAlumno ";
            sqlSelect += "RIGHT JOIN Materiales mtr ";
            sqlSelect += "ON mtr.IDMaterial = prs.IDMaterial ";
            sqlSelect += "WHERE dtp.IDAlumno = @idalumno";

            try
            {
                connection.Conectar();
                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idalumno", idAlumno);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Prestamo prestamo = new Prestamo();
                        prestamo.IdPrestamo = dataReader[0].ToString();
                        prestamo.FechaPrestamos = dataReader["FechaPrestamo"].ToString();
                        prestamo.fechaDevolución = dataReader["FechaDevolucion"].ToString();
                        prestamo.NombreMaterial = dataReader["NombreMaterial"].ToString();
                        prestamo.IdAlumno = idAlumno;
                        prestamos.Add(prestamo);
                        prestamo = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer registros de prestamos desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return prestamos;
        }

    }
}
