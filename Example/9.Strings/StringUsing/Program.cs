using System;

namespace StringUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************");

            string greeting = "Hello";
            Console.WriteLine(greeting);

            Console.WriteLine("********************************************************");


            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting2);

            Console.WriteLine("********************************************************");

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine(txt);
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            Console.WriteLine("********************************************************");

            string txt2 = "Hello World";
            Console.WriteLine(txt2);
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"

            Console.WriteLine("********************************************************");

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            Console.WriteLine("********************************************************");

            string firstName2 = "CIHAN";
            string lastName2 = "AKYIL";
            string name2 = string.Concat(firstName2, lastName2);
            Console.WriteLine(name2);

            Console.WriteLine("********************************************************");

            string x = "10";
            string y = "20";
            string z = x + y;  // z will be 1020 (a string)
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("********************************************************");

            string firstName3 = "John";
            string lastName3 = "Doe";
            string name3 = $"My full name is: {firstName3} {lastName3}";
            Console.WriteLine(name3);

            Console.WriteLine("********************************************************");

            string myString = "Hello";
            Console.WriteLine(myString);
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString[1]);  // Outputs "e"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            Console.WriteLine("********************************************************");

            string name4 = "John Doe";
            int charPos = name.IndexOf("D");
            string lastName4 = name.Substring(charPos);
            Console.WriteLine(name4);
            Console.WriteLine(charPos);
            Console.WriteLine(lastName4);

            Console.WriteLine("********************************************************");

            string txt3 = "We are the so-called \"Vikings\" from the north.";
            string txt4 = "It\'s alright.";
            string txt5 = "The character \\ is called backslash.";
            string txt6 = "Hello\nWorld!";
            string txt7 = "Hello\tWorld!";
            string txt8 = "Hel\blo World!";

            Console.WriteLine(txt3);
            Console.WriteLine("********************************************************");

            Console.WriteLine(txt4);
            Console.WriteLine("********************************************************");

            Console.WriteLine(txt5);
            Console.WriteLine("********************************************************");

            Console.WriteLine(txt6);
            Console.WriteLine("********************************************************");

            Console.WriteLine(txt7);
            Console.WriteLine("********************************************************");

            Console.WriteLine(txt8);
            Console.WriteLine("********************************************************");
        }
    }
}
