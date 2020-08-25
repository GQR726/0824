using System;

namespace _08253
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2)
            {
                Console.WriteLine("{0} is bigger", num1);
            }
            else
            {
                Console.WriteLine("{0} is bigger", num2);
            }
            Console.ReadKey();

            
        }
    }
}
