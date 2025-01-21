using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Números pares dentro de los 100 primeros números sin usar "if"
            Console.WriteLine("Ejercicio 1: Números pares dentro de los 100 primeros números");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            // Ejercicio 2: Números pares dentro de los 100 primeros números usando "if"
            Console.WriteLine("\nEjercicio 2: Números pares dentro de los 100 primeros números");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Ejercicio 3: FizzBuzz
            Console.WriteLine("\nEjercicio 3: FizzBuzz del 1 al 50");
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

            // Ejercicio 4: Números del 1 al 10 con un bucle "while"
            Console.WriteLine("\nEjercicio 4: Números del 1 al 10 con un bucle while");
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            // Ejercicio 5: Suma de los primeros 100 números enteros con "while"
            Console.WriteLine("\nEjercicio 5: Suma de los primeros 100 números enteros con while");
            int suma = 0;
            int contador = 1;
            while (contador <= 100)
            {
                suma += contador;
                contador++;
            }
            Console.WriteLine($"La suma de los primeros 100 números enteros es: {suma}");

            // Ejercicio 6: Números pares dentro de los 100 primeros números con "while"
            Console.WriteLine("\nEjercicio 6: Números pares dentro de los 100 primeros números con while");
            int par = 2;
            while (par <= 100)
            {
                Console.WriteLine(par);
                par += 2;
            }

            // Pausa para mantener la consola abierta
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}