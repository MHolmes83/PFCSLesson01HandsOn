using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace newApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting;
            greeting = "Hello, World!";

            Console.WriteLine(greeting);

            greeting = "Hi World!";

            Console.WriteLine(greeting);

            /*  greeting = 5;

             Console.WriteLine(greeting); */

            int age;
            age = 40;

            Console.WriteLine(age);

            int sum;
            sum = 2 + 2;
            int newSum;
            newSum = sum + 10;

            Console.WriteLine(sum);
            Console.WriteLine(newSum);


            bool isOpen = true;
            Console.WriteLine(isOpen);

            bool isOpenAgain = false;

            if (isOpenAgain == true)
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Sad day");
            }

            int newAge = 25;
            Console.WriteLine(newAge);

            var name = "Morgaan Holmes";
            Console.WriteLine(name);

            double number = 2.71;
            Console.WriteLine(number);



        }
    }
}


