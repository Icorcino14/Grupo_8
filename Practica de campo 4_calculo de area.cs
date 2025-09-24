using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Program
    {

        public static double CalcularArea(double BaseRectangulo , double AltoRectangulo) // Se ingresa nombre de método Calcular área, se ingresa tipo de retorno double para el resultado del area del rectangulo
        {
            return (BaseRectangulo * AltoRectangulo); //se  indica la fórmula a usar para el cálculo del área del rectángulo
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del rectángulo: ");  //Solicitamos que ingresen la base del rectángulo
            string Base = Console.ReadLine();                       //Se lee lo ingresado
            Console.WriteLine("Ingrese el alto del rectángulo: ");  //Solicitamos que ingresen el alto del rectángulo
            string Alto = Console.ReadLine();                       //Se lee lo ingresado

            bool BaseValida = double.TryParse(Base, out double BaseRectangulo);     //Ingreso de los datos a la variable BaseRectangulo
            bool AltoValido = double.TryParse(Alto, out double AltoRectangulo);     //Ingreso de los datos a la variable AltoRectangulo

            //A continuación se realiza las validaciones de los datos ingresados por el usuario, si son datos invalidos 
            //se mostrará los siguientes mensajes de "El valor ingresado no es válido"
            
            if (BaseValida)
            {
                if (AltoValido)
                {
                    double area = CalcularArea(BaseRectangulo , AltoRectangulo);
                    Console.WriteLine("El área del rectángulo es:  " + area);
                }
                else
                {
                    Console.WriteLine("El valo ingresado para el alto no es válido");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado para la base no es válida");
            }
        }
    }
}
