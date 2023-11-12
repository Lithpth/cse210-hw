using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // // List<int> numbers;
        // // numbers = new List<int>();
        // // List<string> words;
        // // words = new List<string>();

        // // Usually done on same line
        // // Parentheses used any time we need to create a new object
        // // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // // Now we gonna add strings to the list using the .Add() method
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        

        // Console.WriteLine(words.Count); // Count gets the size of list

        // // Now time to iterate through a list

        // // foreach
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // // for loop iteration
        // for (
        //     int i=0; // loop variable initialization
        //     i < words.Count; // condition
        //     i++ // increment
        // )
        // {

        //     Console.WriteLine(words[i]);
        // }

        List<double> numbers = new List<double>();

        double number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            number= Double.Parse(Console.ReadLine());
            if ((number) != 0)
            {
                numbers.Add(number);
            }
        }

        // find sum
        double sum = 0;
        for (int i=0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        // find average
        double avg = (double)sum/numbers.Count;
        
        // find max number in list
        double max = double.MinValue;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }

        // Display
        Console.WriteLine("The sum is: {0}",sum);
        Console.WriteLine("The average is: {0}",avg);
        Console.WriteLine("The largest number is: {0}",max);


        Console.ReadLine();
    }
}