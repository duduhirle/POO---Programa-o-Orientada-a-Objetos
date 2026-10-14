using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _5___POO
{
    public class lampada
    {
        public bool ligada;
        public void Ligar()
        {
            ligada = true;
        }
        public void Desligar()
        {
            ligada = false;
        }
        public void Alternar()
        {
            if (ligada)
            {
                Desligar();
            } else
            {
                Ligar();
            }
      
        }

        public void ExibirEstado()
        {
            Console.WriteLine(ligada ? "A lâmpada está ligada." : "A lâmpada está desligada.");
        }
    }
}
