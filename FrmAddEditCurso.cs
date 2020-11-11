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
    public partial class FrmAddEditCurso : FrmBase
    {
        public Curso curso;
        public bool actualizar = false;
        private List<Categoria> categorias;

        public FrmAddEditCurso()
        {
            InitializeComponent();
        }

        private void FrmAddEditCurso_Load(object sender, EventArgs e)
        {
            //obtenemos las categorias en BD
            //Creamos una lista que guardará solo los nombres de las categorías
            List<string> NombreCategorias = new List<string>();
            categorias = Categoria.ExtraerCategorias();
            foreach (Categoria item in categorias)
            {
                NombreCategorias.Add(item.Nombre);
            }
            //ponemos los nombres en el comboBox
            cbxcategoria.DataSource = NombreCategorias;
            cbxcategoria.SelectedIndex = -1;

            //evaluamos si se creará o actualizará un curso
            if (actualizar)
            {
                lbltitulo.Text = "Actualizar curso";
                btnCrearActualizar.Text = "Actualizar curso";
                txtnomcurso.Text = curso.NombreCurso;
                txtdescripcion.Text = curso.Descripcion;
                dtpfechainicio.Value = curso.FechaInicio.Date;
                dtpfechafin.Value = curso.FechaFin.Date;
                cbxcategoria.SelectedIndex = cbxcategoria.FindString(categorias.Find(x => x.IdCategoria == curso.IdCategoria).Nombre);
            }
        }

        private void btnCrearActualizar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                double weeks = (dtpfechafin.Value.Date - dtpfechainicio.Value.Date).TotalDays / 7;

                Curso nuevoCurso = new Curso();
                if (actualizar)
                    nuevoCurso.IdCurso = curso.IdCurso;
                else
                    nuevoCurso.GenerarIDCurso();
                nuevoCurso.NombreCurso = txtnomcurso.Text;
                nuevoCurso.Descripcion = txtdescripcion.Text;
                nuevoCurso.DuracionSemanas = Convert.ToInt32(weeks);
                nuevoCurso.FechaInicio = dtpfechainicio.Value;
                nuevoCurso.FechaFin = dtpfechafin.Value;
                nuevoCurso.IdCategoria = categorias.Find(x => x.Nombre == cbxcategoria.SelectedItem.ToString()).IdCategoria;
                if (actualizar)
                    nuevoCurso.ActualizarCurso();
                else
                    nuevoCurso.CrearCurso();

                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            bool validado = true;
            if (string.IsNullOrEmpty(txtnomcurso.Text) || string.IsNullOrEmpty(txtdescripcion.Text))
            {
                MessageBox.Show("No puede dejar campos vacíos, por favor complete el formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validado = false;
            }

            if (dtpfechafin.Value <= dtpfechainicio.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validado = false;
            }

            if (cbxcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccioando ninguna ategoría para su curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validado = false;
            }
            return validado;
        }
    }
}
