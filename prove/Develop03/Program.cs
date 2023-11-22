using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        // Objects
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide some words, or type 'quit' to end:");
            
            
            string input = Console.ReadLine();
            scripture.GetDisplayText();
            if (input.ToLower() == "quit")
            {
                break;
            }
        
            int r = new Random().Next(1, 4);
            scripture.HideRandomWords(r);
            // Clear the console screen
            Console.Clear();
            // Display scripture
            Console.WriteLine(scripture.GetDisplayText());
            scripture.GetDisplayText();
        }
        Console.WriteLine("Exiting the program");
    }
    
}