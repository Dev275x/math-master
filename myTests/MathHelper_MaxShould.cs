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
        [InlineDataAttribute(89,89, 89)]
        [InlineDataAttribute(-40789,-40789, -40789)]
        [InlineDataAttribute(275,275, 275)]
        public void ReturnValueWhenValueOfOperandsSame(int value1, int value2, int expectedResult)
        {
            var actualResult = _mathHelper.Max(value1, value2);

            Assert.Equal(actualResult, expectedResult);
        }
    }
}