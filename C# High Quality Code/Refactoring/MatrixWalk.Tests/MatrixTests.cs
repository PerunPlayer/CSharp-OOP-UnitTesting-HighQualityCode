using System;
using NUnit.Framework;

namespace MatrixWalk.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Throw_WhenZeroSizeIsPassed()
        {
            var matrixGenerator = new MatrixGenerator(0);

            Assert.Throws<ArgumentOutOfRangeException>(() => new MatrixGenerator(0));
        }
    }
}
