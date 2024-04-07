using System;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        {
            string text = "{\"Age\":36,\"Name\":\"Anderson\"}";
            string text2 = """{"Age":36,"Name":"Anderson"}""";
            string text3 = """안녕하세요. ""여러분""!""";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
        }

        {
            string text1 = """"안녕하세요. """여러분"""!"""";
            Console.WriteLine(text1);

            string text2 = """""안녕하세요. """"여러분""""!""""";
            Console.WriteLine(text2);

            string text3 = """""안녕하세요. ""여러분""!""""";
            Console.WriteLine(text3);
        }

        {
            string text = @"void Main(string[] args)
                            {
                                Console.WriteLine();
                            }";
            Console.WriteLine(text);
        }

        {
            string text = """
        void Main(string[] args)
        {
            Console.WriteLine();
        }
        """;
            Console.WriteLine(text);
        }

        {
            string mode = "Debug";

            Console.WriteLine($"Mode Length = {mode.ToLowerInvariant()
                .Trim().Length}");
        }

        {
            string text = "Debug";

            Console.WriteLine($"{{Target}} == {text}");
        }

        {
            string text = "Debug";
            Console.WriteLine($$"""{Target} == {{text}}""");

            Console.WriteLine($$$"""{Target} {{PlatForm}} == {{{text}}}""");
        }

        {
            string text = $@"{{
                ""runtimeOptions"": {{
                    ""tfm"": ""net6.0"",
                    ""framework"": {{
                        ""name"": ""Microsoft.NETCore.App"",
                        ""version"": ""{Environment.Version}""
                    }}
                }}
            }}
            ";
        }

        {
            string text = $$"""
                    {
                        "runtimeOptions": {
                            "tfm": "net6.0",
                            "framework": {
                                "name": "Microsoft.NETCore.App",
                                "version": "{{Environment.Version}}"
                            }
                        }
                    }
                    """;
        }

        {
            string text = "Hello";
            byte[] buffer = Encoding.UTF8.GetBytes(text);
        }

        {
            ReadOnlySpan<byte> buffer = "Hello"u8;
            Console.WriteLine(buffer.Length);
        }

        {
            var buffer = "Hello"U8;
            Console.WriteLine(buffer.Length);
        }
    }
}
