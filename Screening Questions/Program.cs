using System;

namespace Screening_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("Screening Questions: \n" + 
                                      "--------------------\n\n" +
                                      "1) Reversing Memory\n" +
                                      "   Reverse an array of characters in place.You can provide your answer as a short code snippet.\n\n" +
                                      "2) Counting\n" +
                                      "   Count the number of occurrences of a substring within a string.Provide you answer as a short code snippet.\n\n" +
                                      "3) Recursion\n" +
                                      "   Count the number of occurrences of a substring within a string using recursion.Just provide a short code snippet.\n\n" +
                                      "4) Pointers\n" +
                                      "   Implement the missing functions in Appendix I using C\n\n" +
                                      "5) Bits and Bytes\n"+
                                      "   Implement the missing functions in Appendix II using C.\n\n");


                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            Question1.RunQuestion1();                            
                            break;
                        case 2:
                            Question2.RunQuestion2();
                            break;
                        case 3:
                            Question3.RunQuestion3();
                            break;
                        case 4:
                            Question4.RunQuestion4();
                            break;
                        case 5:
                            Question5.RunQuestion5();
                            break;
                        
                        case -1:
                            keepAlive = false;
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Assignment number!");
                    Console.ResetColor();
                }
            }
        }
    }
}
