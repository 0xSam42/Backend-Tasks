// See https://aka.ms/new-console-template for more information
using System;

class W1T1
{
    static void Main()
    {

    

Console.WriteLine("Output Test");

// Program loop for continuous flow 
while (true)
{
    Console.WriteLine("Input a year to check whether it's a leap year or a normal year:");

    String yearString = Console.ReadLine();
    int year = int.Parse(yearString);

    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine(yearString + " is a leap year");
                Console.WriteLine("---------------------------------");
                continue;
            }
            else
            {
                Console.WriteLine(yearString + " is a normal year");
                Console.WriteLine("---------------------------------");
                continue;
            }
        }
        else
        {
            Console.WriteLine(yearString + " is a leap year");
            Console.WriteLine("---------------------------------");
        }

    }
    else
    {
        Console.WriteLine(yearString + " is a normal year");
        Console.WriteLine("---------------------------------");

    }
}
    }
}