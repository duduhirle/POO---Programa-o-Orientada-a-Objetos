using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Carro
    {
        public string Marca;
        public string Modelo;

        // Metodo Construtor -> Obriga um objeto nascer de um jeito
        // Nao tem tipo de retorno
        // Tem o mesmo nome da classe


        public Carro(string  marca, string modelo)
        {
            Marca = marca;

            Modelo = modelo;
        }

    }
}
