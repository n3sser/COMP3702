using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

        }
    }
}
