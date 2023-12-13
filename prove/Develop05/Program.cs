using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        
    }
    internal class SimpleGoal
    {

    }
}
class GoalManager
{
    private int _score;
}
class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

}
class SimipleGoal : Goal
{
    private bool _isComplete;
    public SimipleGoal()
    {

    }
}
class ChecklistGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
}