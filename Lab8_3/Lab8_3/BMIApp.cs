using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab8_3
{
    class BMIApp
    {
        static void Main()
        {
            string inValue;
            int weight;
            int feet;
            int inch;
            int height;
            double BMI;

            try
            {

                Write("Enter your weight in lb: ");
                inValue = ReadLine();
                weight = int.Parse(inValue);

                Write("Enter your height in feet: ");
                inValue = ReadLine();
                feet = int.Parse(inValue);
                Write("Enter your height in inch: ");
                inValue = ReadLine();
                inch = int.Parse(inValue);

                height = feet * 12 + inch;

                BMI student = new BMI(weight, height);

                BMI = CalculateBMI(weight,height);
                WriteLine(student);
                WriteLine("BMI is {0:F2}", BMI); 
                
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
        public static double CalculateBMI(int weight, int height) 
        {
            double bmi;
            int height2 = height * height;
            bmi = weight;
            return  weight / (double) height2 * 703;
        }
    }
}
