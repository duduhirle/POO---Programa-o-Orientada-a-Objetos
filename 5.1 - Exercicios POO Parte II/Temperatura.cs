using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1___Exercicios_POO_Parte_II
{
    public class Temperatura
    {
        public double CelsiusParaFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        public bool EstaQuente(double celsius)
        {
            return celsius >= 30;
            }
        }
    }

