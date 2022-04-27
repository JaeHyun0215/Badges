using System;
using Xunit;

namespace BadgeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            new Badges.Form1();
            Assert.True(true);
        }
    }
}
