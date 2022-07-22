using Restaurant.src;
using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            double aux = 0;
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao nosso restaurante!\n");
            Console.WriteLine("Seu pedido:\n");

            List<Executivo> Pedido = new List<Executivo>
                (
                    new Executivo[]
                    {
                    new Pratos("Strogonoff",17.0, "Prato"),
                    new Acompanhamentos("Farofa", 7.0, "Acompanhamento"),
                    new Bebida("Refri", 7.0, "Bebida"),
                    }
                );

            foreach (Executivo executivo in Pedido)
            {
                aux = aux + executivo.Preco;
                if (executivo.Classificacao == "Prato")
                {
                    Console.WriteLine($"{executivo.Nome} custa: R${executivo.Preco}");
                }
                else if (executivo.Classificacao == "Acompanhamento")
                {
                    Console.WriteLine($"{executivo.Nome} custa: R${executivo.Preco}");

                }
                else if (executivo.Classificacao == "Bebida")
                {
                    Console.WriteLine($"{executivo.Nome} custa: R${executivo.Preco}");
                }
            }
            Calc resultado = new Calc();
            Console.WriteLine($"O valor da sua compra é: R${Math.Round(aux, 2)}");
        }
    }
}
