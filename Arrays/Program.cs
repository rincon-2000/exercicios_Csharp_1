using System;

namespace Arrays
{//declarar array com parâmetro

    internal class Program
    {
        private static void ExibirParametros(params object[] valores)
        {

            foreach (object i in valores)
            {

                Console.WriteLine("valor: " + i);
                Console.WriteLine("Tipo: " + i.GetType().ToString());


            }
        }
        private static decimal CalcularMedia(params decimal[] notas)

        {
            //definição da var soma = 0
            decimal soma = 0;

            // iterar o array notas e acumular seus valores
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                soma += notas[i]; // soma = soma + notas [i]
            }
            return soma / notas.Length;

        }
        static void Main(string[] args)
        {

            /* <tipo> [] <nomeDoArray>  = new <tipo> [qtd] */
            // Array Unidimensional 
            string[] aluno = new string[5];

            aluno[0] = "Jhony";
            aluno[1] = "Vinicius";
            aluno[2] = "Guilherme";
            aluno[3] = "Fernando";
            aluno[4] = "Romulo";
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine("aluno: " + aluno[i]);
            }


            // Array Bidimensional

            int[,] numeros =
            {

                {17,22,12,44,34},
                {23,33,12,21,45}
            };
            //Console.WriteLine(numeros[1,1]);
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine($"posição {i}, {j}: {numeros[i, j]}");

                }


                Console.WriteLine(new string('-', 50));

                Console.WriteLine("Arrays passando parâmetros");
                decimal[] valor = { 5, 7, 8, 9 };
                Console.WriteLine("Média: " + CalcularMedia(valor));
                Console.WriteLine("Média 2: " + CalcularMedia(15, 20, 60));

                Console.WriteLine(new string('-', 50));
                ExibirParametros("Vinicius", 4, 5m, 'C', 12.87);


            }
        }
    }
}