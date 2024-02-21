using System;

namespace TypeCasting
{

    class TypeCasting
    {

        static void Main(string[] args)
        {

            //Implicit Casting
            Console.WriteLine("******************* IMPLICIT CASTİNG *********************");
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine("int : "+myInt);      // Outputs 9
            Console.WriteLine("int'dan double'a dönüşüm : "+myDouble);   // Outputs 9
            Console.WriteLine();
            //Explicit Casting
            Console.WriteLine("******************* EXPLICIT CASTİNG *********************");
            double myDouble_2 = 9.78;
            int myInt_2 = (int) myDouble_2;    // Manual casting: double to int

            Console.WriteLine("double: "+myDouble_2);   // Outputs 9.78
            Console.WriteLine("double'dan int'e : " + myInt_2);      // Outputs 9
                    
            int myInt_3 = 10;
            double myDouble_3 = 5.25;
            bool myBool = true;

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("int : " + myInt_3);
            Console.WriteLine("double : " + myDouble_3);
            Console.WriteLine("bool : " + myBool);
            Console.WriteLine("int'den string'e : "+Convert.ToString(myInt_3));    // convert int to string
            Console.WriteLine("int'den double'a : "+Convert.ToDouble(myInt_3));    // convert int to double
            Console.WriteLine("double'dan Int32'ye : "+Convert.ToInt32(myDouble_3));  // convert double to int
            Console.WriteLine("bool'dan string'e : "+Convert.ToString(myBool));   // convert bool to string



        }

    }

}