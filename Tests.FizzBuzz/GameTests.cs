using FizzBuzz.GameEngine;
using Xunit;

namespace Tests.FizzBuzz
{
    public class GameTests
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("Buzz", 10)]
        [InlineData("FizzBuzz", 15)]
        public void OfIterationIs(string outcome, int input)
        {
            Assert.Equal(outcome, new FizzBuzzGame().Of(input));
        }

        #region A lot more typing is required to test this way.  Suggest identify a theory.

        [Fact]
        public void OfZeroisZero()
        {
            Assert.Equal("0", new FizzBuzzGame().Of(0));
        }

        [Fact]
        public void OfOneisOne()
        {
            Assert.Equal("1", new FizzBuzzGame().Of(1));
        }

        [Fact]
        public void OfThreeisFizz()
        {
            Assert.Equal("Fizz", new FizzBuzzGame().Of(3));
        }

        [Fact]
        public void OfFiveisBuzz()
        {
            Assert.Equal("Buzz", new FizzBuzzGame().Of(5));
        }

        [Fact]
        public void OfSixisFizz()
        {
            Assert.Equal("Fizz", new FizzBuzzGame().Of(6));
        }

        [Fact]
        public void OfTenisBuzz()
        {
            Assert.Equal("Buzz", new FizzBuzzGame().Of(10));
        }

        #endregion A lot more typing is required to test this way.  Suggest identify a theory.
    }
}
