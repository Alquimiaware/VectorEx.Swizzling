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
            public void XX_GivenAxB_ReturnsAxA()
            {
                Assert.AreEqual(V2(5, 5), V2(5, 6).XX());
                Assert.AreEqual(V2(7, 7), V2(7, 5).XX());
                Assert.AreEqual(V2(0, 0), V2(0, 0).XX());
            }

            [Test]
            public void YY_GivenAxB_ReturnsBxB()
            {
                Assert.AreEqual(V2(4, 4), V2(3, 4).YY());
                Assert.AreEqual(V2(2, 2), V2(7, 2).YY());
                Assert.AreEqual(V2(0, 0), V2(0, 0).YY());
            }

            [Test]
            public void YX_GivenAxB_ReturnsBxA()
            {
                Assert.AreEqual(V2(3, 7), V2(7, 3).YX());
                Assert.AreEqual(V2(9, 3), V2(3, 9).YX());
            }

            [Test]
            public void YX_AppliedTwice_ReturnsInitialValue()
            {
                var anyV2 = V2(1, 2);
                Assert.AreEqual(anyV2, anyV2.YX().YX());
            }

            [Test]
            public void XO_GivenAxB_ReturnsAxO()
            {
                Assert.AreEqual(V2(2, 0), V2(2, 7).XO());
                Assert.AreEqual(V2(9, 0), V2(9, 20).XO());
            }

            [Test]
            public void XO_ByDefinition_IsIdempotent()
            {
                var anyInit = V2(88, 53);
                var appliedOnce = anyInit.XO();
                var appliedTwice = anyInit.XO().XO();
                Assert.AreEqual(appliedOnce, appliedTwice);
            }

            [Test]
            public void OX_GivenAxB_ReturnsOxB()
            {
                Assert.AreEqual(V2(0, 4), V2(4, 7).OX());
                Assert.AreEqual(V2(0, 11), V2(11, 33).OX());
            }

            [Test]
            public void OX_ByDefinition_IsNilpotent()
            {
                float anyA = 37, anyB = 103;
                Assert.AreEqual(Vector2.zero, V2(anyA, anyB).OX().OX());
            }

            [Test]
            public void YO_GivenAxB_ReturnsBx0()
            {
                Assert.AreEqual(V2(1, 0), V2(3, 1).YO());
                Assert.AreEqual(V2(3, 0), V2(12, 3).YO());
            }

            [Test]
            public void YO_ByDefinition_IsNilpotent()
            {
                var anyInit = V2(177, 533);

                Assert.AreEqual(Vector2.zero, anyInit.YO().YO());
            }

            [Test]
            public void OY_GivenAxB_Return0xB()
            {
                Assert.AreEqual(V2(0, 11), V2(31, 11).OY());
                Assert.AreEqual(V2(0, 61), V2(27, 61).OY());
            }

            [Test]
            public void OY_ByDefinition_IsIdempotent()
            {
                var anyInit = V2(1111, 3212);
                var appliedOnce = anyInit.OY();
                var appliedTwice = anyInit.OY().OY();
                Assert.AreEqual(appliedOnce, appliedTwice);
            }

            private Vector2 V2(float x, float y)
            {
                return new Vector2(x, y);
            }
        }
    }
}