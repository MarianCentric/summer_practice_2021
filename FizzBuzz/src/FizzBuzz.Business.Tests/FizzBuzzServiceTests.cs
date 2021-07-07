using Xunit;

namespace FizzBuzz.Business.Tests
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void When_InputIsDivisibleBy3_Expect_ResponseShouldStartWithFizz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(6);

            Assert.StartsWith("FIZZ", result);
        }
        
        [Fact]
        public void When_InputIsDivisibleBy5_Expect_ResponseShouldEndWithBuzz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(10);

            Assert.EndsWith("BUZZ", result);
        }
        
        [Fact]
        public void When_InputIsDivisibleBy3_And_InputIsDivisibleBy5_Expect_ResponseShouldBeFizzBuzz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(15);

            Assert.Equal("FIZZBUZZ", result);
        }
        
        [Fact]
        public void When_InputIsNotDivisibleBy3_And_InputIsNotDivisibleBy5_Expect_ResponseShouldBeTheInput()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(13);

            Assert.Equal("13", result);
        }
    }
}
