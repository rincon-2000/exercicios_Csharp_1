using System;

namespace Exe26
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdEstoque;
            int qtdMaxima;
            int qtdMinima;
            int qtdMedia = 0;


            Console.WriteLine("Quantidade atual em estoque: ");
            qtdEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade maxima de estoque?");
            qtdMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade minima de estoque?");
            qtdMinima = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCalculando...\n");

            qtdMedia = ((qtdMaxima + qtdMinima) / 2);
            if(qtdEstoque >= qtdMedia)
            {
                Console.WriteLine("\nNao efetuar compra.");
            }
            else
            {
                Console.WriteLine("\nEfetuar compra.\n\n");
            }
        }
    }
}
