using System;

namespace UsingForAndForeach
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************************************");
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************************************");
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            Console.WriteLine("*****************************************");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }




        }
    }
}
