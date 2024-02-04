using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int check = 0;
        Journal journal = new Journal();

        while (check == 0)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("> ");
            string user_choice = Console.ReadLine();
            int choice = int.Parse(user_choice);

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal(); 
                    break;
                case 3:
                    journal.LoadJournal(); 
                    break;
                case 4:
                    journal.SaveJournal(); 
                    break;
                case 5:
                    check = 1;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
        }
    }
}
