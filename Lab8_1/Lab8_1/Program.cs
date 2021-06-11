using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab8_1
{
    class Program
    {
        static void Main()
        {
            int value1 = 0;
            int value2 = 0;
            string inValue;
            int product;

            try
            {
                Write("Enter the value1: ");
                inValue = ReadLine();
                value1 = int.Parse(inValue);
                Write("Enter the value2: ");
                inValue = ReadLine();
                value2 = int.Parse(inValue);
                product = CalculateProduct(value1, value2);
                WriteLine("Answer is {0}.", product);
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                WriteLine(e.Message);
            }
            finally { WriteLine("That is it today!!"); }
            ReadKey();
        }

        public static int CalculateProduct(int value1, int value2) 
        {
            return value1 * value2;
        }

    }
}
