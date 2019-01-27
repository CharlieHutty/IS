using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenege_6
{
    class Program
    {
        static string Conversion;
        static double NumberToConvert;
        static double Answer;

        static void Main(string[] args)
        {
            Console.WriteLine("Celcius to Fahrenheit ('CtoF'), Fahrenheit to Celcius ('FtoC')");
            Console.WriteLine("Pounds to Euro ('GBPtoEuro'), Pounds to Dollars ('EurotoGBP')");
            Console.WriteLine("Litres to Millitres ('LtoMl'), Millitres to Litres ('MltoL')");
            Console.Write("What conversion would you like to do: ");
            Conversion = Console.ReadLine();

            Console.Write("What is the number you'd like to convert: ");
            NumberToConvert = Convert.ToInt32(Console.ReadLine());

            if (Conversion == "CtoF" || Conversion == "ctof" || Conversion == "Celcius to Fahrenheit")
            {
                CtoF();
            }
            else if (Conversion == "FtoC" || Conversion == "ftoc" || Conversion == "Fahrenheit to Celcius")
            {
                FtoC();
            }
            else if (Conversion == "GBPtoEuro" || Conversion == "gbptoeuro" || Conversion == "Pounds to Euro")
            {
                GBPtoEuro();
            }
            else if (Conversion == "EurotoGBP" || Conversion == "eurotpgbp" || Conversion == "Euro to Pounds")
            {
                EurotoGBP();
            }
            else if (Conversion == "LitrestoMillimetres" || Conversion == "litrestomillitres" || Conversion == "Litres to Millitres")
            {
                LitrestoMillitres();
            }
            else if (Conversion == "MillitrestoLitres" || Conversion == "millitrestolitres" || Conversion == "Millitres to Litres")
            {
                MillitrestoLitres();
            }

            Console.ReadKey();
        }
        static void CtoF()
        {
            //(Celcius * 1.8) + 32 
            Answer = ((NumberToConvert * 1.8) + 32);
            Console.WriteLine(Answer + "°F");
        }
        static void FtoC()
        {
            //(Fahrenheit - 32) * 5/9
            Answer = (NumberToConvert - 32) * 5 / 9;
            Console.WriteLine(Answer + "°C");
        }
        static void GBPtoEuro()
        {
            //Pounds * 1.13
            Answer = (NumberToConvert * 1.13);
            Console.WriteLine("€" + Answer);
        }
        static void EurotoGBP()
        {
            //Euro / 1.13
            Answer = (NumberToConvert / 1.13);
            Console.WriteLine("£" + Answer);
        }
        static void LitrestoMillitres()
        {
            //Litres * 1000
            Answer = (NumberToConvert * 1000);
            Console.WriteLine(Answer + "ML");
        }
        static void MillitrestoLitres()
        {
            //Millitres / 1000 
            Answer = (NumberToConvert / 1000);
            Console.WriteLine(Answer + "L");
        }

    }
}
