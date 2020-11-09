using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public partial class FrmCursos : Form
    {
        Alumno alumno = new Alumno();
        public FrmCursos(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        Connection connection = new Connection();
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataSet datos;
        SqlCommand command;

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Nombre, Apellido, Carnet, Email, NombreCarrera FROM Alumnos alm ";
            sql += "INNER JOIN Carreras crs ";
            sql += "ON alm.IDCarrera = crs.IDCarrera ";
            sql += $"WHERE IDAlumno = '' ";

            lblcarnet.Text = alumno.Carnet;
            lblnombres.Text = alumno.Nombre;
            lblapellidos.Text = alumno.Apellido;
            lblcarrera.Text = alumno.Carrera;
            lblcorreo.Text = alumno.Email;

            datosCursos();
        }

        private void datosCursos()
        {
            connection.Conectar();
            string sql = "SELECT ins.IDGrupo, NombreCategoria, NombreCurso, DuracionSemanas, dia, FechaInicio, FechaFin, horainicio, horafin FROM Inscripciones ins ";
            sql += "INNER JOIN Grupos grp ";
            sql += "ON grp.IDGrupo = ins.IDGrupo ";
            sql += "RIGHT JOIN Cursos crs ";
            sql += "ON crs.IDCurso = grp.IDCurso ";
            sql += "RIGHT JOIN CategoriaCursos ctc ";
            sql += "ON ctc.IDCategoria = crs.IDCategoria ";
            sql += "RIGHT JOIN Horarios hor ";
            sql += "ON hor.IDGrupo = grp.IDGrupo ";
            sql += $"WHERE IDAlumno = '{alumno.IdAlumno}'";

            dataAdapter = new SqlDataAdapter(sql, connection.Conn);
            SqlParameter prm = new SqlParameter("IDAlumno", SqlDbType.Char);
            prm.Value = alumno.IdAlumno;
            dataAdapter.SelectCommand.Parameters.Add(prm);
            datos = new DataSet();
            dataAdapter.Fill(datos);
            dgvcursos.DataSource = datos.Tables[0];

            connection.Cerrar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            datosCursos();
        }

        private void dgvcursos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selected = dgvcursos.SelectedRows[0];
                DataGridViewCellCollection cells = selected.Cells;
                borrarCurso(cells[0].Value.ToString(), cells[2].Value.ToString());
                datosCursos();
            }
            catch (Exception)
            {

            }
        }

        private void borrarCurso(string grupo, string curso)
        {
            if (MessageBox.Show($"¿Desea anular inscripción al {curso} en el grupo {grupo.Trim()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connection.Conectar();

                    command = new SqlCommand("DELETE Inscripciones WHERE IDGrupo = @curso", connection.Conn);
                    command.Parameters.AddWithValue("@curso", grupo);
                    if (command.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Inscripción al curso cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al cancelar inscripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error al realizar esta acción" + err.Message);
                }
                finally
                {
                    connection.Cerrar();
                }
            }
        }

    }
}
