using System;

namespace Git_Test
{
    class Program
    {
        static void Main()
        {
            int userGuesses = 0;
            int userNumber = -1;
            int randomNumber = 0;
            Random rnd = new Random();
            int start , end;
            Console.WriteLine("I am going to think of a number!");
            Console.WriteLine("What would you like the numbers to be between?");
            Console.Write("Enter Lowest Number: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Highest Number: ");
            end = Convert.ToInt32(Console.ReadLine());;
            randomNumber = rnd.Next(start, end);
            Console.WriteLine($"I am thinking of a number between {start} and {end}.");
            Console.WriteLine("What number do you think it is?");
            do
            {
                Console.Write("Enter Number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < randomNumber)
                {
                    Console.WriteLine("Too Low, Guess Again.");
                }
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("Too High, Guess Again.");
                }
                userGuesses++;
            } while (userNumber != randomNumber);
            Console.WriteLine($"Congratulations, You Guessed Right! It only took you {userGuesses} attempts!");
        }
    }
}
