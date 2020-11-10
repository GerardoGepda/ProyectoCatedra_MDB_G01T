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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcarnet.Text))
            {
                MessageBox.Show("No puede dejar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Alumno alumno = new Alumno();
                if (alumno.extraerUsuario(txtcarnet.Text.ToUpper()))
                {
                    Main main = new Main();
                    main.alumno = alumno;
                    main.Show();
                    this.Hide();
                }
                else
                {
                    Console.WriteLine("fallo");
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            MainAdm main = new MainAdm();
            main.Show();
            this.Hide();
        }
    }
}
