using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //method return FizzBuzz
        [Test]
        public void GetOutput_DivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }


        //Method return Fizz
        [Test]
        public void GetOutput_DivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        //Method return Buzz
        [Test]
        public void GetOutput_DivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        //Method return error.
        [Test]
        public void GetOutput_DivisibleBy2_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(2);
            Assert.That(result, Is.EqualTo("2"));
        }

    }
}
