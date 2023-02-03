using System;
using System.Collections;


namespace ArrayListAula
{
    internal class Program
    {
        static void ListaListas(ArrayList nomeLista)
        {
            for (int i = 0; i < nomeLista.Count; i++)
            {
                Console.WriteLine(nomeLista[i]);
            }
        }
        static void Main(string[] args)
        {
            //Definir o ArrayList
            ArrayList lista = new ArrayList();

            // ArrayList é um array de objetos que tem seus próprios 
            // métodos para:
            // inserir, adicionar, procurar, ordenar etc.
            /*
            * Métodos Importantes:
            * Add(objeto)
            * Insert(posição, objeto)
            * IndexOf(objeto)
            * Remove(objeto)
            * RemoveAt(posição)
            * Sort()
            */

            lista.Add("Computador");
            lista.Add("Lápis");
            lista.Add("Borracha");
            ListaListas(lista);
            lista.Insert(0, "Mouse");
            ListaListas(lista);


            Console.WriteLine("______");
            lista.Remove("Lápis");
            ListaListas(lista);
        }
    }
}
