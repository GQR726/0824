using System;

namespace _08252
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you");
            string ans = Console.ReadLine();
            if (ans == "fine")
            {
                Console.WriteLine("Life is great!");
            }
            else
            {
                Console.WriteLine("Everything's gonna be alright.");
            }
            Console.ReadKey();

            
        }
    }
}
