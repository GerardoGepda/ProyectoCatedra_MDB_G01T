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
    public partial class FrmInscripcion : Form
    {
        Alumno alumno = new Alumno();
        Connection connection = new Connection();
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        SqlCommand command;

        public FrmInscripcion(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void inscibir(string grupo)
        {
            string IDalumno = alumno.IdAlumno; 

            //verificamos que no esta inscrito ya
            string cmnd = $"SELECT IDAlumno, IDGrupo FROM Inscripciones WHERE IDAlumno = '{IDalumno}' AND IDGrupo = '{grupo}'";

            connection.Conectar();
            dataAdapter = new SqlDataAdapter(cmnd, connection.Conn);

            SqlParameter prm = new SqlParameter("NombreUsuario", SqlDbType.Char);
            SqlParameter prm2 = new SqlParameter("Clave", SqlDbType.Char);
            prm.Value = IDalumno;
            prm2.Value = grupo;
            dataAdapter.SelectCommand.Parameters.Add(prm);
            dataAdapter.SelectCommand.Parameters.Add(prm2);
            dataReader = dataAdapter.SelectCommand.ExecuteReader();

            if (!dataReader.HasRows)
            {
                dataReader.Close();

                //Preguntamos si esta seguro de inscibirse
                if (MessageBox.Show("¿Deseas inscribirte en este curso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //hacemos insert de inscripción con control de excepciones
                    string insert = "INSERT INTO Inscripciones (IDAlumno, IDGrupo) VALUES (@alumno, @grupo)";
                    try
                    {
                        command = new SqlCommand(insert, connection.Conn);
                        command.Parameters.Add(new SqlParameter("@alumno", SqlDbType.Char));
                        command.Parameters.Add(new SqlParameter("@grupo", SqlDbType.Char));
                        command.Parameters["@alumno"].Value = IDalumno;
                        command.Parameters["@grupo"].Value = grupo;
                        command.ExecuteNonQuery();
                        MessageBox.Show("¡Ya estas inscrito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al inscribirse: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya esta inscrito en este curso", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            connection.Cerrar();
        }

        //Método para ver detalles de los cursos
        private void detalles(string grupo)
        {
            connection.Conectar();
            string sql = "SELECT NombreCurso, Descripcion, grp.IDGrupo AS Grupo, Cupo, dia, FechaInicio, FechaFin, horainicio, horafin FROM Grupos grp ";
            sql += "INNER JOIN Horarios hor ";
            sql += "ON hor.IDGrupo = grp.IDGrupo ";
            sql += "RIGHT JOIN Cursos cur ";
            sql += "ON cur.IDCurso = grp.IDCurso ";
            sql += $"WHERE grp.IDGrupo = '{grupo}' ";

            dataAdapter = new SqlDataAdapter(sql, connection.Conn);
            //SqlParameter prm = new SqlParameter("grp.IDGrupo", SqlDbType.Char);
            //prm.Value = grupo;
            //dataAdapter.SelectCommand.Parameters.Add(prm);
            dataReader = dataAdapter.SelectCommand.ExecuteReader();

            dataReader.Read();
            DetallesCurso detalles = new DetallesCurso();
            detalles.NombreCurso = dataReader["NombreCurso"].ToString();
            detalles.Descripcion = dataReader["Descripcion"].ToString();
            detalles.Grupo = dataReader["Grupo"].ToString();
            detalles.Cupo = dataReader["Cupo"].ToString();
            detalles.Dia = dataReader["dia"].ToString();
            detalles.Fechainicio = DateTime.Parse(dataReader["FechaInicio"].ToString());
            detalles.Fechafin = DateTime.Parse(dataReader["FechaFin"].ToString());
            detalles.Horainicio = dataReader["horainicio"].ToString().Remove(5);
            detalles.Horafin = dataReader["horafin"].ToString().Remove(5);

            FrmDetalles frmDetalles = new FrmDetalles(detalles);
            frmDetalles.ShowDialog();

            dataReader.Close();
            connection.Cerrar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            connection.Conectar();
            string cmnd = "SELECT crs.IDCurso, NombreCurso, DuracionSemanas, ctc.NombreCategoria AS Categoria, grp.Cupo AS Cupo, grp.IDGrupo AS IDGrupo FROM Cursos crs ";
            cmnd += "RIGHT JOIN CategoriaCursos ctc ";
            cmnd += "ON ctc.IDCategoria = crs.IDCategoria ";
            cmnd += "RIGHT JOIN Grupos grp ";
            cmnd += "ON grp.IDCurso = crs.IDCurso";

            dataAdapter = new SqlDataAdapter(cmnd, connection.Conn);
            dataReader = dataAdapter.SelectCommand.ExecuteReader();

            int cont = 1;
            while (dataReader.Read())
            {
                switch (cont)
                {
                    case 1:
                        lblnombre1.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo1.Text = dataReader["IDGrupo"].ToString();
                        lblduracion1.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo1.Text = dataReader["Cupo"].ToString();
                        btninscribir1.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles1.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    case 2:
                        lblnombre2.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo2.Text = dataReader["IDGrupo"].ToString();
                        lblduracion2.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo2.Text = dataReader["Cupo"].ToString();
                        btninscribir2.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles2.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    case 3:
                        lblnombre3.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo3.Text = dataReader["IDGrupo"].ToString();
                        lblduracion3.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo3.Text = dataReader["Cupo"].ToString();
                        btninscribir3.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles3.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    case 4:
                        lblnombre4.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo4.Text = dataReader["IDGrupo"].ToString();
                        lblduracion4.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo4.Text = dataReader["Cupo"].ToString();
                        btninscribir4.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles4.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    case 5:
                        lblnombre5.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo5.Text = dataReader["IDGrupo"].ToString();
                        lblduracion5.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo5.Text = dataReader["Cupo"].ToString();
                        btninscribir5.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles5.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    case 6:
                        lblnombre6.Text = dataReader["NombreCurso"].ToString();
                        lblgrupo6.Text = dataReader["IDGrupo"].ToString();
                        lblduracion6.Text = dataReader["DuracionSemanas"].ToString() + " semanas";
                        lblcupo6.Text = dataReader["Cupo"].ToString();
                        btninscribir6.Tag = dataReader["IDGrupo"].ToString();
                        btndetalles6.Tag = dataReader["IDGrupo"].ToString();
                        break;

                    default:
                        break;
                }
                cont++;
            }
            dataReader.Close();
            connection.Cerrar();
        }

        //Eventos de botones
        private void btninscribir1_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir1.Tag.ToString());
        }

        private void btninscribir2_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir2.Tag.ToString());
        }

        private void btninscribir3_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir3.Tag.ToString());
        }

        private void btninscribir4_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir4.Tag.ToString());
        }

        private void btninscribir5_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir5.Tag.ToString());
        }

        private void btninscribir6_Click(object sender, EventArgs e)
        {
            inscibir(btninscribir6.Tag.ToString());
        }

        private void btndetalles1_Click(object sender, EventArgs e)
        {
            detalles(btndetalles1.Tag.ToString());
        }

        private void btndetalles2_Click(object sender, EventArgs e)
        {
            detalles(btndetalles2.Tag.ToString());
        }

        private void btndetalles3_Click(object sender, EventArgs e)
        {
            detalles(btndetalles3.Tag.ToString());
        }

        private void btndetalles4_Click(object sender, EventArgs e)
        {
            detalles(btndetalles4.Tag.ToString());
        }

        private void btndetalles5_Click(object sender, EventArgs e)
        {
            detalles(btndetalles5.Tag.ToString());
        }

        private void btndetalles6_Click(object sender, EventArgs e)
        {
            detalles(btndetalles6.Tag.ToString());

        }
    }
}
