using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_3
{
    class BMI
    {
        private int weight;
        private int height;

        public BMI() 
        {
        }

        public BMI(int w, int h) 
        {
            weight = w;
            height = h;
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public override string ToString()
        {
            return "Weight is " + weight + " lbs and  Height is " + height + " inches";
        }
    }
}
