using System;

namespace HomeworkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Student Group========");
            Console.WriteLine(" ");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Stefani", "Jana", "Maja", "Petar", "Angel" };

            for (; ; )
            {
                Console.WriteLine("Input a number:");
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (success)
                {
                    if (number == 1)
                    {
                        Console.WriteLine("The students in G1 are:");
                        for (int i = 0; i < studentsG1.Length; i++)
                        {
                            Console.WriteLine(studentsG1[i]);
                        }
                        break;
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("The students in G2 are:");
                        for (int i = 0; i < studentsG2.Length; i++)
                        {
                            Console.WriteLine(studentsG2[i]);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please insert a number between 1 or 2:");
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                }
            }

            Console.ReadLine();


        }
    }
}
