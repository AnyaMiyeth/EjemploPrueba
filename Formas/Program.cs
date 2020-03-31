using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura cuadrado = new Cuadrado(2);
           Figura triangulo = new Triangulo(3,4);
            Console.WriteLine(cuadrado.ToString());
            Console.WriteLine(triangulo.ToString());
            Console.ReadKey();
        }
    }
}
