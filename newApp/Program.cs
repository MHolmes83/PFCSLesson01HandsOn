using System;

namespace newApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string greeting;
            greeting = "Hi World!";
            
            Console.WriteLine(greeting);
            
            greeting = "Hello User!";
            
            Console.WriteLine(greeting);
            
            int age;
            age = 38;

            Console.WriteLine(age);

            int sum;
            sum = 2 + 2;

            int newSum;
            newSum = sum + 10;

            Console.WriteLine(sum);
            Console.WriteLine(newSum);

            bool isOpen = false;

            if (isOpen == true)
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Sad day");
            }
            
        }
    }
}