using NUnit.Framework;
using MaximunUsingGenerics;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int interger1 = 5,
                interger2 = 2,
                interger3 = 9;
            Maximum maxNumber = new Maximum();
            int returnMaximum=maxNumber.IntergerMaximum(interger1, interger2, interger3);
            Assert.Pass("9", returnMaximum);
        }
    }
}