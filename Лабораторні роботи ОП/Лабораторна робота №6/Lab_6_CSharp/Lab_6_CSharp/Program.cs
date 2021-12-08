using System;

namespace Lab_6_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a(a > 0): ");
            string input = Console.ReadLine();
            double a = Convert.ToDouble(input);
            
            while (a <= 0)
            {
                Console.Write("Wrong a. Input correct a(a > 0): ");
                input = Console.ReadLine();
                a = Convert.ToDouble(input);
            
            }
            Console.Write("Input n(n > 0): ");
            input = Console.ReadLine();
            int number = Convert.ToInt32(input);
           
            while (number <= 0)
            {
                Console.Write("Wrong n. Input correct n(n > 0): ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
            }

            double numerator = newton_formula(3, a, number) - newton_formula(6, (Math.Pow(a, 2) + 1), number);
            double denominator = 1 + newton_formula(7, (3 + a), number);
            double result = numerator / denominator;
            Console.WriteLine($"Result = {result}");
            Console.ReadKey();
        }
        static double newton_formula(double k, double x, int n) /* Рекурентна формула Ньютона для знаходження кореня k-ого степеня
                                                                 дійсного числа a (a>0) з точністю n, представлена у вигляді функції */
        {
            double curr_x = x;
            for (int i = 0; i < n; i++)
            {
                curr_x = (1 / k) * ((x / Math.Pow(curr_x, (k - 1))) + (curr_x * (k - 1)));
            }
            return curr_x;
        }
    }
}
