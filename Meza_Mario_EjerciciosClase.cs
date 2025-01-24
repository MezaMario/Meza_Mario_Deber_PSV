using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Main Principal donde van los metodos.
             */
            string conti= "s";
            while (conti == "s")
            {
                Console.WriteLine("Elija un ejercicio: ");
                Console.WriteLine("1. Mayor de dos numeros");
                Console.WriteLine("2. Par o impar");
                Console.WriteLine("3. Dia de la semana");
                Console.WriteLine("4. Adivina un numero");
                Console.WriteLine("5. Calificacion");
                Console.WriteLine("6. Edad");
                Console.WriteLine("7. Salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        mayormenor();
                        break;
                    case 2:
                        parimpar();
                        break;
                    case 3:
                        diasemana();
                        break;
                    case 4:
                        adivinanum();
                        break;
                    case 5:
                        calificacion();
                        break;
                    case 6:
                        edad();
                        break;
                    case 7:
                        conti = "n";
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        static void adivinanum()
        {
            /*
             * Metodo que adivina un numero entre 1 y 100
             */
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            int num2 = 0;
            int intentos = 0;
            while (num != num2)
            {
                Console.WriteLine("Ingrese un numero entre 1 y 100");
                num2 = int.Parse(Console.ReadLine());
                if (num2 < num)
                {
                    Console.WriteLine("El numero es mayor");
                }
                else if (num2 > num)
                {
                    Console.WriteLine("El numero es menor");
                }
                intentos++;
            }
            Console.WriteLine("Felicidades adivinaste el numero en " + intentos + " intentos");
        }
        static void edad()
        {
            /*
             * Escribe un programa que pida la edad del usuario y determine si puede votar (mayor o igual a 18 años).
             */
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    Console.WriteLine("Puede votar");
                }
                else
                {
                    Console.WriteLine("No puede votar");
                }
                Console.WriteLine("Desea ingresar otra edad? s/n");
                continuar = Console.ReadLine().ToLower();
            }

        }
        static void calificacion()
        {
            /*
             *Escribe un programa que convierta una calificación numérica (0-100) 
             */

            string continuar = "s";

            while (continuar == "s")
            {
                Console.WriteLine("Ingrese su calificacion: ");
                int calificacion = int.Parse(Console.ReadLine());
                if (calificacion >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (calificacion >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (calificacion >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (calificacion >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
                Console.WriteLine("Desea ingresar otra calificacion? s/n");
                continuar = Console.ReadLine().ToLower();

            }
        }
        static void parimpar()
        {
            /*
             * Pide al usuario un número entero y determina si es par o impar
             */
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Ingrese un numero entero: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
                Console.WriteLine("Desea ingresar otro numero? s/n");
                continuar = Console.ReadLine().ToLower();
            }
        }
        static void mayormenor()
        {
            /*
             * Pide al usuario dos números enteros y determina cuál es el mayor
             */
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Ingrese un numero entero: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero entero: ");
                int num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine("El numero " + num1 + " es mayor que " + num2);
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("El numero " + num2 + " es mayor que " + num1);
                }
                else
                {
                    Console.WriteLine("Los numeros son iguales");
                }
                Console.WriteLine("Desea ingresar otros numeros? s/n");
                continuar = Console.ReadLine().ToLower();
            }
        }
        static void diasemana()
        {
            /*
             * Pide al usuario un número entre 1 y 7 e imprime el día de la semana correspondiente
             */
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Ingrese un numero entre 1 y 7: ");
                int num = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("Numero invalido");
                        break;
                }
                Console.WriteLine("Desea ingresar otro numero? s/n");
                continuar = Console.ReadLine().ToLower();
            }
        }
    }
}
