using System;

namespace MaximunUsingGenerics
{
    class MaximumMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum problem using generics!");
            //Created object for int,float and string values from Maximum class
            Maximum<int> integerMaximum = new Maximum<int>();
            Maximum<float> floatMaximum = new Maximum<float>();
            Maximum<string> stringMaximum = new Maximum<string>();

            //Generic parameterised method calling
            integerMaximum.maximumVaule(5, 2, 9);
            floatMaximum.maximumVaule(5.2F, 2.34F, 9.65F);
            stringMaximum.maximumVaule("Amit", "Omkara", "Rushi");
        }
    }
}
