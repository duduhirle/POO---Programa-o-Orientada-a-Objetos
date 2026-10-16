using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio3
{
    public class Moto : Veiculo
    {
        public int Cilindricas { get; set; }
        public Moto(string marca, string modelo, int cilindricas) : base(marca, modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindricas = cilindricas;

        }

        public void ExibirCilindradas() 
        {
            Console.WriteLine($"A quantidade de cilidrincas é de {Cilindricas}");
        }
    }
}
