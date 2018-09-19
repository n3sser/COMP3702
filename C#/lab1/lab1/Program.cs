using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Nasser, Mohammed, Nasser, Aalsubhi";

            string[] strArr = str.Split(',');

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i].Trim());
            }
            


        }
    }
}
