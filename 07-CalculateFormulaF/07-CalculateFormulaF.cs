using System;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


class CalculateFormulaF
{
    static void Main()
    {
        double rezult = 0.00;
        //   n! / (k! * (n-k)!)
        int FaktN = 1;
        int FakK = 1;
        Console.WriteLine("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k= ");
        int k = int.Parse(Console.ReadLine());
        int temp = 0;
        int razlikaFaktorel = 1;
        if (n > 1 && k > 1 && n < 100 && k < 100)
        {
            temp = n - k;
            for (int i = 1; i <= temp; i++)
            {
                razlikaFaktorel *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                FaktN *= i;
            }
            for (int i = 1; i <= к i++)
                
                FakK *= i;
            }
            rezult = FaktN / (FakK * razlikaFaktorel);
            Console.WriteLine(rezult);
        }
        else
        {
            Console.WriteLine("Error value!");
        }
    }
}