using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Screening_Questions
{
    class Question2
    {
        public static void RunQuestion2()
        {
            // Count the number of occurrences of a substring within a string.Provide you answer as a short code snippet.

            try
            {
                Console.Write("\nEnter a word: ");
                string word = Console.ReadLine();

                Console.Write("\nEnter one character to count: ");
                char substr = char.Parse( Console.ReadLine() );

                int count = word.Count(s => s == substr);

                Console.WriteLine("\nNumber of {0} in {1} is {2}", substr, word, count);

            }
            catch
            {
                Console.WriteLine("It is not valid!");
            }

        }
    }
}
