using System;
namespace ConsoleApp1
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Массив до изменений:");
            Console.WriteLine(string.Join(", ", array));
            fixed (int* ptr = array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    *(ptr + i) += 10;
                }
            }
            Console.WriteLine("Массив после изменений:");
            Console.WriteLine(string.Join(", ", array));
            int x = 50;
            int* p = &x;
            Console.WriteLine("\nЗначение x: " + x);
            Console.WriteLine("Адрес x: " + (ulong)p);
            int** pp = &p;
            Console.WriteLine("Значение через указатель: " + *p);
            **pp = 999;
            Console.WriteLine("Новое значение x: " + x);
            Console.ReadKey();
        }
    }
}