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
    public partial class Main : Form
    {
        public Alumno alumno = new Alumno();
        public Main()
        {
            InitializeComponent();
        }

        public virtual void Main_Load(object sender, EventArgs e)
        {
            openForm();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openForm()
        {
            Form formulario;
            formulario = pnlprincipal.Controls.OfType<FrmInscripcion>().FirstOrDefault(); //busca formulario abierto para usar ese
            //si no existe
            if (formulario == null)
            {
                formulario = new FrmInscripcion(alumno);
                formulario.TopLevel = false;
                pnlprincipal.Controls.Add(formulario);
                pnlprincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //si el formulario existe
                formulario.BringToFront();
            }
        }


        private void btninscripcion_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            Form formulario;
            formulario = pnlprincipal.Controls.OfType<FrmCursos>().FirstOrDefault(); //busca formulario abierto para usar ese
            //si no existe
            if (formulario == null)
            {
                formulario = new FrmCursos(alumno);
                formulario.TopLevel = false;
                pnlprincipal.Controls.Add(formulario);
                pnlprincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //si el formulario existe
                formulario.BringToFront();
            }
        }

        private void btnprestamo_Click(object sender, EventArgs e)
        {
            Form formulario;
            formulario = pnlprincipal.Controls.OfType<FrmPrestamo>().FirstOrDefault(); //busca formulario abierto para usar ese
            //si no existe
            if (formulario == null)
            {
                formulario = new FrmPrestamo(alumno.IdAlumno);
                formulario.TopLevel = false;
                pnlprincipal.Controls.Add(formulario);
                pnlprincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //si el formulario existe
                formulario.BringToFront();
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
