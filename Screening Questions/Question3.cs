using System;
using System.Collections.Generic;
using System.Text;

namespace Screening_Questions
{
    class Question3
    {
        public static void RunQuestion3()
        {
            // Declare variables
            DateTime todaysDate = DateTime.Now;
            DateTime tomorrowsDate = todaysDate.AddDays(1);
            DateTime yesterdaysDate = todaysDate.AddDays(-1);

            Console.WriteLine("Todays date is {0}", todaysDate);
            Console.WriteLine("Tomorrows date is {0}", tomorrowsDate);
            Console.WriteLine("Yesterdays date was {0}", yesterdaysDate);
        }
    }
}
