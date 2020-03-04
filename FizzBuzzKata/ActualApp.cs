using System;

namespace FizzBuzzKata
{
    public class ActualApp
    {

        public static void Game()
        {

            for (int counter = 1; counter < 101; counter++)
            {
                if (counter % 3 == 0 && counter % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0 && counter % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                Console.WriteLine(counter);

                }

            }
        }
    }
}
