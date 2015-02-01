//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:


using System;
using System.Collections.Generic;

class Numbersfrom1toN
{
    static void Main()
    {
        Console.WriteLine("Enter number: Number is:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}