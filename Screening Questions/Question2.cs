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

            string str = "Count the number of occurrences of a substring within a string";
            string word = "of";

            int count = countOccurrences(str, word);
            Console.WriteLine("In the string: \"{0}\" \n" +
                              "Counted {1} of \"{2}\".", str, count, word);


            static int countOccurrences(string str, string word)
            {
                // Split the string by spaces
                string[] a = str.Split(' ');

                // search for pattern in string
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {

                    // if match found increase count
                    if (word.Equals(a[i]))
                        count++;
                }

                return count;
            }          
        

        }
    }
}
