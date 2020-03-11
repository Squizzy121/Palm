using System;

namespace Block_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів масиву");
            int n = int.Parse(Console.ReadLine());
            int[] array = CreatingAndFillingTheArray(n);
            array = ResizingArrayAndAddingAnElement(array);
            Console.WriteLine("Перелік елементів зміненного масиву:");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
        }
        static int[] CreatingAndFillingTheArray(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 100);
            return array;
        }
        static int[] ResizingArrayAndAddingAnElement(int[] array)
        {
            Array.Resize(ref array, array.Length + 1);
            Console.WriteLine("Введіть елемент, який ви хочете добавити в кінець масиву");
            array[array.Length - 1] = int.Parse(Console.ReadLine());
            return array;
        }
    }
}
