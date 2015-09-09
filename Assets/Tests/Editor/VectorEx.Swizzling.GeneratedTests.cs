namespace Alquimiaware
{
	using NUnit.Framework;
	using UnityEngine;
	// This code has been automatically generated. Don't edit manually
	// It will be overriden after each regeneration
	// If want to change something, do it in the generator, then regenerate
	[TestFixture]
	public abstract class VectorExSwizzleTests
	{
		public class Vector2Cases : VectorExSwizzleTests
		{
			[Test]
			public void XX_Definition()
			{
				var sut = new Vector2(23,60);
				var expected = new Vector2(60,60);
				Assert.AreEqual(expected, sut.XX());
			}
		}
	}
}
