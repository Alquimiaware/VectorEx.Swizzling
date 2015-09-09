namespace Alquimiaware
{
    using UnityEngine;
    using System.Collections;
    using UnityEditor;
    using System.IO;

    public static class GenerateSwizzlingExtensions
    {
        private const string TestsAssetPath = @"Tests\Editor\VectorEx.Swizzling.GeneratedTests.cs";

        [MenuItem("GenerateSwizzling/Tests")]
        public static void GenerateTests()
        {
            // Get correct path
            var contentPath = Path.Combine(Application.dataPath, TestsAssetPath);

            using (var code = File.CreateText(contentPath))
            {
                using (var ns = Block("namespace Alquimiaware", code))
                {
                    ns.WriteLine("using NUnit.Framework;");
                    ns.WriteLine("using UnityEngine;");
                    ns.CommentLine("This code has been automatically generated. Don't edit manually");
                    ns.CommentLine("It will be overriden after each regeneration");
                    ns.CommentLine("If want to change something, do it in the generator, then regenerate");
                    ns.WriteLine("[TestFixture]");
                    using (var ca = Block("public abstract class VectorExSwizzleTests", code))
                    {
                        using (var c = Block("public class Vector2Cases : VectorExSwizzleTests", code))
                        {
                            CreateTestV2(c, "XX");
                        }
                    }

                }
            }
            AssetDatabase.Refresh();
        }

        private static void CreateTestV2(CodeBlock c, string permutation)
        {
            string source = "xy";
            System.Func<char, int> getSourceIdx = symbol =>
            {
                if (source[0] == symbol) return 0;
                else return 1;
            };

            var code = c.Code;
            c.WriteLine("[Test]");
            float anyX = Random.Range(0, 32);
            float anyY = Random.Range(37, 77);
            var anySource = new Vector2(anyX, anyY);

            using (var m = Block("public void " + permutation + "_Definition()", code))
            {
                m.WriteLine("var sut = new Vector2(" + anyX + "," + anyY + ");");
                m.WriteLine(
                    "var expected = new Vector2("
                    + anySource[getSourceIdx(permutation[0])] + ","
                    + anySource[getSourceIdx(permutation[1])] + ");");
                m.WriteLine("Assert.AreEqual(expected, sut." + permutation +"());");
            }
        }

        private static string Tabs(int indentLevel)
        {
            return new string('\t', indentLevel);
        }

        private static CodeBlock Block(string text, StreamWriter code)
        {
            return new CodeBlock(text, code);
        }

        private class CodeBlock : System.IDisposable
        {
            private static int indentLevel;
            private string text;

            public StreamWriter Code { get; private set; }

            public CodeBlock(string text, StreamWriter code)
            {
                this.Code = code;
                this.text = text;
                indentLevel += 1;
                this.Code.WriteLine(string.Concat(Tabs(indentLevel - 1), text));
                this.Code.WriteLine(string.Concat(Tabs(indentLevel - 1), "{"));
            }

            public void WriteLine(string text)
            {
                this.Code.WriteLine(string.Concat(Tabs(indentLevel), text));
            }

            public void CommentLine(string text)
            {
                this.WriteLine(string.Concat("// ", text));
            }

            public void Dispose()
            {
                this.Code.WriteLine(string.Concat(Tabs(indentLevel - 1), "}"));
                indentLevel -= 1;
                this.Code = null;
            }
        }

    }
}