using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Triangulo:Figura
    {
        public double Base { get; set; }
        public double Altura{ get; set; }

        public Triangulo(double baseTriangulo, double alturaTriangulo) {
            Base = baseTriangulo;
            Altura = alturaTriangulo;

        }
        public override double Area()
        {
            double area;
            area = (Base * Altura) / 2;
            return area;
        }


        public override string ToString()
        {
            return ($"El area del Triangulo es {Area()}");
        }
    }
}
