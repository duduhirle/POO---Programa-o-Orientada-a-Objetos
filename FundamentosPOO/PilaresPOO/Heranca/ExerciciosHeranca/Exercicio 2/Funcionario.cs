using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.ExerciciosHeranca.Exercicio_2
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Salario { get; set; }

        public Funcionario(string nome, int salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
