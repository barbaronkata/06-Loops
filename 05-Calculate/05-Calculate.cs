using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.




class CalculateFaktorial
{
    static void Main()
    {

        Console.WriteLine("Enter N=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X=");
        int X = int.Parse(Console.ReadLine());
        double rezult = 1.00;
        double FaktSum = 1.00;
        double tempDelitel = 1.00;
        for (int i = 1; i <= n; i++)
        {
            // double factorial = 0.0;
            FaktSum *= i;
            tempDelitel = tempDelitel * n;
            rezult += FaktSum / tempDelitel;

        }

        Console.WriteLine(rezult);

    }
}