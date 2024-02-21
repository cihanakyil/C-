using System;

namespace IfElseUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."



            int time2 = 22;
            if (time2 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time2 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            int time3 = 20;
            string result = (time3 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
