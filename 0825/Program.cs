using System;
using System.Diagnostics.Contracts;

namespace _0825
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name =  Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Good Morning {0} !! Your age is {1}", name, age);
            Console.ReadKey();

            
        }
    }
}
