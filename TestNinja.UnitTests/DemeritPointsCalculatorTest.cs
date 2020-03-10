using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTest
    {

        [Test]
        public void CalculateDemeritPoints_ValueOutRange_ReturnError()
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_InputLessOfMaxLimit_ReturnZero()
        {
            var calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(65);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_InputMoreOfMaxLimit_ReturnSeven()
        {
            var calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(100);
            Assert.That(result, Is.EqualTo(7));
        }
    }
}
