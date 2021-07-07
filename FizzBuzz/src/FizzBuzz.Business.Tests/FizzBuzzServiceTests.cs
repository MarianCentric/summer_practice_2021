using System.Linq;
using Xunit;

namespace FizzBuzz.Business.Tests
{
    public class FizzBuzzServiceTests
    {
        #region Calculate Tests

        [Fact]
        public void When_CalculateISCalled_And_InputIsDivisibleBy3_Expect_ResponseShouldStartWithFizz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(6);

            Assert.StartsWith("FIZZ", result);
        }

        [Fact]
        public void When_CalculateISCalled_And_InputIsDivisibleBy5_Expect_ResponseShouldEndWithBuzz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(10);

            Assert.EndsWith("BUZZ", result);
        }

        [Fact]
        public void When_CalculateISCalled_And_InputIsDivisibleBy3_And_InputIsDivisibleBy5_Expect_ResponseShouldBeFizzBuzz()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(15);

            Assert.Equal("FIZZBUZZ", result);
        }

        [Fact]
        public void When_CalculateISCalled_And_InputIsNotDivisibleBy3_And_InputIsNotDivisibleBy5_Expect_ResponseShouldBeTheInput()
        {
            var sut = new FizzBuzzService();

            var result = sut.Calculate(13);

            Assert.Equal("13", result);
        }

        #endregion

        #region GetFizBuzzArray tests

        /// <summary>
        /// result should be 1 based index array
        /// </summary>
        [Fact]
        public void When_GetFizBuzzArrayIsCalled_Expect_OutputLengthToBeEqualsToInputValuePlusOne()
        {
            var sut = new FizzBuzzService();

            var result = sut.GetFizBuzzArray(5);

            Assert.Equal(6, result.Count());
        }

        [Fact]
        public void When_GetFizBuzzArrayIsCalled_Given_ItemsCountEqualsToZero_Expect_OutputToBeEmpty()
        {
            var sut = new FizzBuzzService();

            var result = sut.GetFizBuzzArray(0);

            Assert.Empty(result);
        }

        [Fact]
        public void When_GetFizBuzzArrayIsCalled_Expect_OutputFirstValueToBe1()
        {
            var sut = new FizzBuzzService();

            var result = sut.GetFizBuzzArray(5);

            Assert.Equal("1", result[1]);
        }
        
        #endregion

        #region Prevent false positive results

        //[Fact]
        //public void When_GetFizBuzzArrayIsCalled_Expect_Output3rdValueToBeFizz()
        //{
        //    var sut = new FizzBuzzService();

        //    var result = sut.GetFizBuzzArray(5);

        //    Assert.Equal("FIZZ", result[3]);
        //}

        //[Fact]
        //public void When_GetFizBuzzArrayIsCalled_Expect_Output5thValueToBeBuzz()
        //{
        //    var sut = new FizzBuzzService();

        //    var result = sut.GetFizBuzzArray(5);

        //    Assert.Equal("BUZZ", result[5]);
        //}

        //[Fact]
        //public void When_GetFizBuzzArrayIsCalled_Expect_Output15thValueToBeFizzBuzz()
        //{
        //    var sut = new FizzBuzzService();

        //    var result = sut.GetFizBuzzArray(15);

        //    Assert.Equal("FIZZBUZZ", result[15]);
        //}

        #endregion
    }
}
