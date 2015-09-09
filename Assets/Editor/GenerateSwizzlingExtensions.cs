namespace Alquimiaware
{
    using UnityEngine;
    using System.Collections;
    using UnityEditor;
    using System.IO;
    using System;

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
                    ns.CommentLine("This code has been automatically generated. Don't edit manually");
                    ns.CommentLine("It will be overriden after each regeneration");
                    ns.CommentLine("If want to change something, do it in the generator, then regenerate");
                    ns.WriteLine("[TestFixture]");
                    using (var ca = Block("public abstract class VectorExSwizzleTests", code))
                    {
                        using (var c = Block("public class Vector2 : VectorExSwizzleTests", code))
                        {
                            CreateTest(c, "XX");
                        }
                    }

                }
            }
            AssetDatabase.Refresh();
        }

        private static void CreateTest(CodeBlock c, string permutation)
        {
            var code = c.Code;
            c.WriteLine("[Test]");
            using (var m = Block("public void " + permutation + "_Definition()", code))
            {
                m.CommentLine("TODO: Implement test body generation");
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

        private class CodeBlock : IDisposable
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