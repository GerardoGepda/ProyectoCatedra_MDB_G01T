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
    public partial class MainAdm : Main
    {
        public MainAdm()
        {
            InitializeComponent();
        }

        public override void Main_Load(object sender, EventArgs e)
        {
            openForm();
        }

        private void openForm()
        {
            Form formulario;
            formulario = pnlprincipal.Controls.OfType<FrmAdmCursos>().FirstOrDefault(); //busca formulario abierto para usar ese
            //si no existe
            if (formulario == null)
            {
                formulario = new FrmAdmCursos();
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

    }
}
