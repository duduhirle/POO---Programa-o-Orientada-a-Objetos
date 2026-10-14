using System;
using System.Collections.Generic;
using System.Text;

namespace _5___POO
{
    public class banco
    {
        public string Titular;

        public double Saldo;

        public double Depositar;
       

        public double Sacar;

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo é de {Saldo}");
        }
    }
}
