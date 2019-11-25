using System;



class Program
{
    static void Main()
    {
        int num;
        int count = 0;

        {
            do
            {


                Console.Write("\nВведите положительное натуральное число не более 2 миллиардов: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num > 0) break;
            } while (true);
            do

                try
                {

                    if (num > 2000000000) continue;



                }
                catch (OverflowException)
                {

                    Console.Write("Ошибка");
                    continue;
                } while (num > 2000000000);

        }


                do
                {
                    if (num % 2 == 0) count++;
                    num = num / 10;
                } while (num > 0);

               Console.WriteLine("Количество четных чисел равно {0}", count);



          
    }
}