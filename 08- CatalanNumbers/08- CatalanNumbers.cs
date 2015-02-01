using System;
using System.Numerics;

class CalculateNCatalanNumber
{
    static void Main()
    {
        checked
        {
            Console.Write("Please, enter a positive whole number in the range [2...99], N = ");
            string numberStr = Console.ReadLine();
            int numN = int.Parse(numberStr);
            if (numN < 2 || numN >= 100)
            {
                Console.WriteLine("Error - Invalid Number !!!");
            }
            else
            /* The formula for Catalan numbers: C = (2N)! / ((N + 1)! * N!) .
             * Will seeing factorials N! and (N + 1)! They are Subsets of
             * factorial (2N)! That's means, the N Catalan Number can be
             * calculated by other most easy way: */
            {
                BigInteger numberCatalan = 1;
                for (int i = numN; i > 1; i--)
                {
                    numberCatalan *= (i + numN) / i;
                }

                Console.WriteLine("The N-th number of Catalan is CATALAN NUM = {0} !",
                    numberCatalan);
            }
        }
    }
}