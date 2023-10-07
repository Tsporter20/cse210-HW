using System;

namespace HelpfulJournal
{
    class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {

            //Create a date and time for the journal entries

            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {

            // Used to display the entries when prompted

            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        public void SaveToFile()
        {

            // Used to save the journal entries into a file format saved in the Develop 2 folder

            Console.Write("Enter Filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response");

                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");
                }
            }

            Console.WriteLine("Saved");
        }

        public void LoadFromFile()
        {

            //Load the files that were saved in the Develop 2 folder

            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string response = fields[2].Replace(",,", ",");

                    entries.Add(new Entry(prompt, response, date));
                }
            }

            Console.WriteLine("Loaded");
        }
    }
}