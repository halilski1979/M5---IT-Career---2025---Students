using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2_RationalNumbers2
{
    internal class RationalNumbers
    {
        private int numerator;
        private int denumerator;

        public RationalNumbers(int numerator, int denumerator)
        {
            this.Numerator = numerator;
            this.Denumerator = denumerator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denumerator
        {
            get { return denumerator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Error. Denumerator is 0!");
                }
                denumerator = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denumerator}";
        }

        public void Print()
        {
            Console.WriteLine($"{this.Numerator}/{this.Denumerator}");
        }

        public string Pechat()
        {
            return $"{this.Numerator}/{this.Denumerator}";
        }
    }
}
