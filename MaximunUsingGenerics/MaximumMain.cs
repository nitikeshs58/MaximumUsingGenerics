using System;

namespace MaximunUsingGenerics
{
    class MaximumMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum problem using generics!");
            Maximum<int> integerMaxNumber = new Maximum<int>(5, 2, 9);
            Maximum<float> floatMaxNumber = new Maximum<float>(5.2F, 2.34F, 9.65F);
            // string compares with ASCII value
            Maximum<string> stringMax = new Maximum<string>("Amit", "Smkara", "Rushi");
        }
    }
}
