// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = ReadInt("введите неотрицательное число m:");
            int n = ReadInt("введите неотрицательное число n:");

            Console.WriteLine(AckermannFunc(m, n));
        }

        // возвращает целое число, введенное в терминале
        static int ReadInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        // Функция Аккермана
        static int AckermannFunc(int m, int n)
        {
            if (m == 0) { return n += 1; }
            else if (n == 0 && m > 0) { return AckermannFunc((m - 1), 1); }
            else if (m > 0 && n > 0) { return AckermannFunc((m - 1), AckermannFunc(m, n - 1)); }
            else return -1; // вывод "-1" если m или n меньше 0
        }

    }
}