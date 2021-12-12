using System;

namespace Lab7CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            string input = Console.ReadLine();
            int size = Convert.ToInt32(input);
            while (size < 0)
            {
                Console.Write("Wrong n. Input correct n: ");
                input = Console.ReadLine();
                size = Convert.ToInt32(input);
            }
            int[] array = new int[size];
            FillAray(array);
            Console.WriteLine("Generated array:");
            DisplayArray(array);
            double abs_average = FindAbsAverage(array);
            double[] final_array = new double[size];
            FillFinalArray(final_array, array, abs_average);
            Console.WriteLine("New array:");
            DisplayArray(final_array);
            Console.ReadKey();
        }

        static void FillAray(int [] arr) /* Функція, яка заповнює масив випадковими значеннями (як і додатними, так і від'ємними) */
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-25, 25);
            }
        }

        static void DisplayArray<T>(T[] arr) /* Функція, яка виводить значення кожного елемента масива в консоль */ 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        static double FindAbsAverage(int [] arr) /* Функція, яка шукає модуль середнього арифметичного 
                                                  * від'ємних чисел масива (повертає одиницю при відсутності від'ємних чисел) */
        {
            double average = 0;
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    average += arr[i];
                    k++;
                }
            }
            if (k == 0)
            {
                average = 1;
            }
            else
            {
                average = Math.Abs(average / k);
            }

            return average;
        }

        static void FillFinalArray(double [] new_arr, int[] arr, double multiplier) /* Фкнкція, яка заповнює новий масив відповідно до умови задачі 13-го варіанту 
                                                                                     * (індексація масиву починається з 0, а 0 - це парне число) */
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    new_arr[i] = arr[i] * multiplier;
                }
                else
                {
                    new_arr[i] = (double)arr[i];
                }
            }
        }
    }
}
