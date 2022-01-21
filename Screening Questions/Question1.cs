using System;
using System.Collections.Generic;
using System.Text;

namespace Screening_Questions
{
    class Question1
    {
        public static void RunQuestion1()
        {
            //Reverse an array of characters in place.You can provide your answer as a short code snippet.

            try
            {
                Console.Write("\nEnter a string: ");
                string word = Console.ReadLine();
                char[] chars = word.ToCharArray();
                Array.Reverse(chars);
                string str = new string(chars);

                Console.WriteLine("\nString reversed: "+ str);
            }
            catch
            {
                Console.WriteLine("It is not a string!");
            }            
        
        }
    }
}
