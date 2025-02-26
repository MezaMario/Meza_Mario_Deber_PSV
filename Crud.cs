using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculador
{
    public class Crud
    {
        public List<ingreso> lista = new List<ingreso>();

        public void agregar(ingreso persona)
        {
            lista.Add(persona);
        }
    }
}
