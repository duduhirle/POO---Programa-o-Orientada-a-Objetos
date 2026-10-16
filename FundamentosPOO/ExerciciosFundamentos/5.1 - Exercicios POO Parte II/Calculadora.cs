using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1___Exercicios_POO_Parte_II
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"Resultado: {valor}");
        }

    }
}
