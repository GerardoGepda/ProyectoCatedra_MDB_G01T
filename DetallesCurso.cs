using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra_MDB_G01T
{
    public class DetallesCurso
    {
        private string nombreCurso;
        private string descripcion;
        private string grupo;
        private string cupo;
        private string dia;
        private string horainicio;
        private string horafin;
        private DateTime fechainicio;
        private DateTime fechafin;

        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Cupo { get => cupo; set => cupo = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Horainicio { get => horainicio; set => horainicio = value; }
        public string Horafin { get => horafin; set => horafin = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
    }
}
