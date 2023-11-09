using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Good practice to list variables first
        string firstName, lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();
        
        Console.WriteLine();

        Console.WriteLine("Your name is {1}, {0} {1}.",firstName,lastName);


        Console.ReadLine();

    }
}