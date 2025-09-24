using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    internal class Program
    {
        public static bool PuedeVotar(int MayorEdad)
        {
            return MayorEdad >= 18 && MayorEdad <  120;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            string Edad = Console.ReadLine();

            if (int.TryParse(Edad, out int MayorEdad))
            {
                if (MayorEdad >=120)
                {
                    Console.WriteLine("¡Ingrese una edad válida!");
                }
                else if (PuedeVotar(MayorEdad))
                {
                    Console.WriteLine("¡Puede participar en las elecciones!");
                }
                else
                {
                    Console.WriteLine("¡No puede votar en las elecciones, debe tener al menos 18 años!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida debe ingresar una edad");
            }
        }        
    }
}
