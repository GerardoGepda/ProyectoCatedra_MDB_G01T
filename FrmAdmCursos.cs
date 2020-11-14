using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra_MDB_G01T
{
    public partial class FrmAdmCursos : Form
    {

        List<Curso> cursos = new List<Curso>();

        public FrmAdmCursos()
        {
            InitializeComponent();
        }

        private void FrmAdmCursos_Load(object sender, EventArgs e)
        {
            CrearCuadrosCursos();
        }

        private void CrearCuadrosCursos()
        {
            cursos = Curso.ExtraerCursos();

            int count = 0;
            int columnas = 0;
            int filas = 1;
            int x = 72;
            int y = 38;

            foreach (Curso item in cursos)
            {
                count++;
                CreateCursos(item, count, x, y);
                columnas++;
                x += 358;
                if (columnas == 3)
                {
                    filas++;
                    y += 331;
                    x = 72;
                    columnas = 0;
                }
            }
        }

        private void button_Click_Editar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult result;
            string nombreCurso = cursos.Find(x => x.IdCurso == btn.Tag.ToString()).NombreCurso;
            result = MessageBox.Show($"¿Desea actualizar o modificar el curso {nombreCurso}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                FrmAddEditCurso editCurso = new FrmAddEditCurso();
                editCurso.curso = cursos.Find(x => x.IdCurso == btn.Tag.ToString());
                editCurso.actualizar = true;
                editCurso.ShowDialog();
                panel1.Controls.Clear();
                CrearCuadrosCursos();
            }
        }

        private void button_Click_Borrar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult result;
            string nombreCurso = cursos.Find(x => x.IdCurso == btn.Tag.ToString()).NombreCurso;
            result = MessageBox.Show($"¿Realmente desea borrar el curso {nombreCurso}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Curso.BorrarCurso(btn.Tag.ToString());
                panel1.Controls.Clear();
                CrearCuadrosCursos();
            }
        }

        private void buttongrupos_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FrmGrupos grupos = new FrmGrupos(btn.Tag.ToString());
            grupos.ShowDialog();
        }

        private void btnCrearcurso_Click(object sender, EventArgs e)
        {
            FrmAddEditCurso frmAddCurso = new FrmAddEditCurso();
            frmAddCurso.ShowDialog();
            panel1.Controls.Clear();
            CrearCuadrosCursos();
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            FrmAdmCategorias admCategorias = new FrmAdmCategorias();
            admCategorias.ShowDialog();
        }

        private void btnaddgrupo_Click(object sender, EventArgs e)
        {
            FrmAddGrupo addGrupo = new FrmAddGrupo();
            if (addGrupo.ShowDialog() == DialogResult.OK)
            {
                FrmAddHorario addHorario = new FrmAddHorario();
                addHorario.fromGrupo = true;
                addHorario.idGrupo = addGrupo.Identificador;
                addHorario.ShowDialog();
            }
        }

        private void btnhorario_Click(object sender, EventArgs e)
        {
            FrmAddHorario addHorario = new FrmAddHorario();
            addHorario.ShowDialog();
        }

        private void CreateCursos(Curso curso, int count, int x, int y)
        {
            Label labelNombreCurso = new Label();
            labelNombreCurso.BackColor = Color.FromArgb(0, 160, 240);
            labelNombreCurso.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreCurso.ForeColor = Color.White;
            labelNombreCurso.Location = new Point(0, 0);
            labelNombreCurso.Name = "lblnombrecurso" + count;
            labelNombreCurso.Size = new Size(229, 42);
            labelNombreCurso.Text = curso.NombreCurso;
            labelNombreCurso.TextAlign = ContentAlignment.MiddleCenter;

            Label labelCategoria = new Label();
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = Color.FromArgb(64, 64, 64);
            labelCategoria.Location = new Point(19, 54);
            labelCategoria.Name = "lblcategoria" + count;
            labelCategoria.Size = new Size(73, 15);
            labelCategoria.Text = "Categoría:";

            Label labelcategoriaText = new Label();
            labelcategoriaText.AutoSize = true;
            labelcategoriaText.Location = new Point(103, 56);
            labelcategoriaText.Name = "lblcategoriatxt" + count;
            labelcategoriaText.Size = new Size(62, 13);
            labelcategoriaText.Text = curso.IdCategoria;

            Label labelDescripcion = new Label();
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescripcion.Location = new Point(19, 76);
            labelDescripcion.Name = "lbldescripcion" + count;
            labelDescripcion.Size = new Size(87, 15);
            labelDescripcion.Text = "Descripción:";

            Label labelDescripcionText = new Label();
            labelDescripcionText.Location = new Point(20, 95);
            labelDescripcionText.Name = "lbldescripciontxt" + count;
            labelDescripcionText.Size = new Size(194, 34);
            labelDescripcionText.Text = curso.Descripcion;

            Label labelFechaInicio = new Label();
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
            labelFechaInicio.Location = new Point(20, 131);
            labelFechaInicio.Name = "lblfechainicio" + count;
            labelFechaInicio.Size = new Size(89, 15);
            labelFechaInicio.Text = "Fecha inicio:";

            Label labelFechaInicioText = new Label();
            labelFechaInicioText.AutoSize = true;
            labelFechaInicioText.Location = new Point(114, 133);
            labelFechaInicioText.Name = "lblfechainiciotxt" + count;
            labelFechaInicioText.Size = new Size(62, 13);
            labelFechaInicioText.Text = curso.FechaInicio.GetDateTimeFormats()[0].ToString();

            Label labelFechaFin = new Label();
            labelFechaFin.AutoSize = true;
            labelFechaFin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaFin.ForeColor = Color.FromArgb(64, 64, 64);
            labelFechaFin.Location = new Point(20, 157);
            labelFechaFin.Name = "lblfechafin" + count;
            labelFechaFin.Size = new Size(70, 15);
            labelFechaFin.Text = "Fecha fin:";

            Label labelFechaFinText = new Label();
            labelFechaFinText.AutoSize = true;
            labelFechaFinText.Location = new Point(114, 159);
            labelFechaFinText.Name = "lblfechafintxt" + count;
            labelFechaFinText.Size = new Size(62, 13);
            labelFechaFinText.Text = curso.FechaFin.GetDateTimeFormats()[0].ToString();

            Button botonEditCurso = new Button();
            botonEditCurso.BackColor = Color.FromArgb(0, 160, 240);
            botonEditCurso.FlatAppearance.BorderSize = 0;
            botonEditCurso.FlatStyle = FlatStyle.Flat;
            botonEditCurso.ForeColor = Color.White;
            botonEditCurso.Location = new Point(20, 195);
            botonEditCurso.Name = "btneditcurso" + count;
            botonEditCurso.Size = new Size(86, 30);
            botonEditCurso.Text = "Editar curso";
            botonEditCurso.UseVisualStyleBackColor = false;
            botonEditCurso.Click += button_Click_Editar;
            botonEditCurso.Tag = curso.IdCurso;

            Button botonBorrarCurso = new Button();
            botonBorrarCurso.BackColor = Color.FromArgb(192, 0, 0);
            botonBorrarCurso.FlatAppearance.BorderSize = 0;
            botonBorrarCurso.FlatStyle = FlatStyle.Flat;
            botonBorrarCurso.ForeColor = Color.White;
            botonBorrarCurso.Location = new Point(128, 195);
            botonBorrarCurso.Name = "btndeletecurso" + count;
            botonBorrarCurso.Size = new Size(86, 30);
            botonBorrarCurso.Text = "Eliminar Curso";
            botonBorrarCurso.UseVisualStyleBackColor = false;
            botonBorrarCurso.Tag = curso.IdCurso;
            botonBorrarCurso.Click += button_Click_Borrar;

            Button botonVergrupos = new Button();
            botonVergrupos.BackColor = Color.Gray;
            botonVergrupos.FlatAppearance.BorderSize = 0;
            botonVergrupos.FlatStyle = FlatStyle.Flat;
            botonVergrupos.ForeColor = Color.White;
            botonVergrupos.Location = new Point(20, 241);
            botonVergrupos.Name = "btnvergrupos" + count;
            botonVergrupos.Size = new Size(194, 30);
            botonVergrupos.Text = "Ver grupos";
            botonVergrupos.UseVisualStyleBackColor = false;
            botonVergrupos.Tag = curso.IdCurso;
            botonVergrupos.Click += buttongrupos_Click;
            
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(botonVergrupos);
            panel.Controls.Add(labelFechaFinText);
            panel.Controls.Add(labelFechaFin);
            panel.Controls.Add(labelFechaInicioText);
            panel.Controls.Add(labelFechaInicio);
            panel.Controls.Add(botonEditCurso);
            panel.Controls.Add(botonBorrarCurso);
            panel.Controls.Add(labelcategoriaText);
            panel.Controls.Add(labelCategoria);
            panel.Controls.Add(labelDescripcionText);
            panel.Controls.Add(labelDescripcion);
            panel.Controls.Add(labelNombreCurso);
            panel.Location = new Point(x, y);
            panel.Name = "pnlcurso" + count;
            panel.Size = new Size(230, 286);

            panel1.Controls.Add(panel);
        }
    }
}
