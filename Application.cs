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
        public static void RunMethodSyntax()
        {
            Console.WriteLine("Type in the words or a sentence of words to shuffle!");
            string sentence = Console.ReadLine();
            arrayOfWords = sentence.Split(new char[] { ' ', ',', '.', ';', '\n', '\t' });
                                  
            Random random = new Random();

            var shuffledWords = arrayOfWords.OrderBy(i => random.Next(arrayOfWords.Length));
            foreach (string i in shuffledWords)
            {
                if (i.Trim() != "")
                {
                    count++;
                    Console.WriteLine($"\n{i}");
                }                    
            }
            Console.WriteLine($"\nA total of {count} has been shuffled using Method syntax.");
        }

        public static void RunQuerySyntax()
        {
            Console.WriteLine("Type in the words or a sentence of words to shuffle!");
            string sentence = Console.ReadLine();
            arrayOfWords = sentence.Split(new char[] { ' ', ',', '.', ';', '\n', '\t' });

            Random random = new Random();

            var shuffledWords = from i in arrayOfWords 
                                orderby random.Next(arrayOfWords.Length) 
                                select i;

            foreach (string i in shuffledWords)
            {
                if (i.Trim() != "")
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"A total of {count} has been shuffled using Query syntax.");
        }
        
    }
}
