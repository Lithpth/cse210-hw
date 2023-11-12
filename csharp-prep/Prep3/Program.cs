using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        int num1,guess=0;

        int guesses=0;

        Console.Write("What is the magic number? ");
        num1 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("what is your guess? ");
        
        // guess = Convert.ToInt32(Console.ReadLine());

        while (guess!=num1) // While guess does not equal num1, keep running
        {
            Console.Write("what is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            guesses+=1; // The number of guesses is incremented by one

            //if else portion
            if (num1>guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num1<guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
                break;            
            }
        }
        Console.WriteLine("Good job! You guessed it in {0} attempts", guesses);
        Console.ReadLine();
    }
}