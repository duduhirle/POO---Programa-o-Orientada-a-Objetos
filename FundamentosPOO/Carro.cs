using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class Carro
    {
        // *Atributos*
        public string Marca;

        public string Modelo;

        public int Ano;
        //* Metodos *
        // Mostrar informações do carro
        // Metodo que nao retorna nada - executa algo e nao retona nada no final
        public void ExibirInformacoes() 
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        } 



    }
}
