// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = ReadInt("Введите число M: ");
            int N = ReadInt("Введите число N: ");

            Console.Write("натуральные числа в промежутке от M до N: ");
            Ints(M, N);
            Console.WriteLine();
        }


        // выводит значение найменьшего натурального числа из промежутка [M, N], затем прибавляет к нему единицу.
        static void Ints(int leftRange, int rightRange)
        {
            if (leftRange > rightRange) { return; }

            if (leftRange > 0)
            {
                Console.Write(leftRange + " ");
                leftRange += 1;

                Ints(leftRange, rightRange);
            }

            if (leftRange <= 0 && rightRange != 0)
            {
                leftRange = 1;
                Console.Write(leftRange + " ");
                leftRange += 1;

                Ints(leftRange, rightRange);
            }

        }
        // возвращает целое число, введенное в терминале
        static int ReadInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
    }

}