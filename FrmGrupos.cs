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
    public partial class FrmGrupos : FrmBase
    {
        private string idCurso;
        private List<Grupo> grupos;
        private List<Maestro> maestros;

        public FrmGrupos(string idCurso)
        {
            InitializeComponent();
            this.idCurso = idCurso;
        }

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

        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            grupos = Grupo.ExtraerGrupos(idCurso);
            foreach (Grupo item in grupos)
            {
                cbxgrupo.Items.Add(item.IdGrupo);
            }
            maestros = Maestro.ExtraerMaestros();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (cbxgrupo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista para poder mostrarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Grupo grupo = grupos.Find(x => x.IdGrupo == cbxgrupo.SelectedItem.ToString());
                txtidGrupo.Text = grupo.IdGrupo;
                txtcupo.Text = grupo.Cupo.ToString();
                txtcurso.Text = grupo.CursoGrupo.NombreCurso;
                foreach (Maestro item in maestros)
                {
                    cbxMaestro.Items.Add(item.Nombre + " " + item.Apellido);
                }
                cbxMaestro.SelectedIndex = cbxMaestro.FindString(grupo.MaestroGrupo.Nombre + " " + grupo.MaestroGrupo.Apellido);
                dgvhorarios.DataSource = grupo.Horarios;
                dgvhorarios.Columns["IDGrupo"].Visible = false;

                //habilitamos el panel de edición
                pnlActualizar.Enabled = true;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (validarGrupo())
            {
                DialogResult result;
                result = MessageBox.Show($"¿Realmente desea actualizar el grupo {txtidGrupo.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    string idMaestro = maestros.Find(x => x.Nombre + " " + x.Apellido == cbxMaestro.SelectedItem.ToString()).IdMatestro;
                    grupos.Find(x => x.IdGrupo == txtidGrupo.Text).Cupo = Convert.ToInt32(txtcupo.Text);
                    grupos.Find(x => x.IdGrupo == txtidGrupo.Text).IdMaestro = idMaestro;
                    grupos.Find(x => x.IdGrupo == txtidGrupo.Text).ActualizarGrupo();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarGrupo()
        {
            if (string.IsNullOrEmpty(txtcupo.Text))
                return false;
            else
                return true;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"¿Realmente desea borrar el grupo {txtidGrupo.Text}?, esto podría traer problemas", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                grupos.Find(x => x.IdGrupo == txtidGrupo.Text).BorrarGrupo();
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarGrupo();
            LimpiarHorario();
            pnlActualizar.Enabled = false;
            pnlacthorario.Enabled = false;
            dgvhorarios.DataSource = null;
            cbxgrupo.SelectedIndex = -1;
        }

        private void dgvhorarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                DataGridViewRow selected = dgvhorarios.SelectedRows[0];
                DataGridViewCellCollection cells = selected.Cells;

                result = MessageBox.Show("¿Desea editar este horario?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    pnlacthorario.Enabled = true;
                    txtidhorario.Text = cells["IdHorario"].Value.ToString();
                    cbxdias.SelectedIndex = cbxdias.FindString(cells["Dia"].Value.ToString());
                    dtphorainicio.Value = Convert.ToDateTime(cells["HoraInicio"].Value.ToString());
                    dtphorafin.Value = Convert.ToDateTime(cells["HoraFin"].Value.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void LimpiarGrupo()
        {
            txtidGrupo.Clear();
            txtcupo.Clear();
            txtcurso.Clear();
            cbxMaestro.DataSource = null;
        }

        private void LimpiarHorario()
        {
            txtidhorario.Clear();
            cbxdias.DataSource = null;
            cbxdias.SelectedIndex = -1;
            dtphorainicio.Value = DateTime.Now;
            dtphorafin.Value = DateTime.Now;
        }

        private bool validarHorario()
        {
            bool validado = true;
            TimeSpan horaInicio = dtphorainicio.Value.TimeOfDay;
            TimeSpan horaFin = dtphorafin.Value.TimeOfDay;
            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora de finalización no puede ser igual o menor a la hora de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validado = false;
            }
            return validado;
        }

        private void btnupdatehorario_Click(object sender, EventArgs e)
        {
            if (validarHorario())
            {
                DialogResult result;
                result = MessageBox.Show($"¿Realmente desea actualizar el horario {txtidhorario.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Horario horario = new Horario
                    {
                        IdHorario = txtidhorario.Text,
                        IdGrupo = txtidGrupo.Text,
                        Dia = cbxdias.SelectedItem.ToString(),
                        HoraInicio = dtphorainicio.Value.TimeOfDay,
                        HoraFin = dtphorafin.Value.TimeOfDay
                    };
                    horario.ActualizarHorario();
                    grupos.Find(x => x.IdGrupo == txtidGrupo.Text).Horarios = Horario.ExtraerHorariosGrupo(txtidGrupo.Text);
                    dgvhorarios.DataSource = null;
                    dgvhorarios.DataSource = grupos.Find(x => x.IdGrupo == txtidGrupo.Text).Horarios;
                    LimpiarHorario();
                    pnlacthorario.Enabled = false;
                }
            }
        }

        private void btnborrarhorario_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"¿Realmente desea borrar el horario {txtidhorario.Text}?, esto podría traer problemas", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Horario.BorrarHorario(txtidhorario.Text);
                grupos.Find(x => x.IdGrupo == txtidGrupo.Text).Horarios = Horario.ExtraerHorariosGrupo(txtidGrupo.Text);
                dgvhorarios.DataSource = null;
                dgvhorarios.DataSource = grupos.Find(x => x.IdGrupo == txtidGrupo.Text).Horarios;
                LimpiarHorario();
                pnlacthorario.Enabled = false;
            }
        }

        private void btncancelarhorario_Click(object sender, EventArgs e)
        {
            LimpiarHorario();
            pnlacthorario.Enabled = false;
        }
    }
}
