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
            int interger1 = 5,
                interger2 = 2,
                interger3 = 9;
            Maximum maxNumber = new Maximum();
            int returnMaximum=maxNumber.IntergerMaximum(interger1, interger2, interger3);
            Assert.Pass("9", returnMaximum);
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
            float floatValue1 = 5.2F,
                floatValue2 = 2.34F,
                floatValue3 = 9.65F;
            Maximum maxNumber = new Maximum();
            float returnMaximum = maxNumber.floatMaximum(floatValue1, floatValue2, floatValue3);
            Assert.Pass("9.65F", returnMaximum);
        }
    }
}