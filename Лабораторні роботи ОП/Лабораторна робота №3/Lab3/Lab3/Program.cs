using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             13. Для х ∈ [ 0, 5 ] з точністю ε = 10^-4 знайти суму парних компонент ряду
            1-x^2/2! + x^4/4! - x^6/6! + ... + ((-1)^n * x^2n)/(2n)!
             */
            Console.Write("Введiть значення x: ");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            while (x < 0 || x > 5)
            {
                Console.Write("Введiть коректне значення x: ");
                input = Console.ReadLine();
                x = Convert.ToInt32(input);
            }
            double result = 0;
            double prev_result = 0;
            double difference = 1;
            int number = 2;
            int i;
            double factorial;
            double epsilon = Math.Pow(10, -4);
                while (difference > epsilon)
                {
                    prev_result = result;
                    factorial = 1;
                    i = 2;
                    while (i <= 2 * number)
                    {
                        factorial *= i;
                        i++;
                    }
                    result = prev_result + (Math.Pow(x, number * 2) / factorial);
                    difference = Math.Abs(result - prev_result);
                    Console.WriteLine($"prev {prev_result} curr {result} n {number} fact {factorial} diff {difference}");
                    number += 2;
                }     
            Console.WriteLine($"Сума парних компонент ряду при x = {x}, дорiвнює {result}");
            Console.ReadKey();
        }
    }
}
