using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    class Fraction
    {
        private int numberator;
        private int denominator;

        public Fraction() 
        {
        }

        public Fraction(int num, int deno) 
        {
            numberator = num;
            denominator = deno;
        }


        public int Numberator
        {
            get 
            {
                return numberator;
            }
            set
            {
                numberator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }

        public override string ToString()
        {
            return"\nThe numberator is " + numberator + ". \nThe denominator is " + denominator + ".";
        }
    }
}
