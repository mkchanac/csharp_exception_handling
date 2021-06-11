using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Restrict the user to enter 3 exam scores
            int[] examScores;
            int totalScore = 0;
            int count = 0;
            string inValue;
            double average;

            try
            {
                Write("How many exam scores you want to enter?");
                inValue = ReadLine();
                count = int.Parse(inValue);
                examScores = new int[count];

                for (int i = 0; i < examScores.Length; i++)
                {
                    Write("Enter scores <0-100, integer>:");
                    inValue = ReadLine();
                    examScores[i] = int.Parse(inValue);
                    totalScore += examScores[i];
                }

                average = totalScore / count;

                DisplayGrading(average);
            }

            catch (FormatException e)
            {
                WriteLine(e.Message);
            }

            catch (DivideByZeroException e) 
            {
                WriteLine(e.Message);
            }

            catch (IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
            }

            ReadKey();


        }

        static void DisplayGrading(double average)
        {
            if (average >= 90)
            {
                WriteLine("Grade: A");
            }
            else
                if (average >= 80)
            {
                WriteLine("Grade: B");

            }
            else
                if (average >= 70)
            {
                WriteLine("Grade: C");

            }
            else
                if (average >= 60)
            {
                WriteLine("Grade: D");

            }
            else
            {
                WriteLine("Grade: F");
            }
        }
    }
}
