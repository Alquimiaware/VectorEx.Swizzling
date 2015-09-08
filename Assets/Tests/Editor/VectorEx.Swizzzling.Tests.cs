namespace Alquimiaware
{
    using NUnit.Framework;
    using UnityEngine;

    [TestFixture]
    public abstract class VectorExSwizzlingTests
    {
        public class Vector2Cases : VectorExSwizzlingTests
        {
            [Test]
            public void XX_GivenAB_ReturnsAA()
            {
                Assert.AreEqual(V2(5, 5), V2(5, 6).XX());
                Assert.AreEqual(V2(7, 7), V2(7, 5).XX());
                Assert.AreEqual(V2(0, 0), V2(0, 0).XX());
            }

            [Test]
            public void YY_GivenAB_ReturnsBB()
            {
                Assert.AreEqual(V2(4, 4), V2(3, 4).YY());
                Assert.AreEqual(V2(2, 2), V2(7, 2).YY());
                Assert.AreEqual(V2(0, 0), V2(0, 0).YY());
            }

            [Test]
            public void YX_GivenAB_ReturnsBA()
            {
                Assert.AreEqual(V2(3, 7), V2(7, 3).YX());
                Assert.AreEqual(V2(9, 3), V2(3, 9).YX());
                Assert.AreEqual(V2(1, 7), V2(1, 7).YX().YX());
            }

            private Vector2 V2(float x, float y)
            {
                return new Vector2(x, y);
            }
        }
    }
}