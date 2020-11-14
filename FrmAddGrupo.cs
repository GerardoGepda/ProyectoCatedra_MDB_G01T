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
    public partial class FrmAddGrupo : FrmBase
    {
        private Grupo grupo = new Grupo();
        private List<Curso> cursos = new List<Curso>();
        private List<Maestro> maestros = new List<Maestro>();

        public FrmAddGrupo()
        {
            InitializeComponent();
        }

        private string identificador;

        public string Identificador { get => identificador; set => identificador = value; }

        private void txtOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private bool Validar()
        {
            bool validado = true;

            if (string.IsNullOrEmpty(txtcupo.Text) || string.IsNullOrWhiteSpace(txtcupo.Text))
            {
                validado = false;
                MessageBox.Show("Debe ingresar un dato valido en el Cupo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbxcursos.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccioanr un curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbxmaestros.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar un maestro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validado;
        }

        private void FrmAddGrupo_Load(object sender, EventArgs e)
        {
            cursos = Curso.ExtraerCursos();
            maestros = Maestro.ExtraerMaestros();
            grupo.GenerarIDGrupo();
            txtidgrupo.Text = grupo.IdGrupo;
            foreach (Curso item in cursos)
            {
                cbxcursos.Items.Add(item.NombreCurso);
            }
            foreach (Maestro item in maestros)
            {
                cbxmaestros.Items.Add(item.Nombre + " " + item.Apellido);
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                grupo.Cupo = Convert.ToInt32(txtcupo.Text);
                grupo.IdCurso = cursos.Find(x => x.NombreCurso == cbxcursos.SelectedItem.ToString()).IdCurso;
                grupo.IdMaestro = maestros.Find(x => x.Nombre + " " + x.Apellido == cbxmaestros.SelectedItem.ToString()).IdMatestro;
                grupo.CrearGrupo();
                MessageBox.Show("Recuerde que debe crear un horario para este grupo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Identificador = grupo.IdGrupo;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcupo.Clear();
            cbxcursos.SelectedIndex = -1;
            cbxmaestros.SelectedIndex = -1;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
