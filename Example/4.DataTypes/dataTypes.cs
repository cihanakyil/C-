using System;

namespace DataTypes
{

    class DataTypes
    {

        static void Main(string[] args)
        {

            int myNum = 5;                   // Integer (whole number)  4 byte
            long myNumLong = 15000000000L;   // 8 byte

            double myDoubleNum = 5.99D;      // Floating point number   8 byte
            float myFloatNum = 5.75F;        // 4 byte
            float f1 = 35e3F;
            double d1 = 12E4D;  


            bool myBoolTrue = true;          // Boolean     1 bit
            bool myBoolFalse = false;          // Boolean   

            char myLetter = 'D';             // Character   2 byte
            string myText = "Hello";         // String      2 byte per character

            
            Console.WriteLine("int: " + myNum);
            Console.WriteLine("long: " + myNumLong);
            Console.WriteLine("double: " + myDoubleNum);
            Console.WriteLine("float: " + myFloatNum);
            Console.WriteLine("float_2: " + f1);
            Console.WriteLine("double_2: " + d1);
            Console.WriteLine("boolTrue: " + myBoolTrue);
            Console.WriteLine("boolFalse: " + myBoolFalse);
            Console.WriteLine("char: " + myLetter);
            Console.WriteLine("string: " + myText);



        }

    }

}