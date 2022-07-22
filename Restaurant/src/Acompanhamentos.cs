using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.src
{
    public class Acompanhamentos : Executivo
    {
        public Acompanhamentos(string nome, double preco, string classificacao) : base(nome, preco, classificacao)
        {
        }

        public void Batata()
        {
            Console.WriteLine("Você escolheu: Batata Frita");
        }

        public void Salada()
        {
            Console.WriteLine("Você escolheu: Salada");
        }

        public void Farofa()
        {
            Console.WriteLine("Você escolheu: Farofa");
        }
    }
}
