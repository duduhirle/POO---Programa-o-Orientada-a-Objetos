using System;
using System.Collections.Generic;
using System.Text;

namespace _5___POO
{
    public class retangulo
    {
        // Atributos
        public double Largura;

        public double Altura;

        // Metodos 
        public double Area()
        {
            double Area = Largura * Altura;
            return Area;
        }

        public double Perimetro()
        {
            double Perimetro = 2 * (Largura + Altura);
            return Perimetro;

        }
    }
}
