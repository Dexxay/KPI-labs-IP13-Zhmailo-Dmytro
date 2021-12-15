using System;

namespace Lab8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = InputNumber();
            int[,] result = GenerateMatrix(number);
            DisplayMatrix(result);
        }
        static int InputNumber() /* Функція, яка використовується для введення користувачем 
                          * значення n (розмірності квадратної матриці); n > 0 */
        {
            Console.Write("Input n: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            while (n < 1)
            {
                Console.Write("Wrong n. Input correct n (n>0) : ");
                input = Console.ReadLine();
                n = Convert.ToInt32(input);
            }
            Console.WriteLine();
            return n;
        }

        static int[,] GenerateMatrix(int n) /* Функція, яка генерує двовимірну 
                                             * квадратну матрицю відповідно до умови задачі */
        {
            int[,] matrix = new int[n, n];

            Random rand = new Random();
            int min_rand = -25, max_rand = 25;
            int last_column = n - 1;

            for (int j = 0; j < n; j++)
            {
                matrix[0, j] = rand.Next(min_rand, max_rand + 1);
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == last_column)
                    {
                        matrix[i, j] = matrix[i - 1, 0];
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j + 1];
                    }
                }
            }

            return matrix;
        }

        static void DisplayMatrix(int[,] matrix) /* Функція, яка виводить у консоль значення
                                                  кожного елементу двовимірної квадратної матриці */
        {
            int size = matrix.GetLength(0);
            Console.WriteLine("Generated matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
