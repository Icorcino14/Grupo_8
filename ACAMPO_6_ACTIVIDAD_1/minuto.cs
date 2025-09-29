using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comida
{
    internal class deporte
    {
        // Método que calcula calorías quemadas en el ejercicio
        public int CaloriasQuemadas(int minutos, int caloriasPorMinuto)
        {
            // Multiplica minutos de ejercicio por calorías quemadas por minuto
            return minutos * caloriasPorMinuto;
        }
    }
}
