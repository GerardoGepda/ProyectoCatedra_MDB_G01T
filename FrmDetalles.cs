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
        public FrmDetalles(DetallesCurso detalles)
        {
            InitializeComponent();
            lblnombre.Text = detalles.NombreCurso;
            lbldescripcion.Text = detalles.Descripcion;
            lblgrupo.Text = detalles.Grupo;
            lblcupo.Text = detalles.Cupo;
            lbldia.Text = detalles.Dia;
            lblhorainicio.Text = detalles.Horainicio;
            lblhorafin.Text = detalles.Horafin;
            lblfechainicio.Text = detalles.Fechainicio.ToShortDateString();
            lblfechafin.Text = detalles.Fechafin.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
