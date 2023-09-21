using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> digits = new List<int>();
        
        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a number (type 0 to stop program): ");
            
            string userResponse = Console.ReadLine();
            Number = int.Parse(userResponse);
            
            if (Number != 0)
            {
                digits.Add(Number);
            }
        }

        int sum = 0;
        foreach (int number in digits)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your numbers is: {sum}");

        float average = ((float)sum) / digits.Count;
        Console.WriteLine($"The average of your numbers is: {average}");

        int max = digits[0];

        foreach (int number in digits)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}