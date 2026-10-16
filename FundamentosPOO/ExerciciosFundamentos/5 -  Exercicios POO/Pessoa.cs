using System;
using System.Collections.Generic;
using System.Text;

namespace _5___POO
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, vc se chama {Nome} e tenho {Idade} anos");
        }
    }
}
