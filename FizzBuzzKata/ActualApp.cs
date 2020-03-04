using System;

namespace FizzBuzzKata
{
    public class ActualApp
    {

        public static void LoopingNumbers()
        {

            for (int counter = 1; counter < 101; counter++)
            {
                
                string resultOfCalculator = CheckingNumbers(counter);
                Console.WriteLine(resultOfCalculator);

            }
        }


        public static string CheckingNumbers(int counter)
        {

            string message;
            if (counter % 3 == 0 && counter % 5 != 0 && counter % 7 != 0)
            {
                message = "Fizz";
            }
            else if (counter % 5 == 0 && counter % 3 != 0 && counter % 7 != 0)
            {
                message = "Buzz";
            }
            else if (counter % 7 == 0 && counter % 3 != 0 && counter % 5 != 0)
            {
                message = "Pop";
            }
            else if (counter % 3 == 0 && counter % 5 == 0)
            {
                message = "FizzBuzz";
            }
            else
            {
                message = Convert.ToString(counter);
            }
            return message;
        }


        
    }
}
