using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ExerciciosEncapsulamento.Exercicio1
{
    public class Contador
    {

        private int Visitas { get; set; }

        public void RegristrarVisita()
            {
                Visitas++;
            }

        public int ObterTotal() 
        {
            return Visitas;
            }
    }
}
