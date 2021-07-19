using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQASSIGNMENT
{
    public static class Application
    {
        static string[] arrayOfWords;
        static int count;
        public static void Run()
        {
            Console.WriteLine("Type in the words or a sentence of words to shuffle!");
            string sentence = Console.ReadLine();
            arrayOfWords = sentence.Split(new char[] { ' ', ',', '.', '-', ';', '\n', '\t' });
            arrayOfWords.ToList();

            var random = new Random();

            string[] shuffledWords = arrayOfWords.OrderBy(i => random.Next()).ToArray();
            foreach (string i in shuffledWords)
            {
                if (i.Trim() != "")
                {
                    count++;
                    Console.WriteLine();
                }
                    
            }
            Console.WriteLine($"A total of {count} has been shuffled");
        }
    }
}
