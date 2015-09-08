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
            public void XX_FirstSecond_ReturnsFirstFirst()
            {
                Assert.AreEqual(V2(5, 5), V2(5, 6).XX());
                Assert.AreEqual(V2(7, 7), V2(7, 5).XX());
                Assert.AreEqual(V2(0, 0), V2(0, 0).XX());
            }

            [Test]
            public void YY_FirstSeconds_ReturnsSecondSecond()
            {
                Assert.AreEqual(V2(4, 4), V2(3, 4).YY());
                Assert.AreEqual(V2(2, 2), V2(7, 2).YY());
                Assert.AreEqual(V2(0, 0), V2(0, 0).YY());
            }

            private Vector2 V2(float x, float y)
            {
                return new Vector2(x, y);
            }
        }
    }
}