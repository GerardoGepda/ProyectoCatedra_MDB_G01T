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
                if (columnas == 4)
                {
                    filas++;
                    y += 407;
                    x = 72;
                }
            }
        }

        private void CreateCursos(Curso curso, int count, int x, int y)
        {
            

            Label labelNombreCurso = new Label();
            labelNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            labelNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNombreCurso.ForeColor = System.Drawing.Color.White;
            labelNombreCurso.Location = new System.Drawing.Point(0, 0);
            labelNombreCurso.Name = "lblnombrecurso" + count;
            labelNombreCurso.Size = new System.Drawing.Size(229, 42);
            labelNombreCurso.Tag = "";
            labelNombreCurso.Text = curso.NombreCurso;
            labelNombreCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Label labelCategoria = new Label();
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelCategoria.Location = new System.Drawing.Point(19, 54);
            labelCategoria.Name = "lblcategoria" + count;
            labelCategoria.Size = new System.Drawing.Size(73, 15);
            labelCategoria.Text = "Categoría:";

            Label labelcategoriaText = new Label();
            labelcategoriaText.AutoSize = true;
            labelcategoriaText.Location = new System.Drawing.Point(103, 56);
            labelcategoriaText.Name = "lblcategoriatxt" + count;
            labelcategoriaText.Size = new System.Drawing.Size(62, 13);
            labelcategoriaText.Text = curso.IdCategoria;

            Label labelDescripcion = new Label();
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelDescripcion.Location = new System.Drawing.Point(19, 76);
            labelDescripcion.Name = "lbldescripcion" + count;
            labelDescripcion.Size = new System.Drawing.Size(87, 15);
            labelDescripcion.Text = "Descripción:";

            Label labelDescripcionText = new Label();
            labelDescripcionText.Location = new System.Drawing.Point(20, 95);
            labelDescripcionText.Name = "lbldescripciontxt" + count;
            labelDescripcionText.Size = new System.Drawing.Size(194, 34);
            labelDescripcionText.Text = curso.Descripcion;

            Label labelFechaInicio = new Label();
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelFechaInicio.Location = new System.Drawing.Point(20, 131);
            labelFechaInicio.Name = "lblfechainicio" + count;
            labelFechaInicio.Size = new System.Drawing.Size(89, 15);
            labelFechaInicio.Text = "Fecha inicio:";

            Label labelFechaInicioText = new Label();
            labelFechaInicioText.AutoSize = true;
            labelFechaInicioText.Location = new System.Drawing.Point(114, 133);
            labelFechaInicioText.Name = "lblfechainiciotxt" + count;
            labelFechaInicioText.Size = new System.Drawing.Size(62, 13);
            labelFechaInicioText.Text = curso.FechaInicio.ToString();

            Label labelFechaFin = new Label();
            labelFechaFin.AutoSize = true;
            labelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelFechaFin.Location = new System.Drawing.Point(20, 157);
            labelFechaFin.Name = "lblfechafin" + count;
            labelFechaFin.Size = new System.Drawing.Size(70, 15);
            labelFechaFin.Text = "Fecha fin:";

            Label labelFechaFinText = new Label();
            labelFechaFinText.AutoSize = true;
            labelFechaFinText.Location = new System.Drawing.Point(114, 159);
            labelFechaFinText.Name = "lblfechafintxt" + count;
            labelFechaFinText.Size = new System.Drawing.Size(62, 13);
            labelFechaFinText.Text = curso.FechaFin.ToString();

            Button botonEditCurso = new Button();
            botonEditCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            botonEditCurso.FlatAppearance.BorderSize = 0;
            botonEditCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonEditCurso.ForeColor = System.Drawing.Color.White;
            botonEditCurso.Location = new System.Drawing.Point(20, 195);
            botonEditCurso.Name = "btneditcurso" + count;
            botonEditCurso.Size = new System.Drawing.Size(86, 30);
            botonEditCurso.Text = "Editar curso";
            botonEditCurso.UseVisualStyleBackColor = false;

            Button botonBorrarCurso = new Button();
            botonBorrarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            botonBorrarCurso.FlatAppearance.BorderSize = 0;
            botonBorrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonBorrarCurso.ForeColor = System.Drawing.Color.White;
            botonBorrarCurso.Location = new System.Drawing.Point(128, 195);
            botonBorrarCurso.Name = "btndeletecurso" + count;
            botonBorrarCurso.Size = new System.Drawing.Size(86, 30);
            botonBorrarCurso.Text = "Eliminar Curso";
            botonBorrarCurso.UseVisualStyleBackColor = false;

            Button botonVergrupos = new Button();
            botonVergrupos.BackColor = System.Drawing.Color.Gray;
            botonVergrupos.FlatAppearance.BorderSize = 0;
            botonVergrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonVergrupos.ForeColor = System.Drawing.Color.White;
            botonVergrupos.Location = new System.Drawing.Point(20, 241);
            botonVergrupos.Name = "btnvergrupos" + count;
            botonVergrupos.Size = new System.Drawing.Size(194, 30);
            botonVergrupos.Text = "Ver grupos";
            botonVergrupos.UseVisualStyleBackColor = false;

            Panel panel = new Panel();
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            panel.Location = new System.Drawing.Point(x, y);
            panel.Name = "pnlcurso" + count;
            panel.Size = new System.Drawing.Size(230, 286);

            panel1.Controls.Add(panel);
        }

    }
}
