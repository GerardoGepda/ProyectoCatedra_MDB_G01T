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
    public partial class FrmDetalles : Form
    {
        //private Grupo grupo;

        public FrmDetalles(Grupo grupo)
        {
            InitializeComponent();
            lblnombre.Text = grupo.CursoGrupo.NombreCurso;
            lbldescripcion.Text = grupo.CursoGrupo.Descripcion;
            lblgrupo.Text = grupo.IdGrupo;
            lblcupo.Text = grupo.Cupo.ToString();
            dgvhorarios.DataSource = grupo.Horarios;
            dgvhorarios.Columns["IDGrupo"].Visible = false;
            lblfechainicio.Text = grupo.CursoGrupo.FechaInicio.ToShortDateString();
            lblfechafin.Text = grupo.CursoGrupo.FechaFin.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
