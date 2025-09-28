using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVAN_CORCINO
{
    class Programa
    {
        // Método que recibe parámetro por valor
        static void IncrementarPorValor(int numero)
        {
            numero = numero + 1;
            Console.WriteLine("Dentro de IncrementarPorValor: " + numero);
        }

        // Método que recibe parámetro por referencia
        static void IncrementarPorReferencia(ref int numero)
        {
            numero = numero + 1;
            Console.WriteLine("Dentro de IncrementarPorReferencia: " + numero);
        }

        static void Main(string[] args)
        {
            int numero = 5;

            Console.WriteLine("Valor original: " + numero);

            IncrementarPorReferencia(ref numero);
            Console.WriteLine("Después de IncrementarPorReferencia: " + numero);

            IncrementarPorValor(numero);
            Console.WriteLine("Después de IncrementarPorValor: " + numero);
                       
        }
    }

}
