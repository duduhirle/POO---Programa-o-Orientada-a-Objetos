using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class Pedido
    {
        // Atributos
        public string NomeDoCliente;
        public string Item;
        public int Quantidade;
        public double Preco;
        // Metodos 
        public void ExibirInfo()
        {
            Console.WriteLine($"O Nome do cliente é {NomeDoCliente}");
            Console.WriteLine($"O item é {Item}");
            Console.WriteLine($"A Quantidade do produto é {Quantidade}");
            Console.WriteLine($"O Preço é de {Preco}");
        }
    }
}
