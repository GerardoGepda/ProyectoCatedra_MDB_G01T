using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public class Alumno : Usuario
    {
        //elemento de conexiones y queries
        Connection connection = new Connection();
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        //campos o variables
        private string idAlumno;
        private string carnet;
        private int edad;
        private string email;
        private string idCarrera;
        private string carrera;
        private string Facultad;

        //atributos o propiedades
        public string IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
        public string IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Facultad1 { get => Facultad; set => Facultad = value; }

        //métodos
        public bool extraerUsuario(string carnet)
        {
            bool alumnoExiste = false;
            string sqlSelect = "SELECT IDAlumno, Nombre, Apellido, Carnet, Edad, Email, alm.IDCarrera, NombreCarrera, NombreFacultad FROM Alumnos alm " +
            "INNER JOIN Carreras crs " +
            "ON alm.IDCarrera = crs.IDCarrera " +
            "LEFT JOIN Facultades fcl " +
            "ON fcl.IDFacultad = crs.IDFacultad " +
            "WHERE alm.Carnet = @carnet";

            try
            {
                connection.Conectar();

                dataAdapter = new SqlDataAdapter(sqlSelect, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@carnet", carnet);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    alumnoExiste = true;
                    dataReader.Read();
                    IdAlumno = dataReader["IDAlumno"].ToString();
                    Nombre = dataReader["Nombre"].ToString();
                    Apellido = dataReader["Apellido"].ToString();
                    Carnet = dataReader["Carnet"].ToString();
                    Edad = Convert.ToInt32(dataReader["Edad"]);
                    Email = dataReader["Email"].ToString();
                    IdCarrera = dataReader[6].ToString();
                    Carrera = dataReader["NombreCarrera"].ToString();
                    Facultad = dataReader["NombreFacultad"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extarer Alumno desde la BD: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Cerrar();
                dataReader.Close();
            }
            return alumnoExiste;
        }

    }
}
