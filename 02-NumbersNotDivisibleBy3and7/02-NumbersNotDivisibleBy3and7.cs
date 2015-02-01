using System;


//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

class NotDivisibleBy3and7
{
    static void Main()
    {
        Console.WriteLine("Enter nymber. Number is:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.WriteLine(i);
        }

    }
}