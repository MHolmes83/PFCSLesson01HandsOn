using System;

namespace Lesson01HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSunny = false;
            var atBeach = true;
            var goAnyway = true;
            
            var wear = "Wear sunglasses!";
            var dontWear = "You don't need to wear sunglasses.";

            var sunblock = "Sunblock is a good idea.";
            var noSunblock = "Sunblock isn't needed";
            
            var going = "Awesome! Glad you don't mind clouds";
            var nextTime = "No worries! Hopedully next time will have some sun!";
            

            if (isSunny)
            {
                Console.WriteLine(wear);
                Console.WriteLine(sunblock);
            }
    
            else if (atBeach)
            {
                Console.WriteLine(dontWear);
                Console.WriteLine(going);              
            }
            else if (goAnyway)
            {
                Console.WriteLine(going);
                Console.WriteLine(dontWear);
            }
            else
            {
                
                Console.WriteLine(noSunblock);
                Console.WriteLine(nextTime);
            }
        }
    }
}