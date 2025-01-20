using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             */
            string contin = "s";
            while (contin == "s")
            {
                Console.WriteLine("Ejercicios 2, Selecciona una Opcion: ");
                Console.WriteLine("1 - programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.");
                Console.WriteLine("2 - programa que solicita al usuario ingresar una calificación y luego muestre un mensaje según la calificación ingresada. ");
                Console.WriteLine("3 - programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra. ");
                Console.WriteLine("4 - programa que solicite al usuario ingresar un número del 1 al 7 y luego muestre el día de la semana correspondiente. ");
                Console.WriteLine("5 - 5.\tIngresar 2 números y luego un carácter indicando la operación a realizar (+, -, *, /)");
                int ejer = int.Parse(Console.ReadLine());
                switch (ejer)
                {
                    case 1:
                        mameque();
                        break;
                    case 2:
                        cali();
                        break;
                    case 3:
                        mayoque();
                        break;
                    case 4:
                        seman();
                        break;
                    case 5:
                        calc();
                        break;

                }
                Console.WriteLine("Quiere Ejecutar otro Ejercicio s/n");
                contin = Console.ReadLine().ToLower();


            }

        }
        static void mameque()
        {
            Console.WriteLine("Por Favor Ingresa un Numero para Verificar si es positivo, negativo o cero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine($"El numero ingresado {numero}, es igual a 0");

            }
            else if (numero > 0)
            {
                Console.WriteLine($"El numero ingresado {numero}, es Positivo. ");
            }
            else
            {
                Console.WriteLine($"El numero ingresado {numero}, es negativo. ");
            }
        }
        static void cali()
        {
            Console.WriteLine("Ingresa La Nota range(1-100): ");
            int num= int.Parse(Console.ReadLine());
            if (num >= 60 && num <=100)
            {
                Console.WriteLine($"Felicidades has Aprobado tu nota es {num}");
            }
            else if(num < 60 && num > 0)
            {
                Console.WriteLine($"Lo Sentimos has Reprobado tu nota es {num}");
            }
            else
            {
                Console.WriteLine($"Numero fuera de Rango{num} favor Ingresa un Numero Valido");
            }
        }
        static void mayoque()
        {
            Console.WriteLine("Ingresa un Numero Para verificar si es mayor a 10 entre 10 y 20 o mayor a 20");
            int num = int.Parse(Console.ReadLine());
            if (num < 10)
            {
                Console.WriteLine("EL numero es menor a 10");
            }
            else if(num >= 10 && num <= 20)
            {
                Console.WriteLine("El numero se encuentra entre 10 y 20");

            }
            else
            {
                Console.WriteLine("El Numero es Mayor a 20");
            }

        }
        static void seman()
        {
            Console.WriteLine("Ingresa un Numero entre el 1 al 7 a relacion si es uno lunes, etc ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0 && num >= 8)
            {
                Console.WriteLine("Numero Invalido");
            }
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;


            }
            
        }
        static void calc()
        {
            Console.WriteLine("Ingresa dos Numeros y selecciona una Operacion");
            Console.WriteLine("Ingresa el 1er Numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el 2do Numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona una Operacion: ");
            Console.WriteLine("Suma = 1");
            Console.WriteLine("resta = 2");
            Console.WriteLine("Multiplicacion = 3");
            Console.WriteLine("Division = 4");
            int opee = int.Parse(Console.ReadLine());
            switch (opee)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine( num1 / num2);
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}
