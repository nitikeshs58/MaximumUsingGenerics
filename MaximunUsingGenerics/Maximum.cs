using System;
using System.Collections.Generic;
using System.Text;

namespace MaximunUsingGenerics
{
    public class Maximum<T> where T: IComparable
    {
        private T value1;
        private T value2;
        private T value3;
        public  T returnValue;

        /// <Maximum>
        /// Parameterised constructor
        /// called  testMaximum method
        /// </Maximum>
        /// <param name="result1"></param>
        /// <param name="result2"></param>
        /// <param name="result3"></param>
        public Maximum(T result1,T result2, T result3)
        {
            this.value1 = result1;
            this.value2 = result2;
            this.value3 = result3;
            returnValue=testMaximum();
        }

        /// <testMaximum>
        /// method to find maximum of three vaule
        /// using CompareTo method 
        /// if(value1 is greater value2)
        /// 1= condition true
        /// -1=condition false
        /// it compares with 0
        /// </testMaximum>
        /// <param name="value1"> number 1 </param>
        /// <param name="value2"> number 2 </param>
        /// <param name="value3"> number 3 </param>
        /// <returns> maximum value </returns>
        public T testMaximum()
        {
            //CompareTo true=1,false=-1
           if(value1.CompareTo(value2)>0)
            {
                if(value1.CompareTo(value3) >0)
                {
                    printMax(value1);
                    return value1; 
                }
                else
                {
                    printMax(value3);
                    return value3;
                }
            }
            else
            {
                if (value2.CompareTo(value3) > 0)
                {
                    
                    printMax(value2);
                    return value2;
                }
                else
                {
                    var v = value2.CompareTo(value3);
                    printMax(value3);
                    return value3;                    
                }
            }
        }
        public void printMax(T returnMaximumValue)
        {
            Console.WriteLine("Max Value: " + returnMaximumValue);
        }
        
    }
}
