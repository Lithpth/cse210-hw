using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Console.WriteLine("Hello Learning03 World!");
        //        
        // Person p1 = new Person();  
        
        // New object is created
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.Top);
        Console.WriteLine(f1.Bottom);

        Console.WriteLine("Whole Number");

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.Top);
        Console.WriteLine(f2.Bottom);

        Console.WriteLine("Top and Bottom");

        Fraction f3 = new Fraction(5,3);
        Console.WriteLine(f3.Top);
        Console.WriteLine(f3.Bottom);
        
        Console.WriteLine();

        System.Console.ReadLine();
    }
}
