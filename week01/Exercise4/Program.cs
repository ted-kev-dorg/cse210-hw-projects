using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers;
        numbers= new List<int>();

        int number = -1;
        int sum = 0;
        int count = 0;
        float avg = 0;
        // avg = sum/count;

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write ("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            sum = sum + number;
            numbers.Add(number);

            if(number !=0)
            {
                count ++;
                avg = ((float)sum)/count;
            } 
        }
        Console.WriteLine ($"The sum is: {sum}");
        Console.WriteLine ($"The average is: {avg}");
        Console.WriteLine ($"The largest number is: {numbers.Max()}");
        






    }
}