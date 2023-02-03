using System;

namespace Exe24
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            decimal valorVenda;
            decimal comissao = 3;
            decimal comissaoMaior = 5;
            double salarioTotal = 0;


            Console.WriteLine("Digite o salario fixo: ");
            salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor total de todas as vendas?");
            valorVenda = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Calculando...");

            if(valorVenda <= 1500)
            {
                Console.WriteLine("\nAdicionado acrescimo de 3% sobre o valor total de vendas...\n");
                salarioTotal = Convert.ToDouble(salario + (comissao * valorVenda / 100));
                Console.WriteLine($"O salario total eh: R${salarioTotal} reais.");
            }else if (valorVenda > 1500)
            {
                Console.WriteLine("\nAdicionado acrescimo de 5% sobre o valor total de vendas...\n");
                salarioTotal = Convert.ToDouble(salario + (comissaoMaior * valorVenda / 100));
                Console.WriteLine($"O salario total eh: R${salarioTotal} reais.");
            }
            else
            {
                Console.WriteLine("Numeros invalidos.\n Encerrando.");
            }

           
        }
    }
}
