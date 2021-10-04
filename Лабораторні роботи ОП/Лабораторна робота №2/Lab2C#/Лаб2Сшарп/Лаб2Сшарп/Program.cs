using System;

namespace Лаб2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Маємо графік рівняння, що складається з кола, заданого рівнянням (x-1)^2 + y^2 = 4,
            обмеженого на проміжку по осі абсцис так, що -1 ≤ x ≤ 1 і прямих y1 = x-3, y2 = -x+3,
            обмежених на проміжку по осі абсцис так, що 1 ≤ x ≤ 3. 
            Необхідно визначити чи належить точка з координатами (x, y) області, обмеженою двома відрізками і півколом.
            */
            Console.Write("Введiть значення x: ");
            string userInput = Console.ReadLine();
            double x = Convert.ToDouble(userInput);
            Console.WriteLine();
            Console.Write("Введiть значення y: ");
            userInput = Console.ReadLine();
            double y = Convert.ToDouble(userInput);
            bool result;
            if (-1 <= x && x <= 3)
            {
                if (-1 <= x && x <= 1)
                {
                    if (Math.Pow( (x-1), 2) + Math.Pow(y, 2) <= 4)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    if (Math.Abs(y) <= -x + 3d)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            else
            {
                result = false;
            }

            Console.WriteLine();

            if (result == true)
            {                
                Console.WriteLine("Точка належить заданiй областi");
            }
            else
            {
                Console.WriteLine("Точка не належить заданiй областi");
            }
            Console.ReadKey();



        }
    }
}
