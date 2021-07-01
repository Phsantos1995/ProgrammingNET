using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Pessoa
    {
        string nome;
        int olhos, bracos, pernas;
        string cor_olhos;
        string cor_cabelos;
        public void andar(int velocidade)
        {
            int minuto = 0;


            velocidade = velocidade + minuto;

            Console.WriteLine("minuto:" + velocidade);


        }
        public void falar()
        {
            Console.WriteLine("Fala bla bla");
        }
        public void comer(string comida)
        {
            // alimente-se mais




        }


    }
}
