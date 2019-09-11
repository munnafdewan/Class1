using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is your Name?");
            string Name = Console.ReadLine();

            Console.WriteLine("How old are you ?");
            string Age = Console.ReadLine();

            Console.WriteLine("Enter your phone number:");
            string Contact = Console.ReadLine();

            Console.WriteLine("Enter your Address:");
            string address = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("My name is " + Name + Environment.NewLine + "I am " + Age + Environment.NewLine + "My phone number is " + Contact + Environment.NewLine + "I am from " + address + Environment.NewLine + "Thank You for Giving me Your information");
            Console.ReadKey();
        }
    }
}