using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerci4
{

    using System;

    class Punto
    {
        // Atributos privados
        private double x;
        private double y;

        // Constructor por defecto
        public Punto()
        {
            x = 0;
            y = 0;
        }

        // Constructor con parámetros
        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Métodos para obtener los valores
        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        // Métodos para establecer los valores
        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        // Método para mostrar el punto
        public void MostrarPunto()
        {
            Console.WriteLine($"Punto: ({x}, {y})");
        }
    }

    // Programa principal para probar la clase
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un punto usando el constructor por defecto
            Punto punto1 = new Punto();
            punto1.MostrarPunto();

            // Establecer valores para el punto
            punto1.SetX(5);
            punto1.SetY(7);
            punto1.MostrarPunto();

            // Crear un punto usando el constructor con parámetros
            Punto punto2 = new Punto(3.5, -4.2);
            punto2.MostrarPunto();

            // Obtener y mostrar valores individuales
            Console.WriteLine($"Coordenada X de punto2: {punto2.GetX()}");
            Console.WriteLine($"Coordenada Y de punto2: {punto2.GetY()}");
        }
    }
}

