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
        [Fact]
        public void Return0GivenValuesOf0()
        {
            var result = _mathHelper.Max(0,0);
            Assert.Equal(0,result);
        }
    }
}