using System;

namespace UserInput
{

    class UserInput
    {

        static void Main(string[] args)
        {

            Console.Write("Kullanici Adinizi Girin : ");
            string userName = Console.ReadLine();

            Console.Write("Yasinizi Girin : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kullanici Adiniz : " + userName);
            Console.WriteLine("Yasiniz : " + age);



        }

    }

}