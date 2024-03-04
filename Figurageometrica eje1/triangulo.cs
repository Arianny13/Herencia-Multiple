using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurageometrica_eje1
{
    public class Triangulo : Figurageometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura / 2.0;
        }

        public override double CalcularPerimetro()
        {
           
            double catetoOpuesto = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            return Base + Altura + catetoOpuesto;
        }
    }
}
