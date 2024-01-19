using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess;
        
        do
        {
            Console.Write("Give me a guess between 1 and 10: ");
            string user_guess = Console.ReadLine();
            guess = int.Parse(user_guess);

            if (number > guess)
            {
                Console.Write("You guessed too low!\n");
            }
            else if (number < guess)
            {
                Console.Write("You guessed too high!\n");
            }
        
        } while (number != guess);
        
        Console.Write("Congrats, you found the magic number");
        
    }
}