using System;

class Program
{
    static void Main()
    {
        string[] names = new string[3];
        int[] ages = new int[3];

         for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Введите имя: ");
            names[i] = Console.ReadLine();
            Console.Write("Введите возраст: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

        }

 
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Name: " + names[i] + ", age in 4 years: " + ages[i]);
        }

        Console.ReadKey();
    }
}
