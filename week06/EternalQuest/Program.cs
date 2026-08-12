using System;

// Ways this program exceeds requirements:
    //   Added a fourth goal type, NegativeGoal, alongside the required Simple, 
    //   Eternal, and Checklist goals. This lets users track bad habits they are 
    //   trying to stop (e.g. "Skipped dessert" or "Avoided procrastinating"), 
    //   rather than only positive accomplishments.
    //   Unlike the other goal types, RecordEvent() subtracts points instead of 
    //   adding them, and like an EternalGoal it's never marked complete.


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}