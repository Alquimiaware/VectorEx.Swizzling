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
				var value = new Vector2(6,43);
				var expected = new Vector2(6,6);
				Assert.AreEqual(expected, value.XX());
			}
			[Test]
			public void XXX_Definition()
			{
				var value = new Vector2(28,40);
				var expected = new Vector3(28,28,28);
				Assert.AreEqual(expected, value.XXX());
			}
			[Test]
			public void XXXX_Definition()
			{
				var value = new Vector2(17,55);
				var expected = new Vector4(17,17,17,17);
				Assert.AreEqual(expected, value.XXXX());
			}
			[Test]
			public void XXXY_Definition()
			{
				var value = new Vector2(12,44);
				var expected = new Vector4(12,12,12,44);
				Assert.AreEqual(expected, value.XXXY());
			}
			[Test]
			public void XXY_Definition()
			{
				var value = new Vector2(23,37);
				var expected = new Vector3(23,23,37);
				Assert.AreEqual(expected, value.XXY());
			}
			[Test]
			public void XXYX_Definition()
			{
				var value = new Vector2(17,41);
				var expected = new Vector4(17,17,41,17);
				Assert.AreEqual(expected, value.XXYX());
			}
			[Test]
			public void XXYY_Definition()
			{
				var value = new Vector2(11,31);
				var expected = new Vector4(11,11,31,31);
				Assert.AreEqual(expected, value.XXYY());
			}
			[Test]
			public void XY_Definition()
			{
				var value = new Vector2(13,36);
				var expected = new Vector2(13,36);
				Assert.AreEqual(expected, value.XY());
			}
			[Test]
			public void XYX_Definition()
			{
				var value = new Vector2(1,38);
				var expected = new Vector3(1,38,1);
				Assert.AreEqual(expected, value.XYX());
			}
			[Test]
			public void XYXX_Definition()
			{
				var value = new Vector2(2,31);
				var expected = new Vector4(2,31,2,2);
				Assert.AreEqual(expected, value.XYXX());
			}
			[Test]
			public void XYXY_Definition()
			{
				var value = new Vector2(6,54);
				var expected = new Vector4(6,54,6,54);
				Assert.AreEqual(expected, value.XYXY());
			}
			[Test]
			public void XYY_Definition()
			{
				var value = new Vector2(16,41);
				var expected = new Vector3(16,41,41);
				Assert.AreEqual(expected, value.XYY());
			}
			[Test]
			public void XYYX_Definition()
			{
				var value = new Vector2(25,53);
				var expected = new Vector4(25,53,53,25);
				Assert.AreEqual(expected, value.XYYX());
			}
			[Test]
			public void XYYY_Definition()
			{
				var value = new Vector2(21,50);
				var expected = new Vector4(21,50,50,50);
				Assert.AreEqual(expected, value.XYYY());
			}
			[Test]
			public void YX_Definition()
			{
				var value = new Vector2(15,44);
				var expected = new Vector2(44,15);
				Assert.AreEqual(expected, value.YX());
			}
			[Test]
			public void YXX_Definition()
			{
				var value = new Vector2(18,55);
				var expected = new Vector3(55,18,18);
				Assert.AreEqual(expected, value.YXX());
			}
			[Test]
			public void YXXX_Definition()
			{
				var value = new Vector2(8,47);
				var expected = new Vector4(47,8,8,8);
				Assert.AreEqual(expected, value.YXXX());
			}
			[Test]
			public void YXXY_Definition()
			{
				var value = new Vector2(12,31);
				var expected = new Vector4(31,12,12,31);
				Assert.AreEqual(expected, value.YXXY());
			}
			[Test]
			public void YXY_Definition()
			{
				var value = new Vector2(15,37);
				var expected = new Vector3(37,15,37);
				Assert.AreEqual(expected, value.YXY());
			}
			[Test]
			public void YXYX_Definition()
			{
				var value = new Vector2(13,44);
				var expected = new Vector4(44,13,44,13);
				Assert.AreEqual(expected, value.YXYX());
			}
			[Test]
			public void YXYY_Definition()
			{
				var value = new Vector2(7,38);
				var expected = new Vector4(38,7,38,38);
				Assert.AreEqual(expected, value.YXYY());
			}
			[Test]
			public void YY_Definition()
			{
				var value = new Vector2(8,39);
				var expected = new Vector2(39,39);
				Assert.AreEqual(expected, value.YY());
			}
			[Test]
			public void YYX_Definition()
			{
				var value = new Vector2(17,51);
				var expected = new Vector3(51,51,17);
				Assert.AreEqual(expected, value.YYX());
			}
			[Test]
			public void YYXX_Definition()
			{
				var value = new Vector2(3,54);
				var expected = new Vector4(54,54,3,3);
				Assert.AreEqual(expected, value.YYXX());
			}
			[Test]
			public void YYXY_Definition()
			{
				var value = new Vector2(20,55);
				var expected = new Vector4(55,55,20,55);
				Assert.AreEqual(expected, value.YYXY());
			}
			[Test]
			public void YYY_Definition()
			{
				var value = new Vector2(16,34);
				var expected = new Vector3(34,34,34);
				Assert.AreEqual(expected, value.YYY());
			}
			[Test]
			public void YYYX_Definition()
			{
				var value = new Vector2(21,45);
				var expected = new Vector4(45,45,45,21);
				Assert.AreEqual(expected, value.YYYX());
			}
			[Test]
			public void YYYY_Definition()
			{
				var value = new Vector2(7,33);
				var expected = new Vector4(33,33,33,33);
				Assert.AreEqual(expected, value.YYYY());
			}
		}
		
		public class Vector3Cases : VectorExSwizzleTests
		{
			[Test]
			public void XX_Definition()
			{
				var value = new Vector3(6,36,69);
				var expected = new Vector2(6,6);
				Assert.AreEqual(expected, value.XX());
			}
			[Test]
			public void XXX_Definition()
			{
				var value = new Vector3(19,50,81);
				var expected = new Vector3(19,19,19);
				Assert.AreEqual(expected, value.XXX());
			}
			[Test]
			public void XXXX_Definition()
			{
				var value = new Vector3(12,32,77);
				var expected = new Vector4(12,12,12,12);
				Assert.AreEqual(expected, value.XXXX());
			}
			[Test]
			public void XXXY_Definition()
			{
				var value = new Vector3(8,33,79);
				var expected = new Vector4(8,8,8,33);
				Assert.AreEqual(expected, value.XXXY());
			}
			[Test]
			public void XXXZ_Definition()
			{
				var value = new Vector3(17,33,76);
				var expected = new Vector4(17,17,17,76);
				Assert.AreEqual(expected, value.XXXZ());
			}
			[Test]
			public void XXY_Definition()
			{
				var value = new Vector3(1,36,88);
				var expected = new Vector3(1,1,36);
				Assert.AreEqual(expected, value.XXY());
			}
			[Test]
			public void XXYX_Definition()
			{
				var value = new Vector3(1,34,70);
				var expected = new Vector4(1,1,34,1);
				Assert.AreEqual(expected, value.XXYX());
			}
			[Test]
			public void XXYY_Definition()
			{
				var value = new Vector3(22,44,83);
				var expected = new Vector4(22,22,44,44);
				Assert.AreEqual(expected, value.XXYY());
			}
			[Test]
			public void XXYZ_Definition()
			{
				var value = new Vector3(28,32,61);
				var expected = new Vector4(28,28,32,61);
				Assert.AreEqual(expected, value.XXYZ());
			}
			[Test]
			public void XXZ_Definition()
			{
				var value = new Vector3(9,43,70);
				var expected = new Vector3(9,9,70);
				Assert.AreEqual(expected, value.XXZ());
			}
			[Test]
			public void XXZX_Definition()
			{
				var value = new Vector3(27,55,60);
				var expected = new Vector4(27,27,60,27);
				Assert.AreEqual(expected, value.XXZX());
			}
			[Test]
			public void XXZY_Definition()
			{
				var value = new Vector3(16,36,60);
				var expected = new Vector4(16,16,60,36);
				Assert.AreEqual(expected, value.XXZY());
			}
			[Test]
			public void XXZZ_Definition()
			{
				var value = new Vector3(9,38,69);
				var expected = new Vector4(9,9,69,69);
				Assert.AreEqual(expected, value.XXZZ());
			}
			[Test]
			public void XY_Definition()
			{
				var value = new Vector3(11,55,81);
				var expected = new Vector2(11,55);
				Assert.AreEqual(expected, value.XY());
			}
			[Test]
			public void XYX_Definition()
			{
				var value = new Vector3(10,44,65);
				var expected = new Vector3(10,44,10);
				Assert.AreEqual(expected, value.XYX());
			}
			[Test]
			public void XYXX_Definition()
			{
				var value = new Vector3(17,40,62);
				var expected = new Vector4(17,40,17,17);
				Assert.AreEqual(expected, value.XYXX());
			}
			[Test]
			public void XYXY_Definition()
			{
				var value = new Vector3(12,57,86);
				var expected = new Vector4(12,57,12,57);
				Assert.AreEqual(expected, value.XYXY());
			}
			[Test]
			public void XYXZ_Definition()
			{
				var value = new Vector3(18,56,65);
				var expected = new Vector4(18,56,18,65);
				Assert.AreEqual(expected, value.XYXZ());
			}
			[Test]
			public void XYY_Definition()
			{
				var value = new Vector3(17,34,74);
				var expected = new Vector3(17,34,34);
				Assert.AreEqual(expected, value.XYY());
			}
			[Test]
			public void XYYX_Definition()
			{
				var value = new Vector3(14,33,82);
				var expected = new Vector4(14,33,33,14);
				Assert.AreEqual(expected, value.XYYX());
			}
			[Test]
			public void XYYY_Definition()
			{
				var value = new Vector3(19,52,68);
				var expected = new Vector4(19,52,52,52);
				Assert.AreEqual(expected, value.XYYY());
			}
			[Test]
			public void XYYZ_Definition()
			{
				var value = new Vector3(6,46,85);
				var expected = new Vector4(6,46,46,85);
				Assert.AreEqual(expected, value.XYYZ());
			}
			[Test]
			public void XYZ_Definition()
			{
				var value = new Vector3(27,30,85);
				var expected = new Vector3(27,30,85);
				Assert.AreEqual(expected, value.XYZ());
			}
			[Test]
			public void XYZX_Definition()
			{
				var value = new Vector3(13,58,72);
				var expected = new Vector4(13,58,72,13);
				Assert.AreEqual(expected, value.XYZX());
			}
			[Test]
			public void XYZY_Definition()
			{
				var value = new Vector3(20,38,88);
				var expected = new Vector4(20,38,88,38);
				Assert.AreEqual(expected, value.XYZY());
			}
			[Test]
			public void XYZZ_Definition()
			{
				var value = new Vector3(27,43,67);
				var expected = new Vector4(27,43,67,67);
				Assert.AreEqual(expected, value.XYZZ());
			}
			[Test]
			public void XZ_Definition()
			{
				var value = new Vector3(11,56,85);
				var expected = new Vector2(11,85);
				Assert.AreEqual(expected, value.XZ());
			}
			[Test]
			public void XZX_Definition()
			{
				var value = new Vector3(3,36,69);
				var expected = new Vector3(3,69,3);
				Assert.AreEqual(expected, value.XZX());
			}
			[Test]
			public void XZXX_Definition()
			{
				var value = new Vector3(21,39,75);
				var expected = new Vector4(21,75,21,21);
				Assert.AreEqual(expected, value.XZXX());
			}
			[Test]
			public void XZXY_Definition()
			{
				var value = new Vector3(27,57,82);
				var expected = new Vector4(27,82,27,57);
				Assert.AreEqual(expected, value.XZXY());
			}
			[Test]
			public void XZXZ_Definition()
			{
				var value = new Vector3(13,44,73);
				var expected = new Vector4(13,73,13,73);
				Assert.AreEqual(expected, value.XZXZ());
			}
			[Test]
			public void XZY_Definition()
			{
				var value = new Vector3(1,38,76);
				var expected = new Vector3(1,76,38);
				Assert.AreEqual(expected, value.XZY());
			}
			[Test]
			public void XZYX_Definition()
			{
				var value = new Vector3(19,41,72);
				var expected = new Vector4(19,72,41,19);
				Assert.AreEqual(expected, value.XZYX());
			}
			[Test]
			public void XZYY_Definition()
			{
				var value = new Vector3(11,34,87);
				var expected = new Vector4(11,87,34,34);
				Assert.AreEqual(expected, value.XZYY());
			}
			[Test]
			public void XZYZ_Definition()
			{
				var value = new Vector3(2,48,75);
				var expected = new Vector4(2,75,48,75);
				Assert.AreEqual(expected, value.XZYZ());
			}
			[Test]
			public void XZZ_Definition()
			{
				var value = new Vector3(7,54,78);
				var expected = new Vector3(7,78,78);
				Assert.AreEqual(expected, value.XZZ());
			}
			[Test]
			public void XZZX_Definition()
			{
				var value = new Vector3(3,53,72);
				var expected = new Vector4(3,72,72,3);
				Assert.AreEqual(expected, value.XZZX());
			}
			[Test]
			public void XZZY_Definition()
			{
				var value = new Vector3(16,53,75);
				var expected = new Vector4(16,75,75,53);
				Assert.AreEqual(expected, value.XZZY());
			}
			[Test]
			public void XZZZ_Definition()
			{
				var value = new Vector3(15,48,66);
				var expected = new Vector4(15,66,66,66);
				Assert.AreEqual(expected, value.XZZZ());
			}
			[Test]
			public void YX_Definition()
			{
				var value = new Vector3(23,52,71);
				var expected = new Vector2(52,23);
				Assert.AreEqual(expected, value.YX());
			}
			[Test]
			public void YXX_Definition()
			{
				var value = new Vector3(28,53,74);
				var expected = new Vector3(53,28,28);
				Assert.AreEqual(expected, value.YXX());
			}
			[Test]
			public void YXXX_Definition()
			{
				var value = new Vector3(25,40,74);
				var expected = new Vector4(40,25,25,25);
				Assert.AreEqual(expected, value.YXXX());
			}
			[Test]
			public void YXXY_Definition()
			{
				var value = new Vector3(7,31,85);
				var expected = new Vector4(31,7,7,31);
				Assert.AreEqual(expected, value.YXXY());
			}
			[Test]
			public void YXXZ_Definition()
			{
				var value = new Vector3(24,38,87);
				var expected = new Vector4(38,24,24,87);
				Assert.AreEqual(expected, value.YXXZ());
			}
			[Test]
			public void YXY_Definition()
			{
				var value = new Vector3(23,31,72);
				var expected = new Vector3(31,23,31);
				Assert.AreEqual(expected, value.YXY());
			}
			[Test]
			public void YXYX_Definition()
			{
				var value = new Vector3(16,49,76);
				var expected = new Vector4(49,16,49,16);
				Assert.AreEqual(expected, value.YXYX());
			}
			[Test]
			public void YXYY_Definition()
			{
				var value = new Vector3(3,39,72);
				var expected = new Vector4(39,3,39,39);
				Assert.AreEqual(expected, value.YXYY());
			}
			[Test]
			public void YXYZ_Definition()
			{
				var value = new Vector3(0,50,67);
				var expected = new Vector4(50,0,50,67);
				Assert.AreEqual(expected, value.YXYZ());
			}
			[Test]
			public void YXZ_Definition()
			{
				var value = new Vector3(20,35,73);
				var expected = new Vector3(35,20,73);
				Assert.AreEqual(expected, value.YXZ());
			}
			[Test]
			public void YXZX_Definition()
			{
				var value = new Vector3(4,54,65);
				var expected = new Vector4(54,4,65,4);
				Assert.AreEqual(expected, value.YXZX());
			}
			[Test]
			public void YXZY_Definition()
			{
				var value = new Vector3(22,37,84);
				var expected = new Vector4(37,22,84,37);
				Assert.AreEqual(expected, value.YXZY());
			}
			[Test]
			public void YXZZ_Definition()
			{
				var value = new Vector3(23,30,82);
				var expected = new Vector4(30,23,82,82);
				Assert.AreEqual(expected, value.YXZZ());
			}
			[Test]
			public void YY_Definition()
			{
				var value = new Vector3(6,57,84);
				var expected = new Vector2(57,57);
				Assert.AreEqual(expected, value.YY());
			}
			[Test]
			public void YYX_Definition()
			{
				var value = new Vector3(7,51,63);
				var expected = new Vector3(51,51,7);
				Assert.AreEqual(expected, value.YYX());
			}
			[Test]
			public void YYXX_Definition()
			{
				var value = new Vector3(24,52,82);
				var expected = new Vector4(52,52,24,24);
				Assert.AreEqual(expected, value.YYXX());
			}
			[Test]
			public void YYXY_Definition()
			{
				var value = new Vector3(25,57,66);
				var expected = new Vector4(57,57,25,57);
				Assert.AreEqual(expected, value.YYXY());
			}
			[Test]
			public void YYXZ_Definition()
			{
				var value = new Vector3(18,31,75);
				var expected = new Vector4(31,31,18,75);
				Assert.AreEqual(expected, value.YYXZ());
			}
			[Test]
			public void YYY_Definition()
			{
				var value = new Vector3(16,41,82);
				var expected = new Vector3(41,41,41);
				Assert.AreEqual(expected, value.YYY());
			}
			[Test]
			public void YYYX_Definition()
			{
				var value = new Vector3(26,47,78);
				var expected = new Vector4(47,47,47,26);
				Assert.AreEqual(expected, value.YYYX());
			}
			[Test]
			public void YYYY_Definition()
			{
				var value = new Vector3(23,49,61);
				var expected = new Vector4(49,49,49,49);
				Assert.AreEqual(expected, value.YYYY());
			}
			[Test]
			public void YYYZ_Definition()
			{
				var value = new Vector3(19,43,84);
				var expected = new Vector4(43,43,43,84);
				Assert.AreEqual(expected, value.YYYZ());
			}
			[Test]
			public void YYZ_Definition()
			{
				var value = new Vector3(24,38,78);
				var expected = new Vector3(38,38,78);
				Assert.AreEqual(expected, value.YYZ());
			}
			[Test]
			public void YYZX_Definition()
			{
				var value = new Vector3(22,53,88);
				var expected = new Vector4(53,53,88,22);
				Assert.AreEqual(expected, value.YYZX());
			}
			[Test]
			public void YYZY_Definition()
			{
				var value = new Vector3(9,49,87);
				var expected = new Vector4(49,49,87,49);
				Assert.AreEqual(expected, value.YYZY());
			}
			[Test]
			public void YYZZ_Definition()
			{
				var value = new Vector3(22,53,62);
				var expected = new Vector4(53,53,62,62);
				Assert.AreEqual(expected, value.YYZZ());
			}
			[Test]
			public void YZ_Definition()
			{
				var value = new Vector3(23,49,73);
				var expected = new Vector2(49,73);
				Assert.AreEqual(expected, value.YZ());
			}
			[Test]
			public void YZX_Definition()
			{
				var value = new Vector3(20,53,76);
				var expected = new Vector3(53,76,20);
				Assert.AreEqual(expected, value.YZX());
			}
			[Test]
			public void YZXX_Definition()
			{
				var value = new Vector3(16,37,68);
				var expected = new Vector4(37,68,16,16);
				Assert.AreEqual(expected, value.YZXX());
			}
			[Test]
			public void YZXY_Definition()
			{
				var value = new Vector3(4,58,88);
				var expected = new Vector4(58,88,4,58);
				Assert.AreEqual(expected, value.YZXY());
			}
			[Test]
			public void YZXZ_Definition()
			{
				var value = new Vector3(6,46,87);
				var expected = new Vector4(46,87,6,87);
				Assert.AreEqual(expected, value.YZXZ());
			}
			[Test]
			public void YZY_Definition()
			{
				var value = new Vector3(23,53,76);
				var expected = new Vector3(53,76,53);
				Assert.AreEqual(expected, value.YZY());
			}
			[Test]
			public void YZYX_Definition()
			{
				var value = new Vector3(10,46,82);
				var expected = new Vector4(46,82,46,10);
				Assert.AreEqual(expected, value.YZYX());
			}
			[Test]
			public void YZYY_Definition()
			{
				var value = new Vector3(27,58,67);
				var expected = new Vector4(58,67,58,58);
				Assert.AreEqual(expected, value.YZYY());
			}
			[Test]
			public void YZYZ_Definition()
			{
				var value = new Vector3(17,49,70);
				var expected = new Vector4(49,70,49,70);
				Assert.AreEqual(expected, value.YZYZ());
			}
			[Test]
			public void YZZ_Definition()
			{
				var value = new Vector3(26,55,64);
				var expected = new Vector3(55,64,64);
				Assert.AreEqual(expected, value.YZZ());
			}
			[Test]
			public void YZZX_Definition()
			{
				var value = new Vector3(17,48,88);
				var expected = new Vector4(48,88,88,17);
				Assert.AreEqual(expected, value.YZZX());
			}
			[Test]
			public void YZZY_Definition()
			{
				var value = new Vector3(10,40,63);
				var expected = new Vector4(40,63,63,40);
				Assert.AreEqual(expected, value.YZZY());
			}
			[Test]
			public void YZZZ_Definition()
			{
				var value = new Vector3(5,30,69);
				var expected = new Vector4(30,69,69,69);
				Assert.AreEqual(expected, value.YZZZ());
			}
			[Test]
			public void ZX_Definition()
			{
				var value = new Vector3(20,53,86);
				var expected = new Vector2(86,20);
				Assert.AreEqual(expected, value.ZX());
			}
			[Test]
			public void ZXX_Definition()
			{
				var value = new Vector3(21,55,78);
				var expected = new Vector3(78,21,21);
				Assert.AreEqual(expected, value.ZXX());
			}
			[Test]
			public void ZXXX_Definition()
			{
				var value = new Vector3(16,58,78);
				var expected = new Vector4(78,16,16,16);
				Assert.AreEqual(expected, value.ZXXX());
			}
			[Test]
			public void ZXXY_Definition()
			{
				var value = new Vector3(12,37,82);
				var expected = new Vector4(82,12,12,37);
				Assert.AreEqual(expected, value.ZXXY());
			}
			[Test]
			public void ZXXZ_Definition()
			{
				var value = new Vector3(5,49,83);
				var expected = new Vector4(83,5,5,83);
				Assert.AreEqual(expected, value.ZXXZ());
			}
			[Test]
			public void ZXY_Definition()
			{
				var value = new Vector3(17,56,61);
				var expected = new Vector3(61,17,56);
				Assert.AreEqual(expected, value.ZXY());
			}
			[Test]
			public void ZXYX_Definition()
			{
				var value = new Vector3(16,33,78);
				var expected = new Vector4(78,16,33,16);
				Assert.AreEqual(expected, value.ZXYX());
			}
			[Test]
			public void ZXYY_Definition()
			{
				var value = new Vector3(11,55,84);
				var expected = new Vector4(84,11,55,55);
				Assert.AreEqual(expected, value.ZXYY());
			}
			[Test]
			public void ZXYZ_Definition()
			{
				var value = new Vector3(13,40,79);
				var expected = new Vector4(79,13,40,79);
				Assert.AreEqual(expected, value.ZXYZ());
			}
			[Test]
			public void ZXZ_Definition()
			{
				var value = new Vector3(5,42,80);
				var expected = new Vector3(80,5,80);
				Assert.AreEqual(expected, value.ZXZ());
			}
			[Test]
			public void ZXZX_Definition()
			{
				var value = new Vector3(13,34,81);
				var expected = new Vector4(81,13,81,13);
				Assert.AreEqual(expected, value.ZXZX());
			}
			[Test]
			public void ZXZY_Definition()
			{
				var value = new Vector3(1,46,68);
				var expected = new Vector4(68,1,68,46);
				Assert.AreEqual(expected, value.ZXZY());
			}
			[Test]
			public void ZXZZ_Definition()
			{
				var value = new Vector3(13,44,76);
				var expected = new Vector4(76,13,76,76);
				Assert.AreEqual(expected, value.ZXZZ());
			}
			[Test]
			public void ZY_Definition()
			{
				var value = new Vector3(0,42,83);
				var expected = new Vector2(83,42);
				Assert.AreEqual(expected, value.ZY());
			}
			[Test]
			public void ZYX_Definition()
			{
				var value = new Vector3(15,58,60);
				var expected = new Vector3(60,58,15);
				Assert.AreEqual(expected, value.ZYX());
			}
			[Test]
			public void ZYXX_Definition()
			{
				var value = new Vector3(5,32,76);
				var expected = new Vector4(76,32,5,5);
				Assert.AreEqual(expected, value.ZYXX());
			}
			[Test]
			public void ZYXY_Definition()
			{
				var value = new Vector3(26,39,64);
				var expected = new Vector4(64,39,26,39);
				Assert.AreEqual(expected, value.ZYXY());
			}
			[Test]
			public void ZYXZ_Definition()
			{
				var value = new Vector3(26,57,65);
				var expected = new Vector4(65,57,26,65);
				Assert.AreEqual(expected, value.ZYXZ());
			}
			[Test]
			public void ZYY_Definition()
			{
				var value = new Vector3(27,31,71);
				var expected = new Vector3(71,31,31);
				Assert.AreEqual(expected, value.ZYY());
			}
			[Test]
			public void ZYYX_Definition()
			{
				var value = new Vector3(15,35,77);
				var expected = new Vector4(77,35,35,15);
				Assert.AreEqual(expected, value.ZYYX());
			}
			[Test]
			public void ZYYY_Definition()
			{
				var value = new Vector3(6,57,82);
				var expected = new Vector4(82,57,57,57);
				Assert.AreEqual(expected, value.ZYYY());
			}
			[Test]
			public void ZYYZ_Definition()
			{
				var value = new Vector3(14,32,74);
				var expected = new Vector4(74,32,32,74);
				Assert.AreEqual(expected, value.ZYYZ());
			}
			[Test]
			public void ZYZ_Definition()
			{
				var value = new Vector3(20,34,79);
				var expected = new Vector3(79,34,79);
				Assert.AreEqual(expected, value.ZYZ());
			}
			[Test]
			public void ZYZX_Definition()
			{
				var value = new Vector3(17,37,83);
				var expected = new Vector4(83,37,83,17);
				Assert.AreEqual(expected, value.ZYZX());
			}
			[Test]
			public void ZYZY_Definition()
			{
				var value = new Vector3(28,48,81);
				var expected = new Vector4(81,48,81,48);
				Assert.AreEqual(expected, value.ZYZY());
			}
			[Test]
			public void ZYZZ_Definition()
			{
				var value = new Vector3(13,33,72);
				var expected = new Vector4(72,33,72,72);
				Assert.AreEqual(expected, value.ZYZZ());
			}
			[Test]
			public void ZZ_Definition()
			{
				var value = new Vector3(26,42,62);
				var expected = new Vector2(62,62);
				Assert.AreEqual(expected, value.ZZ());
			}
			[Test]
			public void ZZX_Definition()
			{
				var value = new Vector3(28,50,84);
				var expected = new Vector3(84,84,28);
				Assert.AreEqual(expected, value.ZZX());
			}
			[Test]
			public void ZZXX_Definition()
			{
				var value = new Vector3(16,56,64);
				var expected = new Vector4(64,64,16,16);
				Assert.AreEqual(expected, value.ZZXX());
			}
			[Test]
			public void ZZXY_Definition()
			{
				var value = new Vector3(10,39,82);
				var expected = new Vector4(82,82,10,39);
				Assert.AreEqual(expected, value.ZZXY());
			}
			[Test]
			public void ZZXZ_Definition()
			{
				var value = new Vector3(6,33,86);
				var expected = new Vector4(86,86,6,86);
				Assert.AreEqual(expected, value.ZZXZ());
			}
			[Test]
			public void ZZY_Definition()
			{
				var value = new Vector3(6,53,87);
				var expected = new Vector3(87,87,53);
				Assert.AreEqual(expected, value.ZZY());
			}
			[Test]
			public void ZZYX_Definition()
			{
				var value = new Vector3(11,54,80);
				var expected = new Vector4(80,80,54,11);
				Assert.AreEqual(expected, value.ZZYX());
			}
			[Test]
			public void ZZYY_Definition()
			{
				var value = new Vector3(15,39,67);
				var expected = new Vector4(67,67,39,39);
				Assert.AreEqual(expected, value.ZZYY());
			}
			[Test]
			public void ZZYZ_Definition()
			{
				var value = new Vector3(9,44,61);
				var expected = new Vector4(61,61,44,61);
				Assert.AreEqual(expected, value.ZZYZ());
			}
			[Test]
			public void ZZZ_Definition()
			{
				var value = new Vector3(11,34,77);
				var expected = new Vector3(77,77,77);
				Assert.AreEqual(expected, value.ZZZ());
			}
			[Test]
			public void ZZZX_Definition()
			{
				var value = new Vector3(22,42,83);
				var expected = new Vector4(83,83,83,22);
				Assert.AreEqual(expected, value.ZZZX());
			}
			[Test]
			public void ZZZY_Definition()
			{
				var value = new Vector3(15,47,80);
				var expected = new Vector4(80,80,80,47);
				Assert.AreEqual(expected, value.ZZZY());
			}
			[Test]
			public void ZZZZ_Definition()
			{
				var value = new Vector3(28,44,69);
				var expected = new Vector4(69,69,69,69);
				Assert.AreEqual(expected, value.ZZZZ());
			}
		}
		
		public class Vector4Cases : VectorExSwizzleTests
		{
			[Test]
			public void XX_Definition()
			{
				var value = new Vector4(15,57,85,95);
				var expected = new Vector2(15,15);
				Assert.AreEqual(expected, value.XX());
			}
			[Test]
			public void XXX_Definition()
			{
				var value = new Vector4(9,38,71,98);
				var expected = new Vector3(9,9,9);
				Assert.AreEqual(expected, value.XXX());
			}
			[Test]
			public void XXXX_Definition()
			{
				var value = new Vector4(17,43,68,99);
				var expected = new Vector4(17,17,17,17);
				Assert.AreEqual(expected, value.XXXX());
			}
			[Test]
			public void XXXY_Definition()
			{
				var value = new Vector4(7,41,80,108);
				var expected = new Vector4(7,7,7,41);
				Assert.AreEqual(expected, value.XXXY());
			}
			[Test]
			public void XXXZ_Definition()
			{
				var value = new Vector4(15,31,88,105);
				var expected = new Vector4(15,15,15,88);
				Assert.AreEqual(expected, value.XXXZ());
			}
			[Test]
			public void XXXW_Definition()
			{
				var value = new Vector4(26,30,87,91);
				var expected = new Vector4(26,26,26,91);
				Assert.AreEqual(expected, value.XXXW());
			}
			[Test]
			public void XXY_Definition()
			{
				var value = new Vector4(18,46,79,91);
				var expected = new Vector3(18,18,46);
				Assert.AreEqual(expected, value.XXY());
			}
			[Test]
			public void XXYX_Definition()
			{
				var value = new Vector4(16,45,70,112);
				var expected = new Vector4(16,16,45,16);
				Assert.AreEqual(expected, value.XXYX());
			}
			[Test]
			public void XXYY_Definition()
			{
				var value = new Vector4(4,32,76,96);
				var expected = new Vector4(4,4,32,32);
				Assert.AreEqual(expected, value.XXYY());
			}
			[Test]
			public void XXYZ_Definition()
			{
				var value = new Vector4(11,53,81,96);
				var expected = new Vector4(11,11,53,81);
				Assert.AreEqual(expected, value.XXYZ());
			}
			[Test]
			public void XXYW_Definition()
			{
				var value = new Vector4(9,55,65,117);
				var expected = new Vector4(9,9,55,117);
				Assert.AreEqual(expected, value.XXYW());
			}
			[Test]
			public void XXZ_Definition()
			{
				var value = new Vector4(12,55,83,109);
				var expected = new Vector3(12,12,83);
				Assert.AreEqual(expected, value.XXZ());
			}
			[Test]
			public void XXZX_Definition()
			{
				var value = new Vector4(19,39,85,91);
				var expected = new Vector4(19,19,85,19);
				Assert.AreEqual(expected, value.XXZX());
			}
			[Test]
			public void XXZY_Definition()
			{
				var value = new Vector4(4,35,81,98);
				var expected = new Vector4(4,4,81,35);
				Assert.AreEqual(expected, value.XXZY());
			}
			[Test]
			public void XXZZ_Definition()
			{
				var value = new Vector4(0,48,68,105);
				var expected = new Vector4(0,0,68,68);
				Assert.AreEqual(expected, value.XXZZ());
			}
			[Test]
			public void XXZW_Definition()
			{
				var value = new Vector4(27,39,78,113);
				var expected = new Vector4(27,27,78,113);
				Assert.AreEqual(expected, value.XXZW());
			}
			[Test]
			public void XXW_Definition()
			{
				var value = new Vector4(5,40,75,90);
				var expected = new Vector3(5,5,90);
				Assert.AreEqual(expected, value.XXW());
			}
			[Test]
			public void XXWX_Definition()
			{
				var value = new Vector4(28,44,63,105);
				var expected = new Vector4(28,28,105,28);
				Assert.AreEqual(expected, value.XXWX());
			}
			[Test]
			public void XXWY_Definition()
			{
				var value = new Vector4(26,44,87,91);
				var expected = new Vector4(26,26,91,44);
				Assert.AreEqual(expected, value.XXWY());
			}
			[Test]
			public void XXWZ_Definition()
			{
				var value = new Vector4(19,42,62,104);
				var expected = new Vector4(19,19,104,62);
				Assert.AreEqual(expected, value.XXWZ());
			}
			[Test]
			public void XXWW_Definition()
			{
				var value = new Vector4(11,52,70,116);
				var expected = new Vector4(11,11,116,116);
				Assert.AreEqual(expected, value.XXWW());
			}
			[Test]
			public void XY_Definition()
			{
				var value = new Vector4(27,44,71,102);
				var expected = new Vector2(27,44);
				Assert.AreEqual(expected, value.XY());
			}
			[Test]
			public void XYX_Definition()
			{
				var value = new Vector4(25,56,75,93);
				var expected = new Vector3(25,56,25);
				Assert.AreEqual(expected, value.XYX());
			}
			[Test]
			public void XYXX_Definition()
			{
				var value = new Vector4(26,54,74,102);
				var expected = new Vector4(26,54,26,26);
				Assert.AreEqual(expected, value.XYXX());
			}
			[Test]
			public void XYXY_Definition()
			{
				var value = new Vector4(24,52,70,97);
				var expected = new Vector4(24,52,24,52);
				Assert.AreEqual(expected, value.XYXY());
			}
			[Test]
			public void XYXZ_Definition()
			{
				var value = new Vector4(26,47,78,114);
				var expected = new Vector4(26,47,26,78);
				Assert.AreEqual(expected, value.XYXZ());
			}
			[Test]
			public void XYXW_Definition()
			{
				var value = new Vector4(5,53,77,103);
				var expected = new Vector4(5,53,5,103);
				Assert.AreEqual(expected, value.XYXW());
			}
			[Test]
			public void XYY_Definition()
			{
				var value = new Vector4(4,58,79,110);
				var expected = new Vector3(4,58,58);
				Assert.AreEqual(expected, value.XYY());
			}
			[Test]
			public void XYYX_Definition()
			{
				var value = new Vector4(9,54,74,107);
				var expected = new Vector4(9,54,54,9);
				Assert.AreEqual(expected, value.XYYX());
			}
			[Test]
			public void XYYY_Definition()
			{
				var value = new Vector4(7,56,70,91);
				var expected = new Vector4(7,56,56,56);
				Assert.AreEqual(expected, value.XYYY());
			}
			[Test]
			public void XYYZ_Definition()
			{
				var value = new Vector4(20,52,85,106);
				var expected = new Vector4(20,52,52,85);
				Assert.AreEqual(expected, value.XYYZ());
			}
			[Test]
			public void XYYW_Definition()
			{
				var value = new Vector4(19,52,87,117);
				var expected = new Vector4(19,52,52,117);
				Assert.AreEqual(expected, value.XYYW());
			}
			[Test]
			public void XYZ_Definition()
			{
				var value = new Vector4(15,45,86,117);
				var expected = new Vector3(15,45,86);
				Assert.AreEqual(expected, value.XYZ());
			}
			[Test]
			public void XYZX_Definition()
			{
				var value = new Vector4(6,55,64,112);
				var expected = new Vector4(6,55,64,6);
				Assert.AreEqual(expected, value.XYZX());
			}
			[Test]
			public void XYZY_Definition()
			{
				var value = new Vector4(20,38,73,92);
				var expected = new Vector4(20,38,73,38);
				Assert.AreEqual(expected, value.XYZY());
			}
			[Test]
			public void XYZZ_Definition()
			{
				var value = new Vector4(2,57,68,102);
				var expected = new Vector4(2,57,68,68);
				Assert.AreEqual(expected, value.XYZZ());
			}
			[Test]
			public void XYZW_Definition()
			{
				var value = new Vector4(7,57,74,97);
				var expected = new Vector4(7,57,74,97);
				Assert.AreEqual(expected, value.XYZW());
			}
			[Test]
			public void XYW_Definition()
			{
				var value = new Vector4(4,31,68,115);
				var expected = new Vector3(4,31,115);
				Assert.AreEqual(expected, value.XYW());
			}
			[Test]
			public void XYWX_Definition()
			{
				var value = new Vector4(18,45,62,103);
				var expected = new Vector4(18,45,103,18);
				Assert.AreEqual(expected, value.XYWX());
			}
			[Test]
			public void XYWY_Definition()
			{
				var value = new Vector4(5,53,88,98);
				var expected = new Vector4(5,53,98,53);
				Assert.AreEqual(expected, value.XYWY());
			}
			[Test]
			public void XYWZ_Definition()
			{
				var value = new Vector4(13,34,78,109);
				var expected = new Vector4(13,34,109,78);
				Assert.AreEqual(expected, value.XYWZ());
			}
			[Test]
			public void XYWW_Definition()
			{
				var value = new Vector4(20,46,80,91);
				var expected = new Vector4(20,46,91,91);
				Assert.AreEqual(expected, value.XYWW());
			}
			[Test]
			public void XZ_Definition()
			{
				var value = new Vector4(26,54,77,114);
				var expected = new Vector2(26,77);
				Assert.AreEqual(expected, value.XZ());
			}
			[Test]
			public void XZX_Definition()
			{
				var value = new Vector4(11,30,76,99);
				var expected = new Vector3(11,76,11);
				Assert.AreEqual(expected, value.XZX());
			}
			[Test]
			public void XZXX_Definition()
			{
				var value = new Vector4(26,39,70,112);
				var expected = new Vector4(26,70,26,26);
				Assert.AreEqual(expected, value.XZXX());
			}
			[Test]
			public void XZXY_Definition()
			{
				var value = new Vector4(28,51,70,107);
				var expected = new Vector4(28,70,28,51);
				Assert.AreEqual(expected, value.XZXY());
			}
			[Test]
			public void XZXZ_Definition()
			{
				var value = new Vector4(3,33,66,99);
				var expected = new Vector4(3,66,3,66);
				Assert.AreEqual(expected, value.XZXZ());
			}
			[Test]
			public void XZXW_Definition()
			{
				var value = new Vector4(16,41,70,109);
				var expected = new Vector4(16,70,16,109);
				Assert.AreEqual(expected, value.XZXW());
			}
			[Test]
			public void XZY_Definition()
			{
				var value = new Vector4(22,39,79,117);
				var expected = new Vector3(22,79,39);
				Assert.AreEqual(expected, value.XZY());
			}
			[Test]
			public void XZYX_Definition()
			{
				var value = new Vector4(4,39,72,91);
				var expected = new Vector4(4,72,39,4);
				Assert.AreEqual(expected, value.XZYX());
			}
			[Test]
			public void XZYY_Definition()
			{
				var value = new Vector4(24,45,83,115);
				var expected = new Vector4(24,83,45,45);
				Assert.AreEqual(expected, value.XZYY());
			}
			[Test]
			public void XZYZ_Definition()
			{
				var value = new Vector4(19,37,74,107);
				var expected = new Vector4(19,74,37,74);
				Assert.AreEqual(expected, value.XZYZ());
			}
			[Test]
			public void XZYW_Definition()
			{
				var value = new Vector4(1,40,85,113);
				var expected = new Vector4(1,85,40,113);
				Assert.AreEqual(expected, value.XZYW());
			}
			[Test]
			public void XZZ_Definition()
			{
				var value = new Vector4(2,38,62,95);
				var expected = new Vector3(2,62,62);
				Assert.AreEqual(expected, value.XZZ());
			}
			[Test]
			public void XZZX_Definition()
			{
				var value = new Vector4(6,58,69,111);
				var expected = new Vector4(6,69,69,6);
				Assert.AreEqual(expected, value.XZZX());
			}
			[Test]
			public void XZZY_Definition()
			{
				var value = new Vector4(9,52,62,111);
				var expected = new Vector4(9,62,62,52);
				Assert.AreEqual(expected, value.XZZY());
			}
			[Test]
			public void XZZZ_Definition()
			{
				var value = new Vector4(9,49,62,90);
				var expected = new Vector4(9,62,62,62);
				Assert.AreEqual(expected, value.XZZZ());
			}
			[Test]
			public void XZZW_Definition()
			{
				var value = new Vector4(15,39,72,99);
				var expected = new Vector4(15,72,72,99);
				Assert.AreEqual(expected, value.XZZW());
			}
			[Test]
			public void XZW_Definition()
			{
				var value = new Vector4(18,52,76,117);
				var expected = new Vector3(18,76,117);
				Assert.AreEqual(expected, value.XZW());
			}
			[Test]
			public void XZWX_Definition()
			{
				var value = new Vector4(3,30,88,112);
				var expected = new Vector4(3,88,112,3);
				Assert.AreEqual(expected, value.XZWX());
			}
			[Test]
			public void XZWY_Definition()
			{
				var value = new Vector4(3,57,71,111);
				var expected = new Vector4(3,71,111,57);
				Assert.AreEqual(expected, value.XZWY());
			}
			[Test]
			public void XZWZ_Definition()
			{
				var value = new Vector4(9,35,79,104);
				var expected = new Vector4(9,79,104,79);
				Assert.AreEqual(expected, value.XZWZ());
			}
			[Test]
			public void XZWW_Definition()
			{
				var value = new Vector4(25,46,62,104);
				var expected = new Vector4(25,62,104,104);
				Assert.AreEqual(expected, value.XZWW());
			}
			[Test]
			public void XW_Definition()
			{
				var value = new Vector4(10,45,71,117);
				var expected = new Vector2(10,117);
				Assert.AreEqual(expected, value.XW());
			}
			[Test]
			public void XWX_Definition()
			{
				var value = new Vector4(15,46,70,103);
				var expected = new Vector3(15,103,15);
				Assert.AreEqual(expected, value.XWX());
			}
			[Test]
			public void XWXX_Definition()
			{
				var value = new Vector4(28,37,80,97);
				var expected = new Vector4(28,97,28,28);
				Assert.AreEqual(expected, value.XWXX());
			}
			[Test]
			public void XWXY_Definition()
			{
				var value = new Vector4(11,32,88,102);
				var expected = new Vector4(11,102,11,32);
				Assert.AreEqual(expected, value.XWXY());
			}
			[Test]
			public void XWXZ_Definition()
			{
				var value = new Vector4(21,39,75,117);
				var expected = new Vector4(21,117,21,75);
				Assert.AreEqual(expected, value.XWXZ());
			}
			[Test]
			public void XWXW_Definition()
			{
				var value = new Vector4(14,58,86,111);
				var expected = new Vector4(14,111,14,111);
				Assert.AreEqual(expected, value.XWXW());
			}
			[Test]
			public void XWY_Definition()
			{
				var value = new Vector4(27,38,66,90);
				var expected = new Vector3(27,90,38);
				Assert.AreEqual(expected, value.XWY());
			}
			[Test]
			public void XWYX_Definition()
			{
				var value = new Vector4(25,55,61,112);
				var expected = new Vector4(25,112,55,25);
				Assert.AreEqual(expected, value.XWYX());
			}
			[Test]
			public void XWYY_Definition()
			{
				var value = new Vector4(3,57,62,91);
				var expected = new Vector4(3,91,57,57);
				Assert.AreEqual(expected, value.XWYY());
			}
			[Test]
			public void XWYZ_Definition()
			{
				var value = new Vector4(8,32,71,102);
				var expected = new Vector4(8,102,32,71);
				Assert.AreEqual(expected, value.XWYZ());
			}
			[Test]
			public void XWYW_Definition()
			{
				var value = new Vector4(11,38,67,117);
				var expected = new Vector4(11,117,38,117);
				Assert.AreEqual(expected, value.XWYW());
			}
			[Test]
			public void XWZ_Definition()
			{
				var value = new Vector4(12,52,87,90);
				var expected = new Vector3(12,90,87);
				Assert.AreEqual(expected, value.XWZ());
			}
			[Test]
			public void XWZX_Definition()
			{
				var value = new Vector4(11,39,88,98);
				var expected = new Vector4(11,98,88,11);
				Assert.AreEqual(expected, value.XWZX());
			}
			[Test]
			public void XWZY_Definition()
			{
				var value = new Vector4(16,50,64,95);
				var expected = new Vector4(16,95,64,50);
				Assert.AreEqual(expected, value.XWZY());
			}
			[Test]
			public void XWZZ_Definition()
			{
				var value = new Vector4(12,52,66,107);
				var expected = new Vector4(12,107,66,66);
				Assert.AreEqual(expected, value.XWZZ());
			}
			[Test]
			public void XWZW_Definition()
			{
				var value = new Vector4(20,38,60,94);
				var expected = new Vector4(20,94,60,94);
				Assert.AreEqual(expected, value.XWZW());
			}
			[Test]
			public void XWW_Definition()
			{
				var value = new Vector4(25,43,61,98);
				var expected = new Vector3(25,98,98);
				Assert.AreEqual(expected, value.XWW());
			}
			[Test]
			public void XWWX_Definition()
			{
				var value = new Vector4(15,45,88,93);
				var expected = new Vector4(15,93,93,15);
				Assert.AreEqual(expected, value.XWWX());
			}
			[Test]
			public void XWWY_Definition()
			{
				var value = new Vector4(28,34,74,117);
				var expected = new Vector4(28,117,117,34);
				Assert.AreEqual(expected, value.XWWY());
			}
			[Test]
			public void XWWZ_Definition()
			{
				var value = new Vector4(9,44,77,105);
				var expected = new Vector4(9,105,105,77);
				Assert.AreEqual(expected, value.XWWZ());
			}
			[Test]
			public void XWWW_Definition()
			{
				var value = new Vector4(25,36,86,108);
				var expected = new Vector4(25,108,108,108);
				Assert.AreEqual(expected, value.XWWW());
			}
			[Test]
			public void YX_Definition()
			{
				var value = new Vector4(12,50,64,116);
				var expected = new Vector2(50,12);
				Assert.AreEqual(expected, value.YX());
			}
			[Test]
			public void YXX_Definition()
			{
				var value = new Vector4(15,44,74,91);
				var expected = new Vector3(44,15,15);
				Assert.AreEqual(expected, value.YXX());
			}
			[Test]
			public void YXXX_Definition()
			{
				var value = new Vector4(7,43,70,101);
				var expected = new Vector4(43,7,7,7);
				Assert.AreEqual(expected, value.YXXX());
			}
			[Test]
			public void YXXY_Definition()
			{
				var value = new Vector4(28,47,69,103);
				var expected = new Vector4(47,28,28,47);
				Assert.AreEqual(expected, value.YXXY());
			}
			[Test]
			public void YXXZ_Definition()
			{
				var value = new Vector4(15,47,75,97);
				var expected = new Vector4(47,15,15,75);
				Assert.AreEqual(expected, value.YXXZ());
			}
			[Test]
			public void YXXW_Definition()
			{
				var value = new Vector4(21,48,70,101);
				var expected = new Vector4(48,21,21,101);
				Assert.AreEqual(expected, value.YXXW());
			}
			[Test]
			public void YXY_Definition()
			{
				var value = new Vector4(3,54,78,105);
				var expected = new Vector3(54,3,54);
				Assert.AreEqual(expected, value.YXY());
			}
			[Test]
			public void YXYX_Definition()
			{
				var value = new Vector4(21,31,85,96);
				var expected = new Vector4(31,21,31,21);
				Assert.AreEqual(expected, value.YXYX());
			}
			[Test]
			public void YXYY_Definition()
			{
				var value = new Vector4(25,42,73,103);
				var expected = new Vector4(42,25,42,42);
				Assert.AreEqual(expected, value.YXYY());
			}
			[Test]
			public void YXYZ_Definition()
			{
				var value = new Vector4(1,41,77,98);
				var expected = new Vector4(41,1,41,77);
				Assert.AreEqual(expected, value.YXYZ());
			}
			[Test]
			public void YXYW_Definition()
			{
				var value = new Vector4(25,48,67,102);
				var expected = new Vector4(48,25,48,102);
				Assert.AreEqual(expected, value.YXYW());
			}
			[Test]
			public void YXZ_Definition()
			{
				var value = new Vector4(25,43,76,90);
				var expected = new Vector3(43,25,76);
				Assert.AreEqual(expected, value.YXZ());
			}
			[Test]
			public void YXZX_Definition()
			{
				var value = new Vector4(5,30,82,92);
				var expected = new Vector4(30,5,82,5);
				Assert.AreEqual(expected, value.YXZX());
			}
			[Test]
			public void YXZY_Definition()
			{
				var value = new Vector4(23,50,74,112);
				var expected = new Vector4(50,23,74,50);
				Assert.AreEqual(expected, value.YXZY());
			}
			[Test]
			public void YXZZ_Definition()
			{
				var value = new Vector4(6,45,87,100);
				var expected = new Vector4(45,6,87,87);
				Assert.AreEqual(expected, value.YXZZ());
			}
			[Test]
			public void YXZW_Definition()
			{
				var value = new Vector4(4,58,76,103);
				var expected = new Vector4(58,4,76,103);
				Assert.AreEqual(expected, value.YXZW());
			}
			[Test]
			public void YXW_Definition()
			{
				var value = new Vector4(22,45,85,112);
				var expected = new Vector3(45,22,112);
				Assert.AreEqual(expected, value.YXW());
			}
			[Test]
			public void YXWX_Definition()
			{
				var value = new Vector4(5,45,75,118);
				var expected = new Vector4(45,5,118,5);
				Assert.AreEqual(expected, value.YXWX());
			}
			[Test]
			public void YXWY_Definition()
			{
				var value = new Vector4(7,53,86,90);
				var expected = new Vector4(53,7,90,53);
				Assert.AreEqual(expected, value.YXWY());
			}
			[Test]
			public void YXWZ_Definition()
			{
				var value = new Vector4(12,32,63,118);
				var expected = new Vector4(32,12,118,63);
				Assert.AreEqual(expected, value.YXWZ());
			}
			[Test]
			public void YXWW_Definition()
			{
				var value = new Vector4(24,50,81,105);
				var expected = new Vector4(50,24,105,105);
				Assert.AreEqual(expected, value.YXWW());
			}
			[Test]
			public void YY_Definition()
			{
				var value = new Vector4(15,37,63,111);
				var expected = new Vector2(37,37);
				Assert.AreEqual(expected, value.YY());
			}
			[Test]
			public void YYX_Definition()
			{
				var value = new Vector4(28,58,79,101);
				var expected = new Vector3(58,58,28);
				Assert.AreEqual(expected, value.YYX());
			}
			[Test]
			public void YYXX_Definition()
			{
				var value = new Vector4(21,44,72,93);
				var expected = new Vector4(44,44,21,21);
				Assert.AreEqual(expected, value.YYXX());
			}
			[Test]
			public void YYXY_Definition()
			{
				var value = new Vector4(10,35,80,117);
				var expected = new Vector4(35,35,10,35);
				Assert.AreEqual(expected, value.YYXY());
			}
			[Test]
			public void YYXZ_Definition()
			{
				var value = new Vector4(6,32,83,100);
				var expected = new Vector4(32,32,6,83);
				Assert.AreEqual(expected, value.YYXZ());
			}
			[Test]
			public void YYXW_Definition()
			{
				var value = new Vector4(25,38,68,102);
				var expected = new Vector4(38,38,25,102);
				Assert.AreEqual(expected, value.YYXW());
			}
			[Test]
			public void YYY_Definition()
			{
				var value = new Vector4(3,54,72,113);
				var expected = new Vector3(54,54,54);
				Assert.AreEqual(expected, value.YYY());
			}
			[Test]
			public void YYYX_Definition()
			{
				var value = new Vector4(25,42,69,103);
				var expected = new Vector4(42,42,42,25);
				Assert.AreEqual(expected, value.YYYX());
			}
			[Test]
			public void YYYY_Definition()
			{
				var value = new Vector4(2,53,84,94);
				var expected = new Vector4(53,53,53,53);
				Assert.AreEqual(expected, value.YYYY());
			}
			[Test]
			public void YYYZ_Definition()
			{
				var value = new Vector4(28,58,85,112);
				var expected = new Vector4(58,58,58,85);
				Assert.AreEqual(expected, value.YYYZ());
			}
			[Test]
			public void YYYW_Definition()
			{
				var value = new Vector4(11,56,82,91);
				var expected = new Vector4(56,56,56,91);
				Assert.AreEqual(expected, value.YYYW());
			}
			[Test]
			public void YYZ_Definition()
			{
				var value = new Vector4(3,39,65,95);
				var expected = new Vector3(39,39,65);
				Assert.AreEqual(expected, value.YYZ());
			}
			[Test]
			public void YYZX_Definition()
			{
				var value = new Vector4(16,43,76,102);
				var expected = new Vector4(43,43,76,16);
				Assert.AreEqual(expected, value.YYZX());
			}
			[Test]
			public void YYZY_Definition()
			{
				var value = new Vector4(13,31,88,97);
				var expected = new Vector4(31,31,88,31);
				Assert.AreEqual(expected, value.YYZY());
			}
			[Test]
			public void YYZZ_Definition()
			{
				var value = new Vector4(2,39,62,110);
				var expected = new Vector4(39,39,62,62);
				Assert.AreEqual(expected, value.YYZZ());
			}
			[Test]
			public void YYZW_Definition()
			{
				var value = new Vector4(16,31,65,103);
				var expected = new Vector4(31,31,65,103);
				Assert.AreEqual(expected, value.YYZW());
			}
			[Test]
			public void YYW_Definition()
			{
				var value = new Vector4(28,36,71,109);
				var expected = new Vector3(36,36,109);
				Assert.AreEqual(expected, value.YYW());
			}
			[Test]
			public void YYWX_Definition()
			{
				var value = new Vector4(23,30,76,102);
				var expected = new Vector4(30,30,102,23);
				Assert.AreEqual(expected, value.YYWX());
			}
			[Test]
			public void YYWY_Definition()
			{
				var value = new Vector4(9,30,77,104);
				var expected = new Vector4(30,30,104,30);
				Assert.AreEqual(expected, value.YYWY());
			}
			[Test]
			public void YYWZ_Definition()
			{
				var value = new Vector4(3,45,67,93);
				var expected = new Vector4(45,45,93,67);
				Assert.AreEqual(expected, value.YYWZ());
			}
			[Test]
			public void YYWW_Definition()
			{
				var value = new Vector4(20,57,74,116);
				var expected = new Vector4(57,57,116,116);
				Assert.AreEqual(expected, value.YYWW());
			}
			[Test]
			public void YZ_Definition()
			{
				var value = new Vector4(26,57,84,105);
				var expected = new Vector2(57,84);
				Assert.AreEqual(expected, value.YZ());
			}
			[Test]
			public void YZX_Definition()
			{
				var value = new Vector4(7,41,77,106);
				var expected = new Vector3(41,77,7);
				Assert.AreEqual(expected, value.YZX());
			}
			[Test]
			public void YZXX_Definition()
			{
				var value = new Vector4(5,46,82,99);
				var expected = new Vector4(46,82,5,5);
				Assert.AreEqual(expected, value.YZXX());
			}
			[Test]
			public void YZXY_Definition()
			{
				var value = new Vector4(19,45,84,94);
				var expected = new Vector4(45,84,19,45);
				Assert.AreEqual(expected, value.YZXY());
			}
			[Test]
			public void YZXZ_Definition()
			{
				var value = new Vector4(13,44,82,98);
				var expected = new Vector4(44,82,13,82);
				Assert.AreEqual(expected, value.YZXZ());
			}
			[Test]
			public void YZXW_Definition()
			{
				var value = new Vector4(7,46,62,112);
				var expected = new Vector4(46,62,7,112);
				Assert.AreEqual(expected, value.YZXW());
			}
			[Test]
			public void YZY_Definition()
			{
				var value = new Vector4(21,30,62,116);
				var expected = new Vector3(30,62,30);
				Assert.AreEqual(expected, value.YZY());
			}
			[Test]
			public void YZYX_Definition()
			{
				var value = new Vector4(15,31,77,98);
				var expected = new Vector4(31,77,31,15);
				Assert.AreEqual(expected, value.YZYX());
			}
			[Test]
			public void YZYY_Definition()
			{
				var value = new Vector4(8,45,82,105);
				var expected = new Vector4(45,82,45,45);
				Assert.AreEqual(expected, value.YZYY());
			}
			[Test]
			public void YZYZ_Definition()
			{
				var value = new Vector4(5,54,76,115);
				var expected = new Vector4(54,76,54,76);
				Assert.AreEqual(expected, value.YZYZ());
			}
			[Test]
			public void YZYW_Definition()
			{
				var value = new Vector4(27,45,64,94);
				var expected = new Vector4(45,64,45,94);
				Assert.AreEqual(expected, value.YZYW());
			}
			[Test]
			public void YZZ_Definition()
			{
				var value = new Vector4(6,33,68,97);
				var expected = new Vector3(33,68,68);
				Assert.AreEqual(expected, value.YZZ());
			}
			[Test]
			public void YZZX_Definition()
			{
				var value = new Vector4(2,51,79,116);
				var expected = new Vector4(51,79,79,2);
				Assert.AreEqual(expected, value.YZZX());
			}
			[Test]
			public void YZZY_Definition()
			{
				var value = new Vector4(1,55,61,93);
				var expected = new Vector4(55,61,61,55);
				Assert.AreEqual(expected, value.YZZY());
			}
			[Test]
			public void YZZZ_Definition()
			{
				var value = new Vector4(20,33,85,105);
				var expected = new Vector4(33,85,85,85);
				Assert.AreEqual(expected, value.YZZZ());
			}
			[Test]
			public void YZZW_Definition()
			{
				var value = new Vector4(13,31,88,113);
				var expected = new Vector4(31,88,88,113);
				Assert.AreEqual(expected, value.YZZW());
			}
			[Test]
			public void YZW_Definition()
			{
				var value = new Vector4(23,48,65,102);
				var expected = new Vector3(48,65,102);
				Assert.AreEqual(expected, value.YZW());
			}
			[Test]
			public void YZWX_Definition()
			{
				var value = new Vector4(6,54,82,115);
				var expected = new Vector4(54,82,115,6);
				Assert.AreEqual(expected, value.YZWX());
			}
			[Test]
			public void YZWY_Definition()
			{
				var value = new Vector4(9,34,86,97);
				var expected = new Vector4(34,86,97,34);
				Assert.AreEqual(expected, value.YZWY());
			}
			[Test]
			public void YZWZ_Definition()
			{
				var value = new Vector4(20,49,65,99);
				var expected = new Vector4(49,65,99,65);
				Assert.AreEqual(expected, value.YZWZ());
			}
			[Test]
			public void YZWW_Definition()
			{
				var value = new Vector4(11,33,82,99);
				var expected = new Vector4(33,82,99,99);
				Assert.AreEqual(expected, value.YZWW());
			}
			[Test]
			public void YW_Definition()
			{
				var value = new Vector4(23,56,63,98);
				var expected = new Vector2(56,98);
				Assert.AreEqual(expected, value.YW());
			}
			[Test]
			public void YWX_Definition()
			{
				var value = new Vector4(1,43,61,115);
				var expected = new Vector3(43,115,1);
				Assert.AreEqual(expected, value.YWX());
			}
			[Test]
			public void YWXX_Definition()
			{
				var value = new Vector4(16,43,71,103);
				var expected = new Vector4(43,103,16,16);
				Assert.AreEqual(expected, value.YWXX());
			}
			[Test]
			public void YWXY_Definition()
			{
				var value = new Vector4(6,39,74,109);
				var expected = new Vector4(39,109,6,39);
				Assert.AreEqual(expected, value.YWXY());
			}
			[Test]
			public void YWXZ_Definition()
			{
				var value = new Vector4(15,32,66,104);
				var expected = new Vector4(32,104,15,66);
				Assert.AreEqual(expected, value.YWXZ());
			}
			[Test]
			public void YWXW_Definition()
			{
				var value = new Vector4(5,57,64,104);
				var expected = new Vector4(57,104,5,104);
				Assert.AreEqual(expected, value.YWXW());
			}
			[Test]
			public void YWY_Definition()
			{
				var value = new Vector4(20,51,75,111);
				var expected = new Vector3(51,111,51);
				Assert.AreEqual(expected, value.YWY());
			}
			[Test]
			public void YWYX_Definition()
			{
				var value = new Vector4(15,53,68,109);
				var expected = new Vector4(53,109,53,15);
				Assert.AreEqual(expected, value.YWYX());
			}
			[Test]
			public void YWYY_Definition()
			{
				var value = new Vector4(11,51,70,115);
				var expected = new Vector4(51,115,51,51);
				Assert.AreEqual(expected, value.YWYY());
			}
			[Test]
			public void YWYZ_Definition()
			{
				var value = new Vector4(6,52,87,101);
				var expected = new Vector4(52,101,52,87);
				Assert.AreEqual(expected, value.YWYZ());
			}
			[Test]
			public void YWYW_Definition()
			{
				var value = new Vector4(7,56,67,117);
				var expected = new Vector4(56,117,56,117);
				Assert.AreEqual(expected, value.YWYW());
			}
			[Test]
			public void YWZ_Definition()
			{
				var value = new Vector4(9,41,79,111);
				var expected = new Vector3(41,111,79);
				Assert.AreEqual(expected, value.YWZ());
			}
			[Test]
			public void YWZX_Definition()
			{
				var value = new Vector4(4,37,80,108);
				var expected = new Vector4(37,108,80,4);
				Assert.AreEqual(expected, value.YWZX());
			}
			[Test]
			public void YWZY_Definition()
			{
				var value = new Vector4(1,39,87,115);
				var expected = new Vector4(39,115,87,39);
				Assert.AreEqual(expected, value.YWZY());
			}
			[Test]
			public void YWZZ_Definition()
			{
				var value = new Vector4(23,58,84,100);
				var expected = new Vector4(58,100,84,84);
				Assert.AreEqual(expected, value.YWZZ());
			}
			[Test]
			public void YWZW_Definition()
			{
				var value = new Vector4(9,58,63,117);
				var expected = new Vector4(58,117,63,117);
				Assert.AreEqual(expected, value.YWZW());
			}
			[Test]
			public void YWW_Definition()
			{
				var value = new Vector4(2,33,64,110);
				var expected = new Vector3(33,110,110);
				Assert.AreEqual(expected, value.YWW());
			}
			[Test]
			public void YWWX_Definition()
			{
				var value = new Vector4(17,33,62,111);
				var expected = new Vector4(33,111,111,17);
				Assert.AreEqual(expected, value.YWWX());
			}
			[Test]
			public void YWWY_Definition()
			{
				var value = new Vector4(11,35,74,108);
				var expected = new Vector4(35,108,108,35);
				Assert.AreEqual(expected, value.YWWY());
			}
			[Test]
			public void YWWZ_Definition()
			{
				var value = new Vector4(25,57,69,111);
				var expected = new Vector4(57,111,111,69);
				Assert.AreEqual(expected, value.YWWZ());
			}
			[Test]
			public void YWWW_Definition()
			{
				var value = new Vector4(1,49,82,101);
				var expected = new Vector4(49,101,101,101);
				Assert.AreEqual(expected, value.YWWW());
			}
			[Test]
			public void ZX_Definition()
			{
				var value = new Vector4(1,44,73,113);
				var expected = new Vector2(73,1);
				Assert.AreEqual(expected, value.ZX());
			}
			[Test]
			public void ZXX_Definition()
			{
				var value = new Vector4(23,54,86,95);
				var expected = new Vector3(86,23,23);
				Assert.AreEqual(expected, value.ZXX());
			}
			[Test]
			public void ZXXX_Definition()
			{
				var value = new Vector4(5,35,63,101);
				var expected = new Vector4(63,5,5,5);
				Assert.AreEqual(expected, value.ZXXX());
			}
			[Test]
			public void ZXXY_Definition()
			{
				var value = new Vector4(23,57,88,114);
				var expected = new Vector4(88,23,23,57);
				Assert.AreEqual(expected, value.ZXXY());
			}
			[Test]
			public void ZXXZ_Definition()
			{
				var value = new Vector4(19,55,74,114);
				var expected = new Vector4(74,19,19,74);
				Assert.AreEqual(expected, value.ZXXZ());
			}
			[Test]
			public void ZXXW_Definition()
			{
				var value = new Vector4(18,44,68,94);
				var expected = new Vector4(68,18,18,94);
				Assert.AreEqual(expected, value.ZXXW());
			}
			[Test]
			public void ZXY_Definition()
			{
				var value = new Vector4(7,56,77,116);
				var expected = new Vector3(77,7,56);
				Assert.AreEqual(expected, value.ZXY());
			}
			[Test]
			public void ZXYX_Definition()
			{
				var value = new Vector4(8,41,81,104);
				var expected = new Vector4(81,8,41,8);
				Assert.AreEqual(expected, value.ZXYX());
			}
			[Test]
			public void ZXYY_Definition()
			{
				var value = new Vector4(7,50,85,118);
				var expected = new Vector4(85,7,50,50);
				Assert.AreEqual(expected, value.ZXYY());
			}
			[Test]
			public void ZXYZ_Definition()
			{
				var value = new Vector4(16,40,67,96);
				var expected = new Vector4(67,16,40,67);
				Assert.AreEqual(expected, value.ZXYZ());
			}
			[Test]
			public void ZXYW_Definition()
			{
				var value = new Vector4(22,42,84,115);
				var expected = new Vector4(84,22,42,115);
				Assert.AreEqual(expected, value.ZXYW());
			}
			[Test]
			public void ZXZ_Definition()
			{
				var value = new Vector4(9,35,80,117);
				var expected = new Vector3(80,9,80);
				Assert.AreEqual(expected, value.ZXZ());
			}
			[Test]
			public void ZXZX_Definition()
			{
				var value = new Vector4(11,51,86,103);
				var expected = new Vector4(86,11,86,11);
				Assert.AreEqual(expected, value.ZXZX());
			}
			[Test]
			public void ZXZY_Definition()
			{
				var value = new Vector4(8,46,83,111);
				var expected = new Vector4(83,8,83,46);
				Assert.AreEqual(expected, value.ZXZY());
			}
			[Test]
			public void ZXZZ_Definition()
			{
				var value = new Vector4(25,30,81,110);
				var expected = new Vector4(81,25,81,81);
				Assert.AreEqual(expected, value.ZXZZ());
			}
			[Test]
			public void ZXZW_Definition()
			{
				var value = new Vector4(15,57,62,96);
				var expected = new Vector4(62,15,62,96);
				Assert.AreEqual(expected, value.ZXZW());
			}
			[Test]
			public void ZXW_Definition()
			{
				var value = new Vector4(5,36,83,90);
				var expected = new Vector3(83,5,90);
				Assert.AreEqual(expected, value.ZXW());
			}
			[Test]
			public void ZXWX_Definition()
			{
				var value = new Vector4(4,33,80,110);
				var expected = new Vector4(80,4,110,4);
				Assert.AreEqual(expected, value.ZXWX());
			}
			[Test]
			public void ZXWY_Definition()
			{
				var value = new Vector4(0,49,86,112);
				var expected = new Vector4(86,0,112,49);
				Assert.AreEqual(expected, value.ZXWY());
			}
			[Test]
			public void ZXWZ_Definition()
			{
				var value = new Vector4(23,51,84,102);
				var expected = new Vector4(84,23,102,84);
				Assert.AreEqual(expected, value.ZXWZ());
			}
			[Test]
			public void ZXWW_Definition()
			{
				var value = new Vector4(22,33,63,91);
				var expected = new Vector4(63,22,91,91);
				Assert.AreEqual(expected, value.ZXWW());
			}
			[Test]
			public void ZY_Definition()
			{
				var value = new Vector4(19,45,61,107);
				var expected = new Vector2(61,45);
				Assert.AreEqual(expected, value.ZY());
			}
			[Test]
			public void ZYX_Definition()
			{
				var value = new Vector4(8,39,78,106);
				var expected = new Vector3(78,39,8);
				Assert.AreEqual(expected, value.ZYX());
			}
			[Test]
			public void ZYXX_Definition()
			{
				var value = new Vector4(27,49,63,98);
				var expected = new Vector4(63,49,27,27);
				Assert.AreEqual(expected, value.ZYXX());
			}
			[Test]
			public void ZYXY_Definition()
			{
				var value = new Vector4(20,32,80,105);
				var expected = new Vector4(80,32,20,32);
				Assert.AreEqual(expected, value.ZYXY());
			}
			[Test]
			public void ZYXZ_Definition()
			{
				var value = new Vector4(26,32,84,113);
				var expected = new Vector4(84,32,26,84);
				Assert.AreEqual(expected, value.ZYXZ());
			}
			[Test]
			public void ZYXW_Definition()
			{
				var value = new Vector4(14,30,63,90);
				var expected = new Vector4(63,30,14,90);
				Assert.AreEqual(expected, value.ZYXW());
			}
			[Test]
			public void ZYY_Definition()
			{
				var value = new Vector4(24,43,78,98);
				var expected = new Vector3(78,43,43);
				Assert.AreEqual(expected, value.ZYY());
			}
			[Test]
			public void ZYYX_Definition()
			{
				var value = new Vector4(22,43,84,111);
				var expected = new Vector4(84,43,43,22);
				Assert.AreEqual(expected, value.ZYYX());
			}
			[Test]
			public void ZYYY_Definition()
			{
				var value = new Vector4(17,32,67,106);
				var expected = new Vector4(67,32,32,32);
				Assert.AreEqual(expected, value.ZYYY());
			}
			[Test]
			public void ZYYZ_Definition()
			{
				var value = new Vector4(19,42,68,91);
				var expected = new Vector4(68,42,42,68);
				Assert.AreEqual(expected, value.ZYYZ());
			}
			[Test]
			public void ZYYW_Definition()
			{
				var value = new Vector4(22,51,76,98);
				var expected = new Vector4(76,51,51,98);
				Assert.AreEqual(expected, value.ZYYW());
			}
			[Test]
			public void ZYZ_Definition()
			{
				var value = new Vector4(18,49,66,102);
				var expected = new Vector3(66,49,66);
				Assert.AreEqual(expected, value.ZYZ());
			}
			[Test]
			public void ZYZX_Definition()
			{
				var value = new Vector4(12,44,80,114);
				var expected = new Vector4(80,44,80,12);
				Assert.AreEqual(expected, value.ZYZX());
			}
			[Test]
			public void ZYZY_Definition()
			{
				var value = new Vector4(28,54,60,101);
				var expected = new Vector4(60,54,60,54);
				Assert.AreEqual(expected, value.ZYZY());
			}
			[Test]
			public void ZYZZ_Definition()
			{
				var value = new Vector4(28,57,72,112);
				var expected = new Vector4(72,57,72,72);
				Assert.AreEqual(expected, value.ZYZZ());
			}
			[Test]
			public void ZYZW_Definition()
			{
				var value = new Vector4(24,49,83,104);
				var expected = new Vector4(83,49,83,104);
				Assert.AreEqual(expected, value.ZYZW());
			}
			[Test]
			public void ZYW_Definition()
			{
				var value = new Vector4(26,55,87,92);
				var expected = new Vector3(87,55,92);
				Assert.AreEqual(expected, value.ZYW());
			}
			[Test]
			public void ZYWX_Definition()
			{
				var value = new Vector4(5,32,76,113);
				var expected = new Vector4(76,32,113,5);
				Assert.AreEqual(expected, value.ZYWX());
			}
			[Test]
			public void ZYWY_Definition()
			{
				var value = new Vector4(9,56,62,105);
				var expected = new Vector4(62,56,105,56);
				Assert.AreEqual(expected, value.ZYWY());
			}
			[Test]
			public void ZYWZ_Definition()
			{
				var value = new Vector4(18,37,66,104);
				var expected = new Vector4(66,37,104,66);
				Assert.AreEqual(expected, value.ZYWZ());
			}
			[Test]
			public void ZYWW_Definition()
			{
				var value = new Vector4(4,52,64,113);
				var expected = new Vector4(64,52,113,113);
				Assert.AreEqual(expected, value.ZYWW());
			}
			[Test]
			public void ZZ_Definition()
			{
				var value = new Vector4(20,36,85,102);
				var expected = new Vector2(85,85);
				Assert.AreEqual(expected, value.ZZ());
			}
			[Test]
			public void ZZX_Definition()
			{
				var value = new Vector4(1,36,78,91);
				var expected = new Vector3(78,78,1);
				Assert.AreEqual(expected, value.ZZX());
			}
			[Test]
			public void ZZXX_Definition()
			{
				var value = new Vector4(17,42,83,95);
				var expected = new Vector4(83,83,17,17);
				Assert.AreEqual(expected, value.ZZXX());
			}
			[Test]
			public void ZZXY_Definition()
			{
				var value = new Vector4(3,58,88,108);
				var expected = new Vector4(88,88,3,58);
				Assert.AreEqual(expected, value.ZZXY());
			}
			[Test]
			public void ZZXZ_Definition()
			{
				var value = new Vector4(15,55,72,117);
				var expected = new Vector4(72,72,15,72);
				Assert.AreEqual(expected, value.ZZXZ());
			}
			[Test]
			public void ZZXW_Definition()
			{
				var value = new Vector4(7,33,77,98);
				var expected = new Vector4(77,77,7,98);
				Assert.AreEqual(expected, value.ZZXW());
			}
			[Test]
			public void ZZY_Definition()
			{
				var value = new Vector4(14,54,84,91);
				var expected = new Vector3(84,84,54);
				Assert.AreEqual(expected, value.ZZY());
			}
			[Test]
			public void ZZYX_Definition()
			{
				var value = new Vector4(21,49,77,113);
				var expected = new Vector4(77,77,49,21);
				Assert.AreEqual(expected, value.ZZYX());
			}
			[Test]
			public void ZZYY_Definition()
			{
				var value = new Vector4(0,34,73,116);
				var expected = new Vector4(73,73,34,34);
				Assert.AreEqual(expected, value.ZZYY());
			}
			[Test]
			public void ZZYZ_Definition()
			{
				var value = new Vector4(12,53,62,97);
				var expected = new Vector4(62,62,53,62);
				Assert.AreEqual(expected, value.ZZYZ());
			}
			[Test]
			public void ZZYW_Definition()
			{
				var value = new Vector4(17,31,69,104);
				var expected = new Vector4(69,69,31,104);
				Assert.AreEqual(expected, value.ZZYW());
			}
			[Test]
			public void ZZZ_Definition()
			{
				var value = new Vector4(1,48,63,116);
				var expected = new Vector3(63,63,63);
				Assert.AreEqual(expected, value.ZZZ());
			}
			[Test]
			public void ZZZX_Definition()
			{
				var value = new Vector4(12,42,61,90);
				var expected = new Vector4(61,61,61,12);
				Assert.AreEqual(expected, value.ZZZX());
			}
			[Test]
			public void ZZZY_Definition()
			{
				var value = new Vector4(0,34,82,98);
				var expected = new Vector4(82,82,82,34);
				Assert.AreEqual(expected, value.ZZZY());
			}
			[Test]
			public void ZZZZ_Definition()
			{
				var value = new Vector4(8,39,65,101);
				var expected = new Vector4(65,65,65,65);
				Assert.AreEqual(expected, value.ZZZZ());
			}
			[Test]
			public void ZZZW_Definition()
			{
				var value = new Vector4(1,53,77,116);
				var expected = new Vector4(77,77,77,116);
				Assert.AreEqual(expected, value.ZZZW());
			}
			[Test]
			public void ZZW_Definition()
			{
				var value = new Vector4(13,34,68,100);
				var expected = new Vector3(68,68,100);
				Assert.AreEqual(expected, value.ZZW());
			}
			[Test]
			public void ZZWX_Definition()
			{
				var value = new Vector4(1,53,82,105);
				var expected = new Vector4(82,82,105,1);
				Assert.AreEqual(expected, value.ZZWX());
			}
			[Test]
			public void ZZWY_Definition()
			{
				var value = new Vector4(12,43,67,99);
				var expected = new Vector4(67,67,99,43);
				Assert.AreEqual(expected, value.ZZWY());
			}
			[Test]
			public void ZZWZ_Definition()
			{
				var value = new Vector4(21,41,60,100);
				var expected = new Vector4(60,60,100,60);
				Assert.AreEqual(expected, value.ZZWZ());
			}
			[Test]
			public void ZZWW_Definition()
			{
				var value = new Vector4(12,47,65,105);
				var expected = new Vector4(65,65,105,105);
				Assert.AreEqual(expected, value.ZZWW());
			}
			[Test]
			public void ZW_Definition()
			{
				var value = new Vector4(12,40,78,115);
				var expected = new Vector2(78,115);
				Assert.AreEqual(expected, value.ZW());
			}
			[Test]
			public void ZWX_Definition()
			{
				var value = new Vector4(18,30,78,102);
				var expected = new Vector3(78,102,18);
				Assert.AreEqual(expected, value.ZWX());
			}
			[Test]
			public void ZWXX_Definition()
			{
				var value = new Vector4(0,41,64,97);
				var expected = new Vector4(64,97,0,0);
				Assert.AreEqual(expected, value.ZWXX());
			}
			[Test]
			public void ZWXY_Definition()
			{
				var value = new Vector4(2,56,79,96);
				var expected = new Vector4(79,96,2,56);
				Assert.AreEqual(expected, value.ZWXY());
			}
			[Test]
			public void ZWXZ_Definition()
			{
				var value = new Vector4(4,48,75,103);
				var expected = new Vector4(75,103,4,75);
				Assert.AreEqual(expected, value.ZWXZ());
			}
			[Test]
			public void ZWXW_Definition()
			{
				var value = new Vector4(6,33,76,114);
				var expected = new Vector4(76,114,6,114);
				Assert.AreEqual(expected, value.ZWXW());
			}
			[Test]
			public void ZWY_Definition()
			{
				var value = new Vector4(15,46,63,98);
				var expected = new Vector3(63,98,46);
				Assert.AreEqual(expected, value.ZWY());
			}
			[Test]
			public void ZWYX_Definition()
			{
				var value = new Vector4(19,56,82,94);
				var expected = new Vector4(82,94,56,19);
				Assert.AreEqual(expected, value.ZWYX());
			}
			[Test]
			public void ZWYY_Definition()
			{
				var value = new Vector4(12,57,81,112);
				var expected = new Vector4(81,112,57,57);
				Assert.AreEqual(expected, value.ZWYY());
			}
			[Test]
			public void ZWYZ_Definition()
			{
				var value = new Vector4(0,45,86,104);
				var expected = new Vector4(86,104,45,86);
				Assert.AreEqual(expected, value.ZWYZ());
			}
			[Test]
			public void ZWYW_Definition()
			{
				var value = new Vector4(11,53,78,90);
				var expected = new Vector4(78,90,53,90);
				Assert.AreEqual(expected, value.ZWYW());
			}
			[Test]
			public void ZWZ_Definition()
			{
				var value = new Vector4(10,47,85,110);
				var expected = new Vector3(85,110,85);
				Assert.AreEqual(expected, value.ZWZ());
			}
			[Test]
			public void ZWZX_Definition()
			{
				var value = new Vector4(4,45,63,93);
				var expected = new Vector4(63,93,63,4);
				Assert.AreEqual(expected, value.ZWZX());
			}
			[Test]
			public void ZWZY_Definition()
			{
				var value = new Vector4(20,57,75,103);
				var expected = new Vector4(75,103,75,57);
				Assert.AreEqual(expected, value.ZWZY());
			}
			[Test]
			public void ZWZZ_Definition()
			{
				var value = new Vector4(1,41,79,108);
				var expected = new Vector4(79,108,79,79);
				Assert.AreEqual(expected, value.ZWZZ());
			}
			[Test]
			public void ZWZW_Definition()
			{
				var value = new Vector4(3,42,70,95);
				var expected = new Vector4(70,95,70,95);
				Assert.AreEqual(expected, value.ZWZW());
			}
			[Test]
			public void ZWW_Definition()
			{
				var value = new Vector4(17,51,66,108);
				var expected = new Vector3(66,108,108);
				Assert.AreEqual(expected, value.ZWW());
			}
			[Test]
			public void ZWWX_Definition()
			{
				var value = new Vector4(12,55,87,113);
				var expected = new Vector4(87,113,113,12);
				Assert.AreEqual(expected, value.ZWWX());
			}
			[Test]
			public void ZWWY_Definition()
			{
				var value = new Vector4(6,33,82,111);
				var expected = new Vector4(82,111,111,33);
				Assert.AreEqual(expected, value.ZWWY());
			}
			[Test]
			public void ZWWZ_Definition()
			{
				var value = new Vector4(11,40,64,93);
				var expected = new Vector4(64,93,93,64);
				Assert.AreEqual(expected, value.ZWWZ());
			}
			[Test]
			public void ZWWW_Definition()
			{
				var value = new Vector4(16,52,67,94);
				var expected = new Vector4(67,94,94,94);
				Assert.AreEqual(expected, value.ZWWW());
			}
			[Test]
			public void WX_Definition()
			{
				var value = new Vector4(6,51,62,105);
				var expected = new Vector2(105,6);
				Assert.AreEqual(expected, value.WX());
			}
			[Test]
			public void WXX_Definition()
			{
				var value = new Vector4(24,53,60,95);
				var expected = new Vector3(95,24,24);
				Assert.AreEqual(expected, value.WXX());
			}
			[Test]
			public void WXXX_Definition()
			{
				var value = new Vector4(3,57,74,107);
				var expected = new Vector4(107,3,3,3);
				Assert.AreEqual(expected, value.WXXX());
			}
			[Test]
			public void WXXY_Definition()
			{
				var value = new Vector4(12,52,69,101);
				var expected = new Vector4(101,12,12,52);
				Assert.AreEqual(expected, value.WXXY());
			}
			[Test]
			public void WXXZ_Definition()
			{
				var value = new Vector4(21,33,75,96);
				var expected = new Vector4(96,21,21,75);
				Assert.AreEqual(expected, value.WXXZ());
			}
			[Test]
			public void WXXW_Definition()
			{
				var value = new Vector4(6,55,60,114);
				var expected = new Vector4(114,6,6,114);
				Assert.AreEqual(expected, value.WXXW());
			}
			[Test]
			public void WXY_Definition()
			{
				var value = new Vector4(19,44,62,98);
				var expected = new Vector3(98,19,44);
				Assert.AreEqual(expected, value.WXY());
			}
			[Test]
			public void WXYX_Definition()
			{
				var value = new Vector4(28,42,77,94);
				var expected = new Vector4(94,28,42,28);
				Assert.AreEqual(expected, value.WXYX());
			}
			[Test]
			public void WXYY_Definition()
			{
				var value = new Vector4(24,51,62,106);
				var expected = new Vector4(106,24,51,51);
				Assert.AreEqual(expected, value.WXYY());
			}
			[Test]
			public void WXYZ_Definition()
			{
				var value = new Vector4(16,30,67,111);
				var expected = new Vector4(111,16,30,67);
				Assert.AreEqual(expected, value.WXYZ());
			}
			[Test]
			public void WXYW_Definition()
			{
				var value = new Vector4(28,43,60,102);
				var expected = new Vector4(102,28,43,102);
				Assert.AreEqual(expected, value.WXYW());
			}
			[Test]
			public void WXZ_Definition()
			{
				var value = new Vector4(3,57,86,102);
				var expected = new Vector3(102,3,86);
				Assert.AreEqual(expected, value.WXZ());
			}
			[Test]
			public void WXZX_Definition()
			{
				var value = new Vector4(19,51,64,109);
				var expected = new Vector4(109,19,64,19);
				Assert.AreEqual(expected, value.WXZX());
			}
			[Test]
			public void WXZY_Definition()
			{
				var value = new Vector4(10,45,65,115);
				var expected = new Vector4(115,10,65,45);
				Assert.AreEqual(expected, value.WXZY());
			}
			[Test]
			public void WXZZ_Definition()
			{
				var value = new Vector4(25,49,61,114);
				var expected = new Vector4(114,25,61,61);
				Assert.AreEqual(expected, value.WXZZ());
			}
			[Test]
			public void WXZW_Definition()
			{
				var value = new Vector4(21,56,76,97);
				var expected = new Vector4(97,21,76,97);
				Assert.AreEqual(expected, value.WXZW());
			}
			[Test]
			public void WXW_Definition()
			{
				var value = new Vector4(28,51,82,107);
				var expected = new Vector3(107,28,107);
				Assert.AreEqual(expected, value.WXW());
			}
			[Test]
			public void WXWX_Definition()
			{
				var value = new Vector4(12,38,85,108);
				var expected = new Vector4(108,12,108,12);
				Assert.AreEqual(expected, value.WXWX());
			}
			[Test]
			public void WXWY_Definition()
			{
				var value = new Vector4(0,34,87,97);
				var expected = new Vector4(97,0,97,34);
				Assert.AreEqual(expected, value.WXWY());
			}
			[Test]
			public void WXWZ_Definition()
			{
				var value = new Vector4(23,48,66,117);
				var expected = new Vector4(117,23,117,66);
				Assert.AreEqual(expected, value.WXWZ());
			}
			[Test]
			public void WXWW_Definition()
			{
				var value = new Vector4(26,58,84,97);
				var expected = new Vector4(97,26,97,97);
				Assert.AreEqual(expected, value.WXWW());
			}
			[Test]
			public void WY_Definition()
			{
				var value = new Vector4(3,51,84,94);
				var expected = new Vector2(94,51);
				Assert.AreEqual(expected, value.WY());
			}
			[Test]
			public void WYX_Definition()
			{
				var value = new Vector4(5,43,84,93);
				var expected = new Vector3(93,43,5);
				Assert.AreEqual(expected, value.WYX());
			}
			[Test]
			public void WYXX_Definition()
			{
				var value = new Vector4(24,36,64,90);
				var expected = new Vector4(90,36,24,24);
				Assert.AreEqual(expected, value.WYXX());
			}
			[Test]
			public void WYXY_Definition()
			{
				var value = new Vector4(21,54,88,93);
				var expected = new Vector4(93,54,21,54);
				Assert.AreEqual(expected, value.WYXY());
			}
			[Test]
			public void WYXZ_Definition()
			{
				var value = new Vector4(28,33,63,106);
				var expected = new Vector4(106,33,28,63);
				Assert.AreEqual(expected, value.WYXZ());
			}
			[Test]
			public void WYXW_Definition()
			{
				var value = new Vector4(17,31,86,118);
				var expected = new Vector4(118,31,17,118);
				Assert.AreEqual(expected, value.WYXW());
			}
			[Test]
			public void WYY_Definition()
			{
				var value = new Vector4(8,37,66,111);
				var expected = new Vector3(111,37,37);
				Assert.AreEqual(expected, value.WYY());
			}
			[Test]
			public void WYYX_Definition()
			{
				var value = new Vector4(7,44,71,105);
				var expected = new Vector4(105,44,44,7);
				Assert.AreEqual(expected, value.WYYX());
			}
			[Test]
			public void WYYY_Definition()
			{
				var value = new Vector4(13,39,64,94);
				var expected = new Vector4(94,39,39,39);
				Assert.AreEqual(expected, value.WYYY());
			}
			[Test]
			public void WYYZ_Definition()
			{
				var value = new Vector4(21,30,68,95);
				var expected = new Vector4(95,30,30,68);
				Assert.AreEqual(expected, value.WYYZ());
			}
			[Test]
			public void WYYW_Definition()
			{
				var value = new Vector4(21,35,86,98);
				var expected = new Vector4(98,35,35,98);
				Assert.AreEqual(expected, value.WYYW());
			}
			[Test]
			public void WYZ_Definition()
			{
				var value = new Vector4(27,47,88,99);
				var expected = new Vector3(99,47,88);
				Assert.AreEqual(expected, value.WYZ());
			}
			[Test]
			public void WYZX_Definition()
			{
				var value = new Vector4(17,54,62,114);
				var expected = new Vector4(114,54,62,17);
				Assert.AreEqual(expected, value.WYZX());
			}
			[Test]
			public void WYZY_Definition()
			{
				var value = new Vector4(10,37,68,100);
				var expected = new Vector4(100,37,68,37);
				Assert.AreEqual(expected, value.WYZY());
			}
			[Test]
			public void WYZZ_Definition()
			{
				var value = new Vector4(5,33,74,110);
				var expected = new Vector4(110,33,74,74);
				Assert.AreEqual(expected, value.WYZZ());
			}
			[Test]
			public void WYZW_Definition()
			{
				var value = new Vector4(10,41,84,112);
				var expected = new Vector4(112,41,84,112);
				Assert.AreEqual(expected, value.WYZW());
			}
			[Test]
			public void WYW_Definition()
			{
				var value = new Vector4(23,56,70,107);
				var expected = new Vector3(107,56,107);
				Assert.AreEqual(expected, value.WYW());
			}
			[Test]
			public void WYWX_Definition()
			{
				var value = new Vector4(19,37,70,99);
				var expected = new Vector4(99,37,99,19);
				Assert.AreEqual(expected, value.WYWX());
			}
			[Test]
			public void WYWY_Definition()
			{
				var value = new Vector4(6,32,82,118);
				var expected = new Vector4(118,32,118,32);
				Assert.AreEqual(expected, value.WYWY());
			}
			[Test]
			public void WYWZ_Definition()
			{
				var value = new Vector4(11,38,76,92);
				var expected = new Vector4(92,38,92,76);
				Assert.AreEqual(expected, value.WYWZ());
			}
			[Test]
			public void WYWW_Definition()
			{
				var value = new Vector4(14,41,83,118);
				var expected = new Vector4(118,41,118,118);
				Assert.AreEqual(expected, value.WYWW());
			}
			[Test]
			public void WZ_Definition()
			{
				var value = new Vector4(4,40,81,103);
				var expected = new Vector2(103,81);
				Assert.AreEqual(expected, value.WZ());
			}
			[Test]
			public void WZX_Definition()
			{
				var value = new Vector4(15,33,73,93);
				var expected = new Vector3(93,73,15);
				Assert.AreEqual(expected, value.WZX());
			}
			[Test]
			public void WZXX_Definition()
			{
				var value = new Vector4(27,56,86,110);
				var expected = new Vector4(110,86,27,27);
				Assert.AreEqual(expected, value.WZXX());
			}
			[Test]
			public void WZXY_Definition()
			{
				var value = new Vector4(4,57,78,99);
				var expected = new Vector4(99,78,4,57);
				Assert.AreEqual(expected, value.WZXY());
			}
			[Test]
			public void WZXZ_Definition()
			{
				var value = new Vector4(17,35,60,111);
				var expected = new Vector4(111,60,17,60);
				Assert.AreEqual(expected, value.WZXZ());
			}
			[Test]
			public void WZXW_Definition()
			{
				var value = new Vector4(20,50,75,114);
				var expected = new Vector4(114,75,20,114);
				Assert.AreEqual(expected, value.WZXW());
			}
			[Test]
			public void WZY_Definition()
			{
				var value = new Vector4(1,40,63,92);
				var expected = new Vector3(92,63,40);
				Assert.AreEqual(expected, value.WZY());
			}
			[Test]
			public void WZYX_Definition()
			{
				var value = new Vector4(14,52,81,117);
				var expected = new Vector4(117,81,52,14);
				Assert.AreEqual(expected, value.WZYX());
			}
			[Test]
			public void WZYY_Definition()
			{
				var value = new Vector4(6,49,78,107);
				var expected = new Vector4(107,78,49,49);
				Assert.AreEqual(expected, value.WZYY());
			}
			[Test]
			public void WZYZ_Definition()
			{
				var value = new Vector4(13,38,75,93);
				var expected = new Vector4(93,75,38,75);
				Assert.AreEqual(expected, value.WZYZ());
			}
			[Test]
			public void WZYW_Definition()
			{
				var value = new Vector4(23,34,78,102);
				var expected = new Vector4(102,78,34,102);
				Assert.AreEqual(expected, value.WZYW());
			}
			[Test]
			public void WZZ_Definition()
			{
				var value = new Vector4(18,37,87,102);
				var expected = new Vector3(102,87,87);
				Assert.AreEqual(expected, value.WZZ());
			}
			[Test]
			public void WZZX_Definition()
			{
				var value = new Vector4(4,42,84,106);
				var expected = new Vector4(106,84,84,4);
				Assert.AreEqual(expected, value.WZZX());
			}
			[Test]
			public void WZZY_Definition()
			{
				var value = new Vector4(5,33,77,98);
				var expected = new Vector4(98,77,77,33);
				Assert.AreEqual(expected, value.WZZY());
			}
			[Test]
			public void WZZZ_Definition()
			{
				var value = new Vector4(10,49,86,103);
				var expected = new Vector4(103,86,86,86);
				Assert.AreEqual(expected, value.WZZZ());
			}
			[Test]
			public void WZZW_Definition()
			{
				var value = new Vector4(19,33,72,104);
				var expected = new Vector4(104,72,72,104);
				Assert.AreEqual(expected, value.WZZW());
			}
			[Test]
			public void WZW_Definition()
			{
				var value = new Vector4(28,54,70,115);
				var expected = new Vector3(115,70,115);
				Assert.AreEqual(expected, value.WZW());
			}
			[Test]
			public void WZWX_Definition()
			{
				var value = new Vector4(22,37,72,111);
				var expected = new Vector4(111,72,111,22);
				Assert.AreEqual(expected, value.WZWX());
			}
			[Test]
			public void WZWY_Definition()
			{
				var value = new Vector4(17,36,82,100);
				var expected = new Vector4(100,82,100,36);
				Assert.AreEqual(expected, value.WZWY());
			}
			[Test]
			public void WZWZ_Definition()
			{
				var value = new Vector4(26,56,87,108);
				var expected = new Vector4(108,87,108,87);
				Assert.AreEqual(expected, value.WZWZ());
			}
			[Test]
			public void WZWW_Definition()
			{
				var value = new Vector4(8,41,84,94);
				var expected = new Vector4(94,84,94,94);
				Assert.AreEqual(expected, value.WZWW());
			}
			[Test]
			public void WW_Definition()
			{
				var value = new Vector4(9,52,82,99);
				var expected = new Vector2(99,99);
				Assert.AreEqual(expected, value.WW());
			}
			[Test]
			public void WWX_Definition()
			{
				var value = new Vector4(27,47,60,97);
				var expected = new Vector3(97,97,27);
				Assert.AreEqual(expected, value.WWX());
			}
			[Test]
			public void WWXX_Definition()
			{
				var value = new Vector4(23,57,87,92);
				var expected = new Vector4(92,92,23,23);
				Assert.AreEqual(expected, value.WWXX());
			}
			[Test]
			public void WWXY_Definition()
			{
				var value = new Vector4(11,44,86,117);
				var expected = new Vector4(117,117,11,44);
				Assert.AreEqual(expected, value.WWXY());
			}
			[Test]
			public void WWXZ_Definition()
			{
				var value = new Vector4(5,35,75,111);
				var expected = new Vector4(111,111,5,75);
				Assert.AreEqual(expected, value.WWXZ());
			}
			[Test]
			public void WWXW_Definition()
			{
				var value = new Vector4(5,53,77,101);
				var expected = new Vector4(101,101,5,101);
				Assert.AreEqual(expected, value.WWXW());
			}
			[Test]
			public void WWY_Definition()
			{
				var value = new Vector4(0,40,72,103);
				var expected = new Vector3(103,103,40);
				Assert.AreEqual(expected, value.WWY());
			}
			[Test]
			public void WWYX_Definition()
			{
				var value = new Vector4(5,32,68,91);
				var expected = new Vector4(91,91,32,5);
				Assert.AreEqual(expected, value.WWYX());
			}
			[Test]
			public void WWYY_Definition()
			{
				var value = new Vector4(27,51,74,100);
				var expected = new Vector4(100,100,51,51);
				Assert.AreEqual(expected, value.WWYY());
			}
			[Test]
			public void WWYZ_Definition()
			{
				var value = new Vector4(13,44,65,94);
				var expected = new Vector4(94,94,44,65);
				Assert.AreEqual(expected, value.WWYZ());
			}
			[Test]
			public void WWYW_Definition()
			{
				var value = new Vector4(11,30,74,98);
				var expected = new Vector4(98,98,30,98);
				Assert.AreEqual(expected, value.WWYW());
			}
			[Test]
			public void WWZ_Definition()
			{
				var value = new Vector4(14,54,65,95);
				var expected = new Vector3(95,95,65);
				Assert.AreEqual(expected, value.WWZ());
			}
			[Test]
			public void WWZX_Definition()
			{
				var value = new Vector4(8,47,69,92);
				var expected = new Vector4(92,92,69,8);
				Assert.AreEqual(expected, value.WWZX());
			}
			[Test]
			public void WWZY_Definition()
			{
				var value = new Vector4(24,56,63,92);
				var expected = new Vector4(92,92,63,56);
				Assert.AreEqual(expected, value.WWZY());
			}
			[Test]
			public void WWZZ_Definition()
			{
				var value = new Vector4(14,44,81,106);
				var expected = new Vector4(106,106,81,81);
				Assert.AreEqual(expected, value.WWZZ());
			}
			[Test]
			public void WWZW_Definition()
			{
				var value = new Vector4(26,48,63,90);
				var expected = new Vector4(90,90,63,90);
				Assert.AreEqual(expected, value.WWZW());
			}
			[Test]
			public void WWW_Definition()
			{
				var value = new Vector4(28,37,75,107);
				var expected = new Vector3(107,107,107);
				Assert.AreEqual(expected, value.WWW());
			}
			[Test]
			public void WWWX_Definition()
			{
				var value = new Vector4(24,54,61,91);
				var expected = new Vector4(91,91,91,24);
				Assert.AreEqual(expected, value.WWWX());
			}
			[Test]
			public void WWWY_Definition()
			{
				var value = new Vector4(2,42,87,113);
				var expected = new Vector4(113,113,113,42);
				Assert.AreEqual(expected, value.WWWY());
			}
			[Test]
			public void WWWZ_Definition()
			{
				var value = new Vector4(28,39,84,107);
				var expected = new Vector4(107,107,107,84);
				Assert.AreEqual(expected, value.WWWZ());
			}
			[Test]
			public void WWWW_Definition()
			{
				var value = new Vector4(28,34,83,98);
				var expected = new Vector4(98,98,98,98);
				Assert.AreEqual(expected, value.WWWW());
			}
		}
	}
}
