using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.src
{
    public class Pratos : Executivo
    {
        public Pratos(string nome, double preco, string classificacao) : base(nome, preco, classificacao)
        {
        }

        public void Strogonoff()
        {
            Console.WriteLine("Você escolheu: Strogonoff");
        }

        public void Macarronada()
        {
            Console.WriteLine("Você escolheu: Macarronada");
        }

        public void Feijoada()
        {
            Console.WriteLine("Você escolheu: Feijoada");
        }
    }
}
