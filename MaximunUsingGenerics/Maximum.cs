using System;
using System.Collections.Generic;
using System.Text;

namespace MaximunUsingGenerics
{

    public class Maximum<T> where T: IComparable
    {
        /// <IntergerMaximum>
        /// method to find maximum of three vaule
        /// </IntergerMaximum>
        /// <param name="value1"> number 1 </param>
        /// <param name="value2"> number 2 </param>
        /// <param name="value3"> number 3 </param>
        /// <returns> maximum value </returns>
        public T maximumVaule(T value1, T value2, T value3)
        {
            //CompareTo true=1,false=-1
           if(value1.CompareTo(value2)>0)
            {
                if(value1.CompareTo(value3) >0)
                {

                    return value1; 
                }
                else
                {
                    return value3;
                }
            }
            else
            {
                if (value2.CompareTo(value3) > 0)
                {

                    return value2;
                }
                else
                {
                    return value3;
                }

            }
        }
     
    }
}
