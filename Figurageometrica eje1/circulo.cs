using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurageometrica_eje1
{
    public class Circulo : Figurageometrica
    {
        public double Radio { get; set; }         
    
        public override double CalcularArea ()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
