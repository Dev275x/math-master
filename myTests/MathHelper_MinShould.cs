using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MinShould
    {
        private readonly MathHelper _mathHelper;

        public MathHelper_MinShould()
        {
            _mathHelper  = new MathHelper();
        }

        [Theory]
        [InlineData(89,89, 89)]
        [InlineData(-40789,-40789, -40789)]
        [InlineData(275,275, 275)]
        public void ReturnValueWhenValueOfOperandsSame(int value1, int value2, int expectedResult)
        {
            var actualResult = _mathHelper.Min(value1, value2);

            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [InlineData(1,2,1)]
        [InlineData(-789,-52,-789)]
        [InlineData(7000,275,275)]
        public void ReturnMinOfTwoDifferentValues(int value1, int value2, int expectedResult)
        {
            var actualResult = _mathHelper.Min(value1, value2);

            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        /// <summary>
        /// Test the fact that Min is commutative - returns the same 
        /// result independent of the order of the operands.
        /// </summary>
        public void ReturnSameResultIndependentOfOrder()
        {
            // Arrange
            int x = 9;
            int y = 87;

            // Act
            var result1 = _mathHelper.Min(x,y);
            var result2 = _mathHelper.Min(y,x);

            // Assert
            Assert.Equal(result1,result2);
        }

    }
}