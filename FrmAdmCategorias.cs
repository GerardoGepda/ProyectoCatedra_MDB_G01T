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
    public partial class FrmAdmCategorias : FrmBase
    {
        public FrmAdmCategorias()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Categoria.ExtraerCategorias();
        }

        private void FrmAdmCategorias_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            dgvCategorias.Columns[0].ReadOnly = true;
            dgvCategorias.Columns[1].ReadOnly = true;
            pnlActualizar.Visible = false;
            pnlCrear.Enabled = true;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnomcategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría no debe estar vacío, rellene el campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Categoria categoria = new Categoria();
                categoria.GenerarIDCategoria();
                categoria.Nombre = txtnomcategoria.Text;
                categoria.CrearCategoria();
                txtnomcategoria.Clear();
                ActualizarDataGrid();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnomcategoria.Clear();
            txtnomcategoria.Focus();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtupdatenomCate.Text))
            {
                MessageBox.Show("El nombre de la categoría no debe estar vacío, rellene el campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = btnactualizar.Tag.ToString();
                categoria.Nombre = txtupdatenomCate.Text;
                categoria.ActualizarCategoria();
                pnlActualizar.Visible = false;
                pnlCrear.Enabled = true;
                ActualizarDataGrid();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlCrear.Enabled = true;
        }

        private void dgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                DataGridViewRow selected = dgvCategorias.SelectedRows[0];
                DataGridViewCellCollection cells = selected.Cells;

                result = MessageBox.Show("¿Desea editar esta categoría?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    pnlActualizar.Visible = true;
                    pnlCrear.Enabled = false;
                    btnactualizar.Tag = cells[0].Value.ToString();
                    txtupdatenomCate.Text = cells[1].Value.ToString();
                }                
            }
            catch (Exception)
            {

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Realmente desea borrar esta categoría? tenga en cuenta que incluso se pueden borrar cursos y grupos automáticamente",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Categoria.BorrarCategoria(btnactualizar.Tag.ToString());
                pnlActualizar.Visible = false;
                pnlCrear.Enabled = true;
                ActualizarDataGrid();
            }
        }
    }
}
