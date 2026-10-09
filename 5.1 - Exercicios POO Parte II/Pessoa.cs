using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1___Exercicios_POO_Parte_II
{
    public class Pessoa
    {
        public string Nome;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}!");
        }

        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa}! Eu sou {Nome}.");
        }

        public string ObterApresentacao()
        {
            return $"Meu nome é {Nome}.";
        }
    }
}
