using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comida
{
    internal class Nutricion
    {
        // Método que recibe parámetros para calcular calorías totales
        public int CalcularCalorias(int comidas, int caloriasPorComida)
        {
            // Multiplica cantidad de comidas por calorías de cada una
            return comidas * caloriasPorComida;
        }
    }
}
