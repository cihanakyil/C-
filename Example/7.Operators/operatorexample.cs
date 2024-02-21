using System;

namespace Operators
{

    class Operators
    {

        static void Main(string[] args)
        {

            int x = 25;
            int y = 5;
            int z = 10;
            int t = 20;
            int u = 30;
            int v = 6;
            int w = 7;
            int k = 8;
            int l = 9;
            int m = 12;

             
  


            Console.WriteLine("int x = " + x);
            Console.WriteLine("int y = " + y);
            Console.WriteLine("int z = " + z);  
            Console.WriteLine("int t = " + t);
            Console.WriteLine("int u = " + u);
            Console.WriteLine("int v = " + v);
            Console.WriteLine("int w = " + w);
            Console.WriteLine("int k = " + k);
            Console.WriteLine("int l = " + l);
            Console.WriteLine("int m = " + m);
            
            Console.WriteLine("**************************ARITHMETIC OPERATORS******************************");

            Console.WriteLine("x+y : " + (x+y));
            Console.WriteLine("x-y : " + (x-y));
            Console.WriteLine("x*y : " + (x*y));
            Console.WriteLine("x/y : " + (x/y));
            Console.WriteLine("x++ : " + (x++));
            Console.WriteLine("x-- : " + (x--));  

            Console.WriteLine("**************************ASSIGNMENT OPERATORS*******************************");

            Console.WriteLine("int x = " + x);

            x += 5;
            y -= 2;
            z *=3;
            t /=5;
            u %=7;
            v &=3;
            w |= 3;
            k ^= 3;
            l >>= 3;
            m <<= 3;

            Console.WriteLine("x +=5 : " + x);  
            Console.WriteLine("y -=2 : " + y);  
            Console.WriteLine("z *=3 :" + z);  
            Console.WriteLine("t /=5 : " + t);
            Console.WriteLine("u %=7 : " + u);  
            Console.WriteLine("v %=3 : " + v);  
            Console.WriteLine("w |=3 : " + w);  
            Console.WriteLine("k ^=3 : " + k);  
            Console.WriteLine("l >>=3 : " + l); 
            Console.WriteLine("m <<=3 : " + l);  

            Console.WriteLine("************************COMPARISON OPERATORS***********************************");

            Console.WriteLine("x == y : " + (x == y));
            Console.WriteLine("x != y : " + (x != y));
            Console.WriteLine("x > y : " + (x > y));
            Console.WriteLine("x < y : " + (x < y));
            Console.WriteLine("x >= y : " + (x >= y));
            Console.WriteLine("x <= y : " + (x <= y));

            Console.WriteLine("************************LOGICAL OPERATORS***********************************");

            Console.WriteLine("x > 3 && x < 10 : "+ (x > 3 && x < 10));
            Console.WriteLine("x > 3 || x < 4 : " + (x > 3 || x < 4)); 
            Console.WriteLine("!(x > 3 && x < 10) : "+ !(x > 3 && x < 10));





        }

    }

}