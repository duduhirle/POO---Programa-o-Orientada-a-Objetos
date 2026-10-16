using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace Heranca.ExerciciosHeranca.Exercicio_2
{
    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public Gerente(string nome, int salario, double bonus) : base(nome, salario)
        {
            Bonus = bonus;
        }

        public double SalarioComBonus() 
        { return Bonus + Salario; }
    }
}
