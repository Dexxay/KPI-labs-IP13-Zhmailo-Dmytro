using System;

namespace Lab5OP
{
    class Program
    {
        static void Main(string[] args)
        {
            int last_n = 100;
            for (int i = 1; i <= last_n; i++)
            {
                int number = i;
                bool palindrome = ((i / 10) == (number % 10)) || (number < 10);
                if (palindrome)
                {
                    int sqrd_number = (int)Math.Pow(number, 2);
                    int reversed_number = 0;
                    while (sqrd_number > 0)
                    {
                        int current = sqrd_number % 10;
                        reversed_number = (reversed_number * 10) + current;
                        sqrd_number = sqrd_number / 10;
                    }
                    sqrd_number = (int)Math.Pow(number, 2);
                    palindrome = sqrd_number == reversed_number;
                    if (palindrome)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
