using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO.PilaresPOO.Heranca
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e possuo {Idade} anos de idade");
        }
    }
}
