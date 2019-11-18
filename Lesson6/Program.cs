using System;



class Program
{
    static void Main()
    {
        int num;
        int count = 0;


        do
        {
            Console.Write("\nВведите положительное натуральное число не более 2 миллиардов: ");
            int.TryParse(Console.ReadLine(), out num);
            if (num < 10)
            {
                Console.Write("Введено неверное значение! Попробуйте ещё раз: ");
            }
            else break;

        } while (true);

        do
        {

            if (num % 2 == 0) count++;
            num = num/10;
        } while (num > 0);

        Console.WriteLine("Количество четных чисел равно {0}", count);



    }
}