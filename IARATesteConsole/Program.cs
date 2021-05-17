using System;
using System.Linq;
using System.Collections.Generic;

namespace IARATesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            //int[] values = { 2, 8, 14 };

            ValidArrayNumbers validArrayNumbers = new ValidArrayNumbers();
            var result = validArrayNumbers.ContainsValueImpar(values);
                    
            if (result.Count() > 0)
            {
                Console.WriteLine("Foram encontrados os seguintes números impares:");
                foreach (int i in result)
                    Console.WriteLine(i);
            }
            else
                Console.WriteLine("Nenhum número impar encontrado");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=================================================");
            Console.WriteLine("Palavras com letras duplicadas corrigidas");
            string[] words = { "abracadabra", "allottee", "assessee" };
            ValidArrayWords validArrayWords = new ValidArrayWords();
            var resultWords = validArrayWords.ContainsDuplicateValue(words);
            
            foreach (string i in resultWords)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
