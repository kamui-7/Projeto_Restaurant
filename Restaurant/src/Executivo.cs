using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.src
{
    public class Executivo
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Classificacao { get; set; }

        public Executivo(string nome, double preco, string classificacao)
        {
            Nome = nome;
            Preco = preco;
            Classificacao = classificacao;
        }
    }
}
