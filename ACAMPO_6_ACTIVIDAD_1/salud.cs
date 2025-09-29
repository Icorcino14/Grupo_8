using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD_1
{
    public class Salud
    {
        // Método que calcula el índice de masa corporal (IMC)
        public double IndiceMasaCorporal(double pesoKg, double alturaM)
        {
            // Fórmula IMC = peso / (altura * altura)
            return pesoKg / (alturaM * alturaM);
        }
    }
}
