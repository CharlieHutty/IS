using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenege_19
{
    class Program
    {
        //Variables
        static string LogicGate;
        static int input1;
        static int input2;
        static int Result;

        static void Main(string[] args)
        {
            Console.Write("What is the logic gate you'd like to use (AND, OR, NOR, XOR and NAND) ");
            LogicGate = Console.ReadLine();

            Console.Write("What is the value of input 1: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the value of input 2: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            if (LogicGate == "OR" || LogicGate == "or")
            {
                OR();
            }
            else if (LogicGate == "AND" || LogicGate == "and")
            {
                AND();
            }
            else if (LogicGate == "XOR" || LogicGate == "xor")
            {
                XOR();
            }

            Console.ReadKey();
        }

        //static void Check()
        //{
          //  if (input1 != 1 || input1 != 0 && input2 != 1 || input2 != 0)
            //{
              //  Console.Write("Please try agsin: ");
            //}

        //}

        static void OR()
        {
            
            if (input1 + input2 >= 1)
            {
                Result = 1;

                Console.WriteLine("The result is: " + Result);
            }
            else
            {
                Result = 0;
                Console.WriteLine("The result is: " + Result);
            }
        }

        static void AND()
        {
            if (input1 + input2 == 2)
            {
                Result = 1;
                Console.WriteLine("The result is: " + Result);
            }
            else
            {
                Result = 0;
                Console.WriteLine("The result is: " + Result);
            }
        }

        static void XOR()
        {
            if (input1 + input2 == 1)
            {
                Result = 1;
                Console.WriteLine("The result is: " + Result);
            }
            else
            {
                Result = 0;
                Console.WriteLine("The result is: " + Result);
            }

        }
    }
}
