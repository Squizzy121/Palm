using System;

namespace Block_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розміри масиву в двох строках через клавішу Enter");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] array = CreatingAndFillingTheArray(n, m);
            PrintMatrix(array);
            int[,] array_T = MatrixTransposition(array, n, m);
            Console.WriteLine("Транспонована матриця:");
            PrintMatrix(array_T);
        }
        static int[,] CreatingAndFillingTheArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }
            return array;
        }
        static int[,] MatrixTransposition(int[,] array, int n, int m)
        {
            int[,] array_T = new int[m, n];
            for (int i = 0; i < array_T.GetLength(0); i++)
            {
                for (int j = 0; j < array_T.GetLength(1); j++)
                {
                    array_T[i, j] = array[j, i];
                }
            }
            return array_T;
        }
        static void PrintMatrix(int[,] array_T)
        {
            for (int i = 0; i < array_T.GetLength(0); i++)
            {
                int k = 1;
                for (int j = 0; j < array_T.GetLength(1); j++)
                {
                    if (k == array_T.GetLength(1))
                        Console.Write("{0,5}\n", array_T[i, j]);
                    else
                        Console.Write("{0,5}", array_T[i, j]);
                    k++;
                }
            }
        }
    }
}
