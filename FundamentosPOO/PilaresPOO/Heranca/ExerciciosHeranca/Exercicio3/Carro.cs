using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio3
{
    public class Carro : Veiculo
    {
        public int Portas { get; set; }
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Portas = portas;
        }

        public void ExibirPortas()
            {
            Console.WriteLine($"A quantidade de portas do veiculo é de {Portas}");
            }
    }
}
