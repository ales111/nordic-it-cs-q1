using System;

namespace Lesson8
{
    public class Human
    {
        protected string name;
        public string Name
        {
            get { return name; }
        }
        protected int age;
        public int Age
        {
            get { return age; }
        }
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Human[] array = new Human[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name: ");
                string imya = Console.ReadLine();
                Console.Write("Enter age: ");
                int vozrast = Convert.ToInt32(Console.ReadLine());
                array[i] = new Human(imya, vozrast);


            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name: " + array[i].Name + ", age in 4 years: " + array[i].Age);
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();

        }
    }
}