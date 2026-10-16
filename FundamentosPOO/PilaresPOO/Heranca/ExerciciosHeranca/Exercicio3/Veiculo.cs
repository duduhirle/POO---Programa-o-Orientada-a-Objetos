using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio3
{
    public class Veiculo
    {
        public String Marca {  get; set; }
        public String Modelo {  get; set; }

        public Veiculo(string marca, String modelo) 
        {
            Marca=marca;
            Modelo=modelo;
        }

        public void Exibir() 
        {
            Console.WriteLine($"O veiculo é da marca {Marca} e o modelo é o {Modelo}");
        }
        
        




    }
}
