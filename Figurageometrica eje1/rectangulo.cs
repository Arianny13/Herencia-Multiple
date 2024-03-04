using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurageometrica_eje1
{
    public class Rectangulo : Figurageometrica
    {
        public double LadoA {  get; set; }
        public double LadoB { get; set; }

        public override double CalcularArea()
        {
            return LadoA * LadoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (LadoA + LadoB);
        }
    }
}
