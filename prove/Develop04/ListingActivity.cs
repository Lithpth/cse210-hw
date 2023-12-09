public class ListingActivity : Activity
{
    private List<string> _prompts;
    // additional solution
    private List<string> _userList;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        // Additional solution
        _userList = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // Taking from the Activity class I can use countdown
        Console.WriteLine("Get ready to start listing items...");
        ShowCountDown(5);

        // You can set a time for listing activity
        DateTime endTime = DateTime.Now.AddSeconds(_seconds);

        do
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string item = Console.ReadLine();

            if (item.ToLower() == "done")
                break;

            _userList.Add(item);
        } while (DateTime.Now < endTime);

        Console.WriteLine($"You listed {_userList.Count} items.");

        DisplayEndingMessage();
    }
    // I had funkiness happen with trying to create this, I used other means for this implementation, So i don't use a count
    public List<string> GetListFromUser()
    {
        return _userList;
    }
    // for prompts
    private string GetRandomPrompt()
    {
        // prompts
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
