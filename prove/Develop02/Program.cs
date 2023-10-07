using System;

namespace HelpfulJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {

                //A list of prompts that will be randomly selected for the user to use

                "Did anything unexpected happen today that surprised you? ",
                "What did you do today?",
                "How are you feeling?",
                "Did you have a chance to serve someone?",
                "In what ways can you improve yourself tomorrow?",
                "What did you learn today in class?",
                "If you could talk to someone not near you right now, who would it be?",
                "What food are you making tonight for dinner?",
                "What homework do you need to complete?",
                "Did you do anything today that took you out of your comfort zone?",
                "Did you meet anyone new today?",
                "What was something fun that happened to you today?",
            };

            bool quit = false;
            while (!quit)
            {

                //The user will be asked to give a number 1-5 and depending on which they select the program will give them a response

                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Thank you for writing in your journal today!");
        }
        static string GetRandomPrompt(List<string> prompts)
        {

            //this is the code used to get a random prompt for the user form that last of prompts above

            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}