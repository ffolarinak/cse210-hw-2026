
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        // Creativity beyond core requirements:
        // The program provides 10 different prompts and records
        // both the date and time for every journal entry.

        Console.WriteLine("Welcome to your Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Entry newEntry = new Entry(date, prompt, response);

                theJournal.AddEntry(newEntry);

                Console.WriteLine("Your journal entry has been saved!");
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                try
                {
                    theJournal.LoadFromFile(filename);
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("File not found. Please check the filename.");
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using your Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
            }
        }
    }
}
