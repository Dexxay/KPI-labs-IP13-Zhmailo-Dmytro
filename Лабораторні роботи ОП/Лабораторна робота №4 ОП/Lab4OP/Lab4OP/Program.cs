using System;

namespace Lab4OP
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Варіант 13
             Необхідно за законом y0 = a; yi = 1/2(yi-1 + x/yi-1), i = 1,2,3...
             знайти n-й член послідовності y1,y2,….yn при заданих числах a, x, n.
             (n - нат. число, a, x - додатні дійсні числа)
            */

            string typed_in;
            double prev_result;
            Console.Write("Введiть значення x: ");
            typed_in = Console.ReadLine();
            double x = Convert.ToDouble(typed_in);
            while (x <= 0)
            {
                Console.Write("Введiть коректне значення x: ");
                typed_in = Console.ReadLine();
                x = Convert.ToDouble(typed_in);
            }

            Console.Write("Введiть значення a: ");
            typed_in = Console.ReadLine();
            double a = Convert.ToDouble(typed_in);
            while (a <= 0)
            {
                Console.Write("Введiть коректне значення a: ");
                typed_in = Console.ReadLine();
                a = Convert.ToDouble(typed_in);
            }

            Console.Write("Введiть значення n: ");
            typed_in = Console.ReadLine();
            int n = Convert.ToInt32(typed_in);
            while (n <= 0)
            {
                Console.Write("Введiть коректне значення n: ");
                typed_in = Console.ReadLine();
                n = Convert.ToInt32(typed_in);
            }

            double result = (a + (x / a))/2.0;
            for (int i = 1; i <= n; i++)
            {
                prev_result = result;
                result = (prev_result + (x / prev_result))/2.0;
            }
            Console.WriteLine($"y{n} = {result} ");
            Console.ReadKey();
        }
    }
}
