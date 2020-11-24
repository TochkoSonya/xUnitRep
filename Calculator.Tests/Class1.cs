using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void SumOfTwoPositiveValuesTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 10;
            double secondValue = 23;
            double expectedResult = 33;
           // double actualResult = 0;

          //  actualResult = calculator.SumOfTwoValues(firstValue, secondValue);

            Assert.AreEqual(expectedResult, calculator.SumOfTwoValues(firstValue, secondValue));
        }

        [Test]
        public void DifferenceOfTwoNegativValuesTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = -10;
            double secondValue = -23;
            double expectedResult = 13;
            double actualResult = 0;

            actualResult = calculator.DifferenceOfTwoValues(firstValue, secondValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DivisionOfTwoPositiveValuesTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 10;
            double secondValue = 23;
            double expectedResult = 0.4348;
            double actualResult = 0;

            actualResult = calculator.DivisionOfTwoValues(firstValue, secondValue);

            Assert.AreEqual(expectedResult, Math.Round(actualResult, 4));
        }

        [Test]
        public void DivisionOfTwoNegativValuesTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = -10;
            double secondValue = -23;
            double expectedResult = 0.4348;
            double actualResult = 0;

            actualResult = calculator.DivisionOfTwoValues(firstValue, secondValue);

            Assert.AreEqual(expectedResult, Math.Round(actualResult, 4));
        }


        [Test]
        public void MultiplyTwoValuesTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 10;
            double secondValue = 23;
            double expectedResult = 230;
            double actualResult = 0;

            actualResult = calculator.MultiplyTwoValues(firstValue, secondValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        // [ExpectedException(typeof(DivideByZeroException))]
        public void DevideByZeroTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 3;
            double secondValue = 0;

            var ex = Assert.Throws<DivideByZeroException>(() => calculator.DivisionOfTwoValues(firstValue, secondValue));
            Assert.AreEqual("Делить на ноль запрещено", ex.Message);
        }

        [Test]
        public void ReversValueWhereSecondValueIsNullTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 0;

            var ex = Assert.Throws<DivideByZeroException>(() => calculator.ReverseValue(firstValue));
            Assert.AreEqual("Делить на ноль запрещено", ex.Message);
        }

        [Test]
        public void SquaringOfNegativeValueTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = -3;
            double expectedResult = 9;
            double actualResult = 0;

            actualResult = calculator.ValueInSecondPower(firstValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SinOfPositiveValueTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = 80;
            double expectedResult = -0.9939;
            double actualResult = 0;

            actualResult = calculator.SinOfValue(firstValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SinOfNegativeValueTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = -80;
            double expectedResult = 0.9939;
            double actualResult = 0;

            actualResult = calculator.SinOfValue(firstValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TanOfNegativValueTest()
        {
            MainCalculator calculator = new MainCalculator();
            double firstValue = -80;
            double expectedResult = -9.0037;
            double actualResult = 0;

            actualResult = calculator.TanOfValue(firstValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
