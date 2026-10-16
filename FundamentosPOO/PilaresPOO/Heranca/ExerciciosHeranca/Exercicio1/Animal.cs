using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio1
{
    public class Animal
    {

        public string Nome {  get; set; }
        public void Comer() {
            Console.WriteLine($"{Nome} está comendo");
        }
    }
}
