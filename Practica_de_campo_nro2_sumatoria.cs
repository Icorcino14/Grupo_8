using System;

namespace sumatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sumatoria de números: ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ingrese un número: ");
            string numero = Console.ReadLine();
            // ahora trabajemos con enteros
            int.TryParse(numero, out int numeroEntero);
            int suma = 0;
            Console.WriteLine("-------------------------: ");
            Console.WriteLine("La respuesta es: ");
            for (int i = 1; i <= numeroEntero; i++)
            {
                suma += i; // suma = suma + i
                
                Console.WriteLine($"La sumatoria hasta {i} es: {suma} ");
               
            }
            Console.ReadKey();

        }

    }
}
