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

            private Vector2 V2(float x, float y)
            {
                return new Vector2(x, y);
            }
        }
    }
}