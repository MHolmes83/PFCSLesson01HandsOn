using System;

namespace Lesson01HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = false;
            var wear = "Wear sunglasses!";
            var dontWear = "You don't need to wear sunglasses.";
            bool atBeach = true;
            var sunblock = "Sunblock is a good idea.";
            var noSunblock = "Sunblock isn't needed.";
            bool goAnyway = true;
            var going = "Awesome! Glad you don't mind clouds!";
            var nextTime = "No worries! Hopefully next time we will have more sun!";

            if(isSunny)
            {
                Console.WriteLine(wear);
                if(atBeach)
                {
                    Console.WriteLine(sunblock);
                }
                else
                {
                    Console.WriteLine(noSunblock);
                }
            }
            else
            {
                Console.WriteLine(dontWear);
            }
            if(goAnyway)
            {
                Console.WriteLine(going);
            }
            else
            {
                Console.WriteLine(nextTime);
            }
        }
    }
}