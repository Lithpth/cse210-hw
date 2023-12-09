// Alec Nugent
using System;
public class Program
{
    static void Main(string[] args)
    {
        // The menu was the hardest part, it uses some unnecessary code. 
        //I know ther's an easier way but I settled for a quick solution
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            int choice = int.Parse(Console.ReadLine());

            Activity selectedActivity = null;

            switch (choice)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectingActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    break;
                case 4:
                    exitProgram = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            // this was needed to make sure Run in each class worked.
            if (selectedActivity != null)
            {
                // Common starting message
                selectedActivity.DisplayStartingMessage();
                // Activity-specific implementation
                if (selectedActivity is BreathingActivity breathingActivity)
                {
                    // Execute BreathingActivity logic
                    breathingActivity.Run();
                }
                else if (selectedActivity is ReflectingActivity reflectingActivity)
                {
                    // Execute ReflectionActivity logic
                    reflectingActivity.Run();
                }
                else if (selectedActivity is ListingActivity listingActivity)
                {
                    // Execute ListingActivity logic
                    listingActivity.Run();
                }

                // Common ending message
                selectedActivity.DisplayEndingMessage();
            }
        }
    }
}
