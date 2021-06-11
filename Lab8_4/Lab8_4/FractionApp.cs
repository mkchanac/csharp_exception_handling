using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab8_4
{
    class FractionApp
    {
        static void Main()
        {
            int numberator = 0;
            int denominator = 0;
            string inValue;

            try 
            {
                Write("Enter the numberator: ");
                inValue = ReadLine();
                numberator = int.Parse(inValue);
                Write("Enter the denominator: ");
                inValue = ReadLine();
                denominator = int.Parse(inValue);
                Fraction number = new Fraction(numberator, denominator);
                Write(number);
                DisplayResult(numberator, denominator);


            }
            catch (FormatException e) 
            {
                WriteLine(e.Message); 
            }
            catch (ArithmeticException e) 
            {
                WriteLine(e.Message);
            }

            ReadKey();

        }

        public static void DisplayResult(int num, int deno) 
        {
            if (deno == 0)
                throw new ArithmeticException("\nDenominator cannot be assigned as Zero. ");
            else
                WriteLine("\nThe fraction of your input is {0}/{1}.", num, deno);
                   
        }
    }
}
