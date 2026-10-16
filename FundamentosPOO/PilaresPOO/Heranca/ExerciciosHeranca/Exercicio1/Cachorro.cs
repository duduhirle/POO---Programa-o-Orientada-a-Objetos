using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio1
{
    public class Cachorro : Animal
    {
        public void Latir() 
        {
            Console.WriteLine($"{Nome}: Au au");
        }
    }


}
