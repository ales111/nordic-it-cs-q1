using System;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array1.Length; i++) {
                string tableline = "";

            
                for (int j = 0; j < array2.Length; j++)
                {
                    int result = array1[i] * array2[j];

                    tableline = tableline + " " + result;
                    


                }
                Console.WriteLine(tableline);

            }

            


        }
    }
}
