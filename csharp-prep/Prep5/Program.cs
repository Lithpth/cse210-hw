using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");


        //General structure of a function
        
        
        // returnType FunctionName(dataType parameter1, dataType parameter2)
        // {
        //     // function_body
        // }

        // // function
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello World!");
        // }

        // // function that accepts a single parameter
        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine("Hello {0}", userName);
        // }
        // // function with two parameters, will return int value
        // static int AddNumbers(int num1, int num2)
        // {
        //     int sum = num1+num2;
        //     return sum;
        // }



        // DisplayMessage();
        
        // Console.WriteLine(AddNumbers(1,2));

        // DisplayPersonalMessage("Person");
        // AddNumbers(1,2);

        // static void DisplayWelcome()
        // {
        //     Console.WriteLine("Welcome to the Program!");
        // }
        // static string PromptUserName(string name)
        // {
        //     Console.WriteLine("Please enter your name: ");
            
        // }
        // Whoops should have been doing those outside Main


        // Call the functions
        DisplayWelcome();
        string PromptName = PromptUserName();
        int PromptNumber = PromptUserNumber();
        int Square=SquareNumber(PromptNumber);

        DisplayResult(PromptName,Square);
        
        Console.ReadLine();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number*number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine("{0}, the square of your number is {1}",name,square);
    }
}