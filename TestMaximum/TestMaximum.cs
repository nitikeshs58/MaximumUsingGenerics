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
            Maximum<int> maxNumber = new Maximum<int>();
            int returnMaximum=maxNumber.maximumVaule(interger1, interger2, interger3);
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
            Maximum<float> maxNumber = new Maximum<float>();
            float returnMaximum = maxNumber.maximumVaule(floatValue1, floatValue2, floatValue3);
            Assert.Pass("9.65F", returnMaximum);
        }

        /// <FloatTest>
        /// taken 3 float values
        /// maxNumber as object of Maximum class
        /// parameterised floatMaximum method is called
        /// Compared returnMaximum value to expected vaule
        /// </FloatTest>
        [Test]
        public void StringTest()
        {
            string stringValue1 = "Amit",
                stringValue2 = "Omkara",
                stringValue3 = "Rushi";
            Maximum<string> maxNumber = new Maximum<string>();
            string returnMaximum = maxNumber.maximumVaule(stringValue1, stringValue2, stringValue3);
            Assert.Pass("Omkara", returnMaximum);
        }
    }
}