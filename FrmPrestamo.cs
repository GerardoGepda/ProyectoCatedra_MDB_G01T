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
    public partial class FrmPrestamo : Form
    {
        private string idAlumno;
        private List<Material> materiales = Material.extraerMateriales();

        public FrmPrestamo(string idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            //configuración para el comboBox
            List<string> nombreMateriales = new List<string>();
            foreach (var item in materiales)
            {
                nombreMateriales.Add(item.Nombre);
            }
            cbxmateriales.DataSource = nombreMateriales;
            cbxmateriales.SelectedIndex = -1;

            //configuración para el dataGridView
            dgvPrestamos.DataSource = Prestamo.ExtraerPrestamos(idAlumno);
            dgvPrestamos.Columns["IDAlumno"].Visible = false;
            dgvPrestamos.Columns["IDMaterial"].Visible = false;
        }

        private void cbxmateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en base al index de combobox buscamos las unidades del material para ponerlas en el label
            if (cbxmateriales.SelectedIndex != -1)
                lblcantidad.Text = materiales.Find(x => x.Nombre == cbxmateriales.SelectedItem.ToString()).UnidadesDisponibles.ToString();
            else
                lblcantidad.Text = "Vacío";
        }

        private void btnprestar_Click(object sender, EventArgs e)
        {
            DateTime tiempo = DateTime.Now;
            string fecha;
            if (cbxmateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento para realizar su prestamo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //creamos instancia de Prestamo y calculamos la fecha de devolución
                fecha = tiempo.AddDays(2).GetDateTimeFormats()[0].ToString();
                Prestamo prestamo = new Prestamo();
                prestamo.GenerarIDPrestamo();
                prestamo.FechaDevolución = fecha;
                prestamo.IdMaterial = materiales.Find(x => x.Nombre == cbxmateriales.SelectedItem.ToString()).IdMaterial;
                prestamo.IdAlumno = idAlumno;
                prestamo.crearPrestamo();

                //limpiamos controles
                cbxmateriales.SelectedIndex = -1;
                lblcantidad.Text = "Vacío";
                //actualizamos dgv
                ActulizarDgv();
            }
        }

        private void btnborrarselec_Click(object sender, EventArgs e)
        {
            cbxmateriales.SelectedIndex = -1;
            lblcantidad.Text = "Vacío";
        }

        private void ActulizarDgv()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = Prestamo.ExtraerPrestamos(idAlumno);
            dgvPrestamos.Columns["IDAlumno"].Visible = false;
            dgvPrestamos.Columns["IDMaterial"].Visible = false;
        }

        private void btnactualizaedgv_Click(object sender, EventArgs e)
        {
            ActulizarDgv();
        }

        private void dgvPrestamos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string prestamoID, prestamoNombre;
                DataGridViewRow selected = dgvPrestamos.SelectedRows[0];
                DataGridViewCellCollection cells = selected.Cells;
                prestamoID = cells[0].Value.ToString();
                prestamoNombre = cells["NombreMaterial"].Value.ToString();
                if (MessageBox.Show($"¿Desea borrar el prestamo de {prestamoNombre}?", "Aviso", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Prestamo.cancelarPrestamo(prestamoID);
                    ActulizarDgv();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ninguna opción para esta acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
