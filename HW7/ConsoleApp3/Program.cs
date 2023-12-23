// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("введите число элементов n: ");
            int[] myArray = CreateArray(n);

            PrintArray("исходный массив:", myArray);

            Console.WriteLine("\nэлементы исходного массива в обратном порядке:");
            PrintElementsReverseArray(myArray, n);
            Console.WriteLine();

        }

        // возвращает целое число, введенное в терминале
        static int ReadInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        // создает массив
        static int[] CreateArray(int size)
        {
            int[] myArray = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
                myArray[i] = random.Next(1, 10);
            return myArray;
        }

        // выводит массив в консоль
        static void PrintArray(string msg, int[] array)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        // выводит элементы массива от большего индекса к меньшему
        static void PrintElementsReverseArray(int[] array, int n)
        {
            if (n == 0) { return; }
            Console.Write(array[n - 1] + " ");
            n -= 1;
            PrintElementsReverseArray(array, n);
        }
    }
}