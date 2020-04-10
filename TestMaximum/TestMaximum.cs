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

        /// <IntegerTest>
        /// taken 3 integer values
        /// maxNumber as object of Maximum class
        /// parameterised IntergerMaximum method is called
        /// Compared returnMaximum value to expected vaule
        /// </IntegerTest>
        [Test]
        public void IntegerTest()
        {
            Maximum<int> maxNumber = new Maximum<int>(5, 2, 9);
            Assert.Pass("9", maxNumber.returnValue);
        }

        /// <FloatTest>
        /// taken 3 float values
        /// maxNumber as object of Maximum class
        /// parameterised floatMaximum method is called
        /// Compared returnMaximum value to expected vaule
        /// </FloatTest>
        [Test]
        public void FloatTest()
        {
            Maximum<float> maxNumber = new Maximum<float>(5.2F, 9.65F, 2.34F);
            Assert.Pass("9.65F", maxNumber.returnValue);
        }

        /// <StringTest>
        /// taken 3 string values
        /// maxNumber as object of Maximum class
        /// parameterised floatMaximum method is called
        /// Compared returnMaximum value to expected vaule
        /// </StringTest>
        [Test]
        public void StringTest()
        {
            Maximum<string> maxNumber = new Maximum<string>("Amit", "Smkara", "Rushi");
            Assert.Pass("Smkara", maxNumber.returnValue);
        }
    }
}