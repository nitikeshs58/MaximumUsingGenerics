using System;
using System.Collections.Generic;
using System.Text;

namespace MaximunUsingGenerics
{
    public class Maximum
    {
        /// <IntergerMaximum>
        /// method to find maximum of three integer numbers
        /// </IntergerMaximum>
        /// <param name="interger1"> number 1 </param>
        /// <param name="interger2"> number 2 </param>
        /// <param name="interger3"> number 3 </param>
        /// <returns> maximum number </returns>
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

        /// <IntergerMaximum>
        /// method to find maximum of three integer numbers
        /// </IntergerMaximum>
        /// <param name="floatValue1"> number 1 </param>
        /// <param name="floatValue1"> number 2 </param>
        /// <param name="floatValue1"> number 3 </param>
        /// <returns> maximum number </returns>
        public float floatMaximum(float number1, float number2, float number3)
        {
            float max = number1;
            if (max < number2)
            {
                max = number2;
            }
            if (max < number3)
            {
                max = number3;
            }
            return max;
        }

        /// <StringMaximum>
        /// method to find maximum of three Strings
        /// </StringMaximum>
        /// <param name="stringValue1"> 1 </param>
        /// <param name="stringValue1"> 2 </param>
        /// <param name="stringValue1"> 3 </param>
        /// <returns> maximum string </returns>
        public string StringMaximum(string stringValue1, string stringValue2, string stringValue3)
        {
            int lenth1 = stringValue1.Length;
            int lenth2 = stringValue2.Length;
            int lenth3 = stringValue3.Length;
            if(lenth1>lenth2 && lenth1>lenth3)
            {
                return stringValue1;
            }
            else if(lenth2>lenth1 && lenth2>lenth3)
            {
                return stringValue2;
            }
            else
            {
                return stringValue3;
            }
        }
    }
}
