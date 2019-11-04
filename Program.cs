using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pangram2
{
    class Pangram
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            System.Console.WriteLine("Enter a string");
            string ip = System.Console.ReadLine();

            foreach (char c in alpha)
            {
                foreach (char l in ip.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
                System.Console.WriteLine("String is pangram");
            else
                System.Console.WriteLine("Not a pangram");

            System.Console.ReadLine();
        }
    }
}
