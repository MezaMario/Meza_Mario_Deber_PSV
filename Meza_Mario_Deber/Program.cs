using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meza_Mario_Deber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool conti = true;

            while (conti)
            {
                Console.WriteLine("Selecciona una Opcion: ");
                Console.WriteLine("1. Imprime Numeros Pares(Sin if)");
                Console.WriteLine("2. Imprime Numeros Pares");
                Console.WriteLine("3. Numeros Divisibles para 3 y 5");
                Console.WriteLine("4. Imprime del 1 al 10 con While");
                Console.WriteLine("5. Imprime la Suma de los 1eros 100 Numeros Enteros");
                Console.WriteLine("6. Imprimie pares con Bucle While hasta el 100");
                Console.WriteLine("0. Salir");

                int opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        paresfr();
                        break;
                    case 2:
                        pares();
                        break;
                    case 3:
                        fizz();
                        break;
                    case 4:
                        buc();
                        break;
                    case 5:
                        summ();
                        break;
                    case 6:
                        val();
                        break;
                    case 0:
                        conti = false;
                        Console.WriteLine("Saliendo del Programa..");
                        break;
                    default:
                        Console.WriteLine("Opcion no Valida.");
                        break;
                }
                if (conti)
                {
                    Console.WriteLine("¿Deseas Continuar? (s/n)");
                    string respuuestaa = Console.ReadLine().ToLower();
                    if(respuuestaa != "s")
                    {
                        conti= false;
                        Console.WriteLine("Saliendo del Programa...");
                    }
                }
            }

        }
        static void paresfr()
        {
            /*1.	Imprimir los números pares que hay dentro
             * de los 100 primeros números enteros. No utilizar 
             * la estructura de control "if" para resolver este ejercicio.
             */
            int num = 100;
            for (int i = 0; i < num; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        static void pares()
        {
            /* 2. Imprimir los números pares que hay
            * dentro de los 100 primeros números enteros. 
            */
            int nu = 100;
            for (int i = 0; i <= nu; i++)
            {
                if (i % 2 == 0) // Comprueba si el número es par
                {
                    Console.WriteLine(i); // Imprime el número par
                }
            }

        }
        static void fizz()
        {
            /*3.	Imprimir los números del 1 al 50:
              a.	Para números divisibles por 3, imprima "Fizz".
              b.	Para números divisibles por 5, imprima "Buzz".
              c.	Para números divisibles por 3 y 5, imprime "FizzBuzz".
              d.	En cualquier otro caso, imprima el número. 
             */
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void buc()
        {
            /*
             * 4.	Imprime los números del 
             * 1 al 10 utilizando un bucle " while ".
             */
            int u = 0;
            while (u <= 10)
            {
                Console.WriteLine(u);
                u++;
            }
        }
        static void summ()
        {
            /*5.	Calcula la suma de los primeros 100 
             * números enteros utilizando un bucle " while ". 
             */
            int i = 1;
            int suma = 0;
            while (i <= 100)
            {
                suma += i;
                i++;
            }
            Console.WriteLine($"La Suma de los primeros 100 numeros Enteros es: {suma}");
        }
        static void val()
        {
            /*6.	Imprimir los números pares que 
             * hay dentro de los 100 primeros números 
             * enteros utilizando un bucle " while ". 
             */
            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
}
