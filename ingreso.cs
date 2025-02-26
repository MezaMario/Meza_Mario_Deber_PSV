using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculador
{
    public class ingreso
    {
        public string nombre;
        public string apellido;
        public int cedula;
        public int edad;
        public string ciudad;

        public ingreso(string nombre, string apellido, int cedula, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.edad = edad;
            this.ciudad = ciudad;
        }

    }
}
