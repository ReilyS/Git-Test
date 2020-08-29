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
            randomNumber = rnd.Next(0, 100);
            Console.WriteLine("I am thinking of a number between 0 and 100.");
            Console.WriteLine("What number do you think it is?");
            do
            {
                Console.Write("Enter Number: ");
                try
                {
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    if (userNumber < randomNumber)
                    {
                        Console.WriteLine("Too Low, Guess Again.");
                    }
                    else if (userNumber > randomNumber)
                    {
                        Console.WriteLine("Too High, Guess Again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please Enter a Number.");
                }
                userGuesses++;
            } while (userNumber != randomNumber);
            Console.WriteLine($"Congratulations, You Guessed Right! It only took you {userGuesses} attempts!");
        }
    }
}
