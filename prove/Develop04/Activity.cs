public class Activity
{
    // This is the base class
    public string _name;
    public string _description;
    public int _seconds;
    public Activity()
    {
        
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity. {_description}");
        Console.Write("Enter the duration (seconds): ");
        _seconds = int.Parse(Console.ReadLine()); // You have to enter again
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {_name}, Duration: {_seconds} seconds");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinning..."); // current solution
        Thread.Sleep(seconds * 1000); // using threads
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i} seconds");
            Thread.Sleep(1000);
        }
    }

}
