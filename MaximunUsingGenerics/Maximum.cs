using System;
using System.Collections.Generic;
using System.Text;

namespace MaximunUsingGenerics
{
    public class Maximum
    {
        int number1, number2, number3;

        public Maximum(){}

        public Maximum(int number1,int number2, int number3)
        {
            this.number1 = number1;
            this.number1 = number2;
            this.number3 = number3;
        }

        public int IntergerMaximum(int number1,int number2,int number3)
        {
            int max = number1;
            if(max<number2)
            {
                max = number2;
            }
            if(max<number3)
            {
                max = number3;
            }
            return max;
        }
    }
}
