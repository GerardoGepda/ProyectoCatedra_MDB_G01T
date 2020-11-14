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
        List<Grupo> grupos = new List<Grupo>();
        Connection connection = new Connection();
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        SqlCommand command;

        public FrmInscripcion(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            CrearCuadrosGrupos();
        }

        private void CrearCuadrosGrupos()
        {
            grupos = Grupo.ExtraerGrupos();

            int count = 0;
            int columnas = 0;
            int filas = 1;
            int x = 117;
            int y = 25;

            foreach (Grupo item in grupos)
            {
                count++;
                CreateGrupos(item, count, x, y);
                columnas++;
                x += 312;
                if (columnas == 3)
                {
                    filas++;
                    y += 234;
                    x = 117;
                    columnas = 0;
                }
            }
        }

        private void inscibir(string grupo)
        {
            string IDalumno = alumno.IdAlumno; 

            //verificamos que no esta inscrito ya
            string cmnd = $"SELECT IDAlumno, IDGrupo FROM Inscripciones WHERE IDAlumno = @idAlumno AND IDGrupo = @idGrupo";

            connection.Conectar();
            dataAdapter = new SqlDataAdapter(cmnd, connection.Conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@idAlumno", IDalumno);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@idGrupo", grupo);
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
                        command.Parameters.AddWithValue("@alumno", IDalumno);
                        command.Parameters.AddWithValue("@grupo", grupo);
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
                MessageBox.Show("Ya esta inscrito en este curso", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
            connection.Cerrar();
        }

        //Método para ver detalles de los cursos
        private void detalles(string grupo)
        {
            FrmDetalles frmDetalles = new FrmDetalles(grupos.Find(x => x.IdGrupo == grupo));
            frmDetalles.ShowDialog();
        }

        //creación de cuadros de inscripción
        private void CreateGrupos(Grupo grupo, int count, int x, int y)
        {
            Label labelNombre = new Label();
            labelNombre.BackColor = Color.FromArgb(0, 160, 240);
            labelNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(0, 0);
            labelNombre.Name = "lblnombre" + count;
            labelNombre.Size = new Size(208, 42);
            labelNombre.TabIndex = 0;
            labelNombre.Text = grupo.CursoGrupo.NombreCurso;
            labelNombre.TextAlign = ContentAlignment.MiddleCenter;

            Label labelGrupo = new Label();
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGrupo.ForeColor = Color.FromArgb(64, 64, 64);
            labelGrupo.Location = new Point(17, 54);
            labelGrupo.Name = "labelGrupo" + count;
            labelGrupo.Size = new Size(50, 15);
            labelGrupo.Text = "Grupo:";

            Label labelGrupoTxt = new Label();
            labelGrupoTxt.AutoSize = true;
            labelGrupoTxt.Location = new Point(101, 56);
            labelGrupoTxt.Name = "lblgrupotxt" + count;
            labelGrupoTxt.Size = new Size(13, 13);
            labelGrupoTxt.Text = grupo.IdGrupo;

            Label labelDuracion = new Label();
            labelDuracion.AutoSize = true;
            labelDuracion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDuracion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDuracion.Location = new Point(17, 82);
            labelDuracion.Name = "labelDuracion" + count;
            labelDuracion.Size = new Size(69, 15);
            labelDuracion.Text = "Duración:";

            Label labelDuracionTxt = new Label();
            labelDuracionTxt.AutoSize = true;
            labelDuracionTxt.Location = new Point(101, 84);
            labelDuracionTxt.Name = "lblduraciontxt" + count;
            labelDuracionTxt.Size = new Size(58, 13);
            labelDuracionTxt.Text = grupo.CursoGrupo.DuracionSemanas.ToString() + " semanas";

            Label labelCupo = new Label();
            labelCupo.AutoSize = true;
            labelCupo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCupo.ForeColor = Color.FromArgb(64, 64, 64);
            labelCupo.Location = new Point(17, 108);
            labelCupo.Name = "labelCupo" + count;
            labelCupo.Size = new Size(44, 15);
            labelCupo.Text = "Cupo:";

            Label labelCupoTxt = new Label();
            labelCupoTxt.AutoSize = true;
            labelCupoTxt.Location = new Point(101, 110);
            labelCupoTxt.Name = "lblcupotxt" + count;
            labelCupoTxt.Size = new Size(13, 13);
            labelCupoTxt.Text = grupo.Cupo.ToString();

            Button buttonInscribir = new Button();
            buttonInscribir.BackColor = Color.FromArgb(0, 160, 240);
            buttonInscribir.FlatAppearance.BorderSize = 0;
            buttonInscribir.FlatStyle = FlatStyle.Flat;
            buttonInscribir.ForeColor = Color.White;
            buttonInscribir.Location = new Point(18, 141);
            buttonInscribir.Name = "btninscribir" + count;
            buttonInscribir.Size = new Size(74, 30);
            buttonInscribir.Text = "Inscribir";
            buttonInscribir.UseVisualStyleBackColor = false;
            buttonInscribir.Tag = grupo.IdGrupo;
            buttonInscribir.Click += btninscribir_Click;

            Button buttonDetalles = new Button();
            buttonDetalles.BackColor = Color.Gray;
            buttonDetalles.FlatAppearance.BorderSize = 0;
            buttonDetalles.FlatStyle = FlatStyle.Flat;
            buttonDetalles.ForeColor = Color.White;
            buttonDetalles.Location = new Point(115, 141);
            buttonDetalles.Name = "btndetalles" + count;
            buttonDetalles.Size = new Size(74, 30);
            buttonDetalles.Text = "Detalles";
            buttonDetalles.UseVisualStyleBackColor = false;
            buttonDetalles.Tag = grupo.IdGrupo;
            buttonDetalles.Click += btndetalles_Click;

            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(buttonDetalles);
            panel.Controls.Add(buttonInscribir);
            panel.Controls.Add(labelCupoTxt);
            panel.Controls.Add(labelCupo);
            panel.Controls.Add(labelGrupoTxt);
            panel.Controls.Add(labelGrupo);
            panel.Controls.Add(labelDuracionTxt);
            panel.Controls.Add(labelDuracion);
            panel.Controls.Add(labelNombre);
            panel.Location = new Point(x, y);
            panel.Name = "pnlgrupo" + count;
            panel.Size = new Size(209, 185);

            panel1.Controls.Add(panel);
        }

        //Eventos de botones
        private void btninscribir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            inscibir(btn.Tag.ToString());
        }

        private void btndetalles_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            detalles(btn.Tag.ToString());
        }
    }
}
