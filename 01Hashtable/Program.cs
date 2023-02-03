using System;
using System.Collections;

namespace _01Hashtable
{
    public class Program
    {
        static void Main(string[] args)
        {
             Hashtable dePara = new Hashtable();
            dePara.Add("1", "Regua");
            dePara.Add("2", "Regua");
            dePara.Add("3", "Regua");
            dePara.Add("4", "Regua");
            dePara.Add("5", "Regua");

            foreach (DictionaryEntry i in dePara)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
        }
    }
}
