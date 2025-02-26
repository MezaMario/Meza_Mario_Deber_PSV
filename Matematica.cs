using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculador
{
    class Matematica : Operacion
    {
        private int num1;
        private int num2;
        public Matematica(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Sumar()
        {
            return num1 + num2;
        }
        public int Restar()
        {
            return num1 - num2;
        }
        public int Multiplicar()
        {
            return num1 * num2;
        }
        public int Dividir()
        {
            return num1 / num2;
        }

        public int Divide()
        {
            return num1 % num2;

        }
    }
}
