using System;
using System.Collections.Generic;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.



class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        checked
        {
            Console.Write("Please, enter a whole number for count of sequence, N = ");
            string inputStr = Console.ReadLine();
            int countN = int.Parse(inputStr);
            if (countN < 1)
            {
                Console.WriteLine("Error - Invalid Number !!!");
            }
            else
            {
                List<int> numbers = new List<int>(countN);
                for (int i = 0; i < countN; i++)
                {
                    Console.Write("Enter the next whole number of sequence: ");
                    inputStr = Console.ReadLine();
                    numbers.Add(int.Parse(inputStr));
                }

                int numMin = int.MaxValue;
                int numMax = int.MinValue;
                int sumOfAllNumbers = 0;
                foreach (var number in numbers)
                {
                    numMin = Math.Min(numMin, number);
                    numMax = Math.Max(numMax, number);
                    sumOfAllNumbers += number;
                }
                double averageNumbers = sumOfAllNumbers / 2.0;
                Console.WriteLine("MIN = {0} and MAX = {1} !", numMin, numMax);
                Console.WriteLine("SUM = {0} and AVERAGE = {1:F2} !", sumOfAllNumbers, averageNumbers);
            }
            Console.ReadLine();
        }
    }
}