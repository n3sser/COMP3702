using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList intList = new ArrayList() {"1", "2", "3", "4", "5" };

            for (int i = 0; i < 5; i++)
            {
                Console.Write(intList[i] + "\n");
            }

            String item;
            Console.Write("Enter item to search for: ");
            item = Console.ReadLine();

            if (intList.Contains(item))
            {

                Console.WriteLine("Is found");

            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }

    
}
