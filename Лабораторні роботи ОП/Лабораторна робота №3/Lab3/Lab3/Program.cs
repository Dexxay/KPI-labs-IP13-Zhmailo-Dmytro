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
            double x = Convert.ToDouble(input);
            while (x < 0 || x > 5)
            {
                Console.Write("Введiть коректне значення x: ");
                input = Console.ReadLine();
                x = Convert.ToDouble(input);
            }
            double result = 0;
            double prev_result = 0;
            double difference = 1;
            int number_x2 = 4;
            int i;
            double factorial;
            double epsilon = Math.Pow(10, -4);
                while (difference > epsilon)
                {
                    prev_result = result;
                    factorial = 1;
                    i = 2;
                    while (i <= number_x2)
                    {
                        factorial *= i;
                        i++;
                    }
                    result = prev_result + (Math.Pow(x, number_x2) / factorial);
                    difference = Math.Abs(result - prev_result);
                    number_x2 += 4;
                }     
            Console.WriteLine($"Сума парних компонент ряду при x = {x}, дорiвнює {result}");
            Console.ReadKey();
        }
    }
}
