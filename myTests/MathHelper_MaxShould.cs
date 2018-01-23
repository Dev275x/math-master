using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShould
    {
        private readonly MathHelper _mathHelper;

        public MathHelper_MaxShould()
        {
            _mathHelper  = new MathHelper();
        }

        [Theory]
        [InlineData(89,89, 89)]
        [InlineData(-40789,-40789, -40789)]
        [InlineData(275,275, 275)]
        public void ReturnValueWhenValueOfOperandsSame(int value1, int value2, int expectedResult)
        {
            var actualResult = _mathHelper.Max(value1, value2);

            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [InlineData(1,2,2)]
        [InlineData(-789,-52,-52)]
        [InlineData(7000,275,7000)]
        public void ReturnMaxOfTwoDifferentValues(int value1, int value2, int expectedResult)
        {
            var actualResult = _mathHelper.Max(value1, value2);

            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        /// <summary>
        /// Test the fact that Max is commutative - returns the same 
        /// result independent of the order of the operands.
        /// </summary>
        public void ReturnSameResultIndependentOfOrder()
        {
            // Arrange
            int x = 9;
            int y = 87;

            // Act
            var result1 = _mathHelper.Max(x,y);
            var result2 = _mathHelper.Max(y,x);

            // Assert
            Assert.Equal(result1,result2);
        }

    }
}