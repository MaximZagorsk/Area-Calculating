using System;
using Area_Calculating.Class;
using Area_Calculating.Exceptions;
using NUnit.Framework;

namespace Area_Calculating.Tests
{
    [TestFixture]
    class Test
    {
        [Test]
        public void NegativeExceptionTestingTriangle()
        {
            Assert.Throws<NegativeVariableException>(() => new Triangle(-1, 3, 2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, -3, 2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, -2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2,-20, 60, 100));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2, 20, -60, 100));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2, 20, 60, -100));
        }

        [Test]
        public void TestCornersSumException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 3, 2, 100, 100, 100));
        }
    }
}
