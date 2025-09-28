using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISAEL_BAYLON
{
    class ProgramaGrupo
    {
        // Método con parámetro por valor
        static int Duplicar(int numero)
        {
            // Retorna el doble del valor enviado
            return numero * 2;
        }

        // Método con parámetro por referencia
        static void Incrementar(ref int numero)
        {
            // Modifica directamente el valor original
            numero += 10;
        }

        // Función propia con encabezado
        static string Saludar(string nombre)
        {
            // Devuelve un mensaje personalizado
            return $"Hola, {nombre}. Bienvenido al proyecto grupal.";
        }

        static void Main()
        {
            // Variable para pruebas
            int valor = 5;

            // Parámetro por valor
            int resultado = Duplicar(valor);
            Console.WriteLine($"El doble de {valor} es: {resultado}");

            // Parámetro por referencia
            Incrementar(ref valor);
            Console.WriteLine($"El valor incrementado es: {valor}");

            // Uso de función propia
            string mensaje = Saludar("Ana");
            Console.WriteLine(mensaje);
        }
    }
}
