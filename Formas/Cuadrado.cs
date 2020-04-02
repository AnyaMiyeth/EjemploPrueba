using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Cuadrado:Figura
    {
    // hola
          public Cuadrado(double lado){
            Lado = lado;
        }
        public double Lado { get; set; }

        public override double Area()
        {

            return Lado * Lado;
        }
        

        public override string ToString() {
            
            return ($"El  Area de la figura Cuadrado es {Area()}");
        }
    }
}
