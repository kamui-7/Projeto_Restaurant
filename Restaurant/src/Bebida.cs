using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.src
{
    public  class Bebida : Executivo
    {
        public Bebida(string nome, double preco, string classificacao) : base(nome, preco, classificacao)
        {
        }

        public void Refri()
        {
            Console.WriteLine("Você escolheu: Refrigerante");
        }

        public void Suco()
        {
            Console.WriteLine("Você escolheu: Suco");
        }

        public void Agua()
        {
            Console.WriteLine("Você escolheu: Agua");
        }
    }
}
