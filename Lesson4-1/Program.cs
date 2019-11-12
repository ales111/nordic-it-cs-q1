using System;

class Program
{
    enum Month : int { Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12 };
    public static void Main()
    {
        Console.WriteLine("Введите число месяца ");

        int monthNumber = int.Parse(Console.ReadLine());

        int thisMonth = (int)monthNumber;
        if (monthNumber > 12) Console.Write("Месяца с таким номером нет");

        Console.WriteLine(Enum.GetName(typeof(Month), thisMonth).ToString());
        Console.ReadKey();


    }
}