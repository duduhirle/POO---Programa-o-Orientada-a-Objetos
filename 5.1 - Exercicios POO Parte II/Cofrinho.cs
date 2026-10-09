using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1___Exercicios_POO_Parte_II
{
    public class Cofrinho
    {
        public double Saldo;
        public void Guardar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor invalido");
                return;
            }
            else
            {
                valor += Saldo;
            }
        }
        public bool Retirar(double valor)
        {
            if (Saldo >= 0)
            {
                double novoSaldo = Saldo - valor;
                return true;
            }
            else
            {
                Console.WriteLine("Não possui dinheiro | Saldo insuficiente");
                return false;
            }
        }
        public double FaltaParaMeta(double meta)
        {
            if (Saldo >= meta)
            {
                Console.WriteLine("Meta batida");
                return 0;

            } else
            {
                return meta - Saldo;
            }
        }
    }
}
