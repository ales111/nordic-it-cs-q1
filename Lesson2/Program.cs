using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите в: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            int x = a + b;
            int e = a - b;

            Console.WriteLine("Результат с = {0}", c);
            Console.WriteLine("Результат x = {0}", x);
            Console.WriteLine("Результат e = {0}", e);
            Console.ReadKey();
        }
    }
}
