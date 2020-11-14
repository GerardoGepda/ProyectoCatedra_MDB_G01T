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
    public partial class FrmAddHorario : FrmBase
    {
        public bool fromGrupo = false;
        public string idGrupo;

        public FrmAddHorario()
        {
            InitializeComponent();
        }

        private void FrmAddHorario_Load(object sender, EventArgs e)
        {
            cbxidgrupo.DataSource = Grupo.IDsGrupo();
            cbxidgrupo.SelectedIndex = -1;
            if (fromGrupo)
            {
                cbxidgrupo.SelectedIndex = cbxidgrupo.FindString(idGrupo);
                cbxidgrupo.Enabled = false;
                lbltitulo.Text = "Creando nuevo horario para el grupo " + idGrupo;
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Horario horario = new Horario();
                horario.GenerarIDHorario();
                horario.IdGrupo = cbxidgrupo.SelectedItem.ToString();
                horario.Dia = cbxdias.SelectedItem.ToString();
                horario.HoraInicio = dtphorainicio.Value.TimeOfDay;
                horario.HoraFin = dtphorafin.Value.TimeOfDay;
                horario.CrearHorario();
                this.Close();
            }
        }

        private bool validar()
        {
            bool validado = true;
            TimeSpan horaInicio = dtphorainicio.Value.TimeOfDay;
            TimeSpan horaFin = dtphorafin.Value.TimeOfDay;

            if (cbxdias.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccionar un día", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbxidgrupo.SelectedIndex == -1)
            {
                validado = false;
                MessageBox.Show("Debe seleccioanr un grupo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora de finalización no puede ser igual o menor a la hora de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validado = false;
            }
            return validado;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (!fromGrupo)
            {
                cbxidgrupo.SelectedIndex = -1;
            }
            cbxdias.SelectedIndex = -1;
            dtphorainicio.Value = DateTime.Now;
            dtphorafin.Value = DateTime.Now;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (fromGrupo)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente quieres salir de esta ventana sin haber creado un horario pera el grupo creado?", 
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
