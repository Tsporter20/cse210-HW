using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string Name = PromptUserName();
        int Number = PromptUserNumber();

        int Numbersquared = SquareNumber(Number);

        DisplayResult(Name, Numbersquared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to this program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }
}