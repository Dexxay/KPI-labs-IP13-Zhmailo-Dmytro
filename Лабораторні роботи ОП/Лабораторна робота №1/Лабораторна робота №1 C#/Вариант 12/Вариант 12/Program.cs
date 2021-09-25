using System;

namespace Вариант_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Варіант 12: Задана довжина окола, знайти площу круга, обмеженого цим околом
            Console.WriteLine("Введiть довжину околу, будь ласка");
            Console.Write("Довжина околу = ");
            string type = Console.ReadLine();
            double radius = Convert.ToDouble(type) / (Math.PI * 2);
            double result = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("Площа круга, обмеженого заданим околом = {0}", result);
            Console.ReadKey();
        }
    }
}