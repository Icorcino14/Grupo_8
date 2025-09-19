using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calificacion de nota:");
            Console.WriteLine("--------------------------");
            Console.WriteLine("ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("ingrese una calificacion");
            Console.WriteLine("--------------------------");
            string nota = Console.ReadLine();
            // ahora trabajamos con decimales
            double.TryParse(nota, out double calificacionDecimal);
            // Regla: si parte decimal < 0.5 queda igual, si es >= 0.5 aumenta en 1
            int calificacion = (int)calificacionDecimal;
            // parte entera
            double decimales = calificacionDecimal - calificacion;
            if (decimales >= 0.5)
            {
                calificacion++;
            }


            //validar rango
            // Validamos rango
            if (calificacion < 0 || calificacion > 20)
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es inválida.");
            }
            else if (calificacion <= 7)
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es deficiente.");
            }
            else if (calificacion <= 10)
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es mejorable.");
            }
            else if (calificacion <= 13)
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es regular.");
            }
            else if (calificacion <= 16)
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es buena.");
            }
            else // 17 - 20
            {
                Console.WriteLine($"{nombre}, su calificación {calificacion} es excelente.");
            }

            Console.ReadKey();
        }
    }
}

























          

   