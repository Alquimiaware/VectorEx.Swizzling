namespace Alquimiaware
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using UnityEditor;
    using UnityEngine;

    public static class SwizzlingExtensionsGenerator
    {
        private const string TestsAssetPath = @"Tests\Editor\Generated.VectorExSwizzle.Tests.cs";
        private const string ImplAssetPath = @"Runtime\Generated.VectorExSwizzle.cs";

        [MenuItem("GenerateSwizzling/RemoveGenerated")]
        public static void RemoveGeneratedFiles()
        {
            var implPath = Path.Combine(Application.dataPath, ImplAssetPath);
            var testPath = Path.Combine(Application.dataPath, TestsAssetPath);
            File.Delete(implPath);
            File.Delete(testPath);
            AssetDatabase.Refresh();
        }

        [MenuItem("GenerateSwizzling/Regenerate")]
        public static void RegenerateAll()
        {
            GenerateTests();
            GenerateImplementations();
        }

        public static void GenerateTests()
        {
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
                        ca.WriteLine(string.Empty);
                        GenerateTestFamily(code, "Vector2Cases", "XY");
                        ca.WriteLine(string.Empty);
                        GenerateTestFamily(code, "Vector3Cases", "XYZ");
                        ca.WriteLine(string.Empty);
                        GenerateTestFamily(code, "Vector4Cases", "XYZW");
                    }
                }
            }
            AssetDatabase.Refresh();
        }

        public static void GenerateImplementations()
        {
            var contentPath = Path.Combine(Application.dataPath, ImplAssetPath);

            using (var code = File.CreateText(contentPath))
            {
                using (var ns = Block("namespace Alquimiaware", code))
                {
                    ns.WriteLine("using UnityEngine;");
                    ns.CommentLine("This code has been automatically generated. Don't edit manually");
                    ns.CommentLine("It will be overriden after each regeneration");
                    ns.CommentLine("If want to change something, do it in the generator, then regenerate");
                    using (var c = Block("public static class VectorExSwizzle", code))
                    {
                        GenerateImplementationFamilly(c, "XY");
                        GenerateImplementationFamilly(c, "XYZ");
                        GenerateImplementationFamilly(c, "XYZW");
                    }
                }
            }
            AssetDatabase.Refresh();
        }

        private static void GenerateImplementationFamilly(CodeBlock c, string sourceSymbols)
        {
            foreach (var first in sourceSymbols)
                foreach (var second in sourceSymbols)
                {
                    CreateImplementation(c, string.Concat(first, second), sourceSymbols);
                    foreach (var third in sourceSymbols)
                    {
                        CreateImplementation(c, string.Concat(first, second, third), sourceSymbols);
                        foreach (var fourth in sourceSymbols)
                        {
                            CreateImplementation(c, string.Concat(first, second, third, fourth), sourceSymbols);
                        }
                    }
                }
        }

        private static void CreateImplementation(CodeBlock c, string permutation, string sourceSymbols)
        {
            var code = c.Code;
            float anyX = Random.Range(0, 32);
            float anyY = Random.Range(37, 77);
            var initValue = GetRandomInitValue(sourceSymbols);
            int outSize = permutation.Length;
            int inSize = sourceSymbols.Length;

            using (var m = Block("public static Vector" + outSize + " " + permutation + "(this Vector" + inSize + " v)", code))
            {
                m.WriteLine("return Vector" + outSize + ".zero;");
            }
        }


        private static void GenerateTestFamily(StreamWriter code, string name, string sourceSymbols)
        {
            using (var c = Block("public class " + name + " : VectorExSwizzleTests", code))
            {
                foreach (var first in sourceSymbols)
                    foreach (var second in sourceSymbols)
                    {
                        CreateTest(c, string.Concat(first, second), sourceSymbols);
                        foreach (var third in sourceSymbols)
                        {
                            CreateTest(c, string.Concat(first, second, third), sourceSymbols);
                            foreach (var fourth in sourceSymbols)
                            {
                                CreateTest(c, string.Concat(first, second, third, fourth), sourceSymbols);
                            }
                        }
                    }
            }
        }

        private static void CreateTest(CodeBlock c, string permutation, string sourceSymbols)
        {
            var code = c.Code;
            c.WriteLine("[Test]");
            float anyX = Random.Range(0, 32);
            float anyY = Random.Range(37, 77);
            var initValue = GetRandomInitValue(sourceSymbols);

            using (var m = Block("public void " + permutation + "_Definition()", code))
            {
                m.WriteLine("var value = new Vector" + sourceSymbols.Length + "(" + string.Join(",", initValue) + ");");
                m.WriteLine(GetExpectedLine(permutation, sourceSymbols, initValue));
                m.WriteLine("Assert.AreEqual(expected, value." + permutation + "());");
            }
        }

        private static string[] GetRandomInitValue(string sourceSymbols)
        {
            var result = new string[sourceSymbols.Length];

            // ensure the random ranges do not overlap to avoid incorrect results
            for (int i = 0; i < result.Length; i++)
                result[i] = Random.Range(i * 30, (i + 1) * 30 - 1).ToString();

            return result;
        }

        private static string GetExpectedLine(
            string permutation,
            string source,
            string[] initValue)
        {
            int vectorSize = permutation.Length;
            var expected = new StringBuilder();
            expected.Append("var expected = new Vector" + vectorSize + "(");
            var components = string.Join(
                ",",
                Enumerable.Range(0, vectorSize)
                          .Select(i => initValue[GetSourceIdx(permutation[i], source)])
                          .ToArray());

            expected.Append(components);
            expected.Append(");");
            return expected.ToString();
        }

        private static int GetSourceIdx(char symbol, string source)
        {
            int idx = 0;
            for (idx = 0; idx < source.Length; idx++)
                if (symbol == source[idx]) break;

            if (idx == source.Length)
                throw new System.ArgumentOutOfRangeException("symbol", "is not found in source");

            return idx;
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