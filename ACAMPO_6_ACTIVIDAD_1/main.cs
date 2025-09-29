using ACTIVIDAD_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia tu biblioteca Nutricion
            Nutricion nutri = new Nutricion();
            int total = nutri.CalcularCalorias(5, 350);

            // Instancia tu biblioteca deporte
            deporte depor = new deporte();
            int total2 = depor.CaloriasQuemadas(60, 10);

            // Instancia tu biblioteca propia Salud
            Salud salud = new Salud();
            double imc = salud.IndiceMasaCorporal(70, 1.75);

            Console.WriteLine("=== PROGRAMA DE NUTRICIÓN ===");
            Console.WriteLine($"Comidas: 5");
            Console.WriteLine($"Calorías por comida: 350");
            Console.WriteLine($"Calorías totales: {total}");

            Console.WriteLine("=== PROGRAMA DE DEPORTE ===");
            Console.WriteLine($"Minutos de ejercicio: 60");
            Console.WriteLine($"Calorías quemadas por minuto: 10");
            Console.WriteLine($"Calorías totales quemadas: {total2}");

            Console.WriteLine("=== SALUD ===");
            Console.WriteLine($"IMC (70kg, 1.75m): {imc}");

            //--Resultado combinado--
            int resultadoFinal = total - total2;
            Console.WriteLine("=== RESULTADO FINAL ===");
            Console.WriteLine($"Calorias netas: {resultadoFinal}");
            Console.ReadKey();
        }
    }
}
