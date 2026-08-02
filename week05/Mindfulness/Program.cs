using System;

/*Creativity
This program tracks how many  times each activity is completed
and records the total number of seconds spent on each activity. 
It also provides a summary of the total number of sessions completed and the total time spent on mindfulness activities.
*/

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        int breathingTime = 0;
        int reflectionTime = 0;
        int listingTime = 0;

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity activity =new BreathingActivity();
                    activity.Run();
                    breathingCount++;
                    breathingTime += activity.GetDuration();

                    break;

                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    reflectionCount++;
                    reflectionTime += reflectionActivity.GetDuration();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    listingCount++;
                    listingTime += listingActivity.GetDuration();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("=============================Session Summary=============================");

                    Console.WriteLine("Breathing Activity:");
                    Console.WriteLine($"Sessions Completed: {breathingCount}");
                    Console.WriteLine($"Total Time Spent: {breathingTime} seconds");

                    Console.WriteLine("Reflection Activity:");
                    Console.WriteLine($"Sessions Completed: {reflectionCount}");
                    Console.WriteLine($"Total Time Spent: {reflectionTime} seconds");

                    Console.WriteLine("Listing Activity:");
                    Console.WriteLine($"Sessions Completed: {listingCount}");
                    Console.WriteLine($"Total Time Spent: {listingTime} seconds");

                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"Total Sessions Completed: {breathingCount + reflectionCount + listingCount}");
                    Console.WriteLine($"Total Mindfulness Time: {breathingTime + reflectionTime + listingTime} seconds");

                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

    }
}