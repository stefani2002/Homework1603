using System;

namespace HomeworkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============SumOfEven==========");

            int sum = 0;
            int[] arrayOfIntegers = new int[5];

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());

                if (arrayOfIntegers[i] % 2 == 0)
                {
                    sum += arrayOfIntegers[i];
                }
                
            }

            Console.WriteLine("The sum of even numbers is:");
            Console.WriteLine(sum);


           Console.ReadLine();

        }
    }
}
