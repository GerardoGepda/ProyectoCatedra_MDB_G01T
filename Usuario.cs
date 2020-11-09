using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra_MDB_G01T
{
    public class Usuario
    {
        //campos o variables
        private string nombre;
        private string apellido;

        //Propiedades o atributos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
