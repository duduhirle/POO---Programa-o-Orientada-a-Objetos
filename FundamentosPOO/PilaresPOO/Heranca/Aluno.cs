using Heranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO.PilaresPOO.Heranca
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; } // Gerou a string matricula; So funciona para a classe ALUNO pois foi nele que foi criado e nao no pessoa (na qual puxou herança)
        // Nome, Idade, MATRICULA
    }
}
