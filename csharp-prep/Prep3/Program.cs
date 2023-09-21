using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int magic = -1;

        while (magic != magicNumber)
        {
            Console.Write("What is your guess? ");
            magic = int.Parse(Console.ReadLine());

            if (magicNumber > magic)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("That's Correct! You guessed it!");
            }

        }                    
    }
}