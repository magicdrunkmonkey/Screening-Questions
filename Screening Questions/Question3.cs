using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Screening_Questions
{
    class Question3
    {
        public static void RunQuestion3()
        {
            // Count the number of occurrences of a substring within a string using recursion.

            string str = "Count the number of occurrences of a substring within a string";
            string word = "of";                    
                        
            int count = recursive_count(str, word);

            Console.WriteLine("In the string: \"{0}\" \n" +
                              "Counted {1} of \"{2}\".", str, count, word);
            
            int recursive_count(string str, string word)
            {

                int n1 = str.Length;
                int n2 = word.Length;

                // Base Case
                if (n1 == 0 || n1 < n2)
                    return 0;

                // Recursive Case
                // Checking if the first
                // substring matches
                if (str.Substring(0, n2).Equals(word))
                    return recursive_count(str.Substring(n2 - 1), word) + 1;

                // Otherwise, return the
                // count from the remaining
                // index
                return recursive_count(str.Substring(n2 - 1), word);
            }

        }
    }
}
