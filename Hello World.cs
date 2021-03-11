using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");

            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }
    }
}
