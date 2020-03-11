using System;

namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розміри масиву в різних строках");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] array =CreatingAndFillingTheArray(n,m);
            PrintArray(array);
            Console.Write("\n");
            SumElementsInPositiveRows(array);
        }
        static int[,] CreatingAndFillingTheArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(-7, 21);
            }
            return array;
        }
        static void SumElementsInPositiveRows (int[,] array)
        {
            int count=0;
            for (int j=0;j<array.GetLength(1);j++)
            {
                count = 0;
                for (int i=0;i<array.GetLength(0);i++)
                {
                    if (array[i, j] >= 0)
                        count += array[i, j];
                    else
                    {
                        count = 0;
                        break;
                    }
                }
                PrintResult(count, j);

            }
        }
        static void PrintArray (int[,] array)
        {
            for (int i=0;i<array.GetLength(0);i++)
            {
                int k = 1;
                for (int j=0;j<array.GetLength(1);j++)
                {
                    if (array.GetLength(1)==k)
                        Console.Write("{0,5}\n", array[i, j]);
                    else
                        Console.Write("{0,5}", array[i, j]);
                    k++;
                }
            }
        }
        static void PrintResult (int count,int j)
        {
            if (count!=0)
            Console.WriteLine("В {0}-му стовпчику сума дорівнює {1}", j, count);
        }
    }
}
