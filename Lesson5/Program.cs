using System;

class Program
{


    static void Main()
    {
        Console.WriteLine("Введите тип фигуры(1 - Круг, 2 - Прямоугольник, 3 - Треугольник)");
        int figureNumber = int.Parse(Console.ReadLine());
        if (figureNumber < 1 || figureNumber > 3)
        {
            throw new Exception("Введенное значение выходит за допустимые пределы от 1 до 3");
        }
        if (figureNumber == 1)
        {
            Console.WriteLine("Введите радиус круга ");
        }
        if (figureNumber == 2)
        {
            Console.WriteLine("Введите ширину и высоту прямоугольника ");
        }
        if (figureNumber == 3)
        {
            Console.WriteLine("Введите основание и высоту треугольника ");
        }
        try
        {
            double i = double.Parse(Console.ReadLine());
            if (figureNumber == 1)
            {
                double a = (Math.PI * 2) * i;
                Console.WriteLine("Длина окружности равна {0}", a);
            }

            else if (figureNumber == 2)
            {
                double o = double.Parse(Console.ReadLine());
                double x = i * o;
                double p = 2 * (i + o);
                Console.WriteLine("Площадь прямоугольника равна {0}", x);
                Console.WriteLine("Периметр прямоугольника равен {0}", p);
            }
            else if (figureNumber == 3)
            {
                double u = double.Parse(Console.ReadLine());
                double z = 0.5 * (i * u);
                Console.WriteLine("Площадь треугольника равна {0}", z);

            }
        }
        catch (FormatException)
        {
            Console.WriteLine("ввод пользователем нечислового значения");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}