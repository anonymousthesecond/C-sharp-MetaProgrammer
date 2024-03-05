using System;

class Program
{
    static void Main(string[] args)
    {
        CodeTemplate template = new CodeTemplate("Hello, $name!");
        template.SetValue("name", "World");
        string renderedTemplate = template.Render();
        Console.WriteLine(renderedTemplate);

        Console.WriteLine();

        CodeBuilder builder = new CodeBuilder();
        builder.AddLine("public class MyClass");
        builder.Indent();
        builder.AddLine("{");
        builder.AddLine("public int MyProperty { get; set; }");
        builder.Dedent();
        builder.AddLine("}");
        string generatedCode = builder.ToString();
        Console.WriteLine(generatedCode);

        Console.WriteLine();

        string generatedFunction = CodeGenerator.GenerateFunction("MyFunction", "int x", "Console.WriteLine(x);");
        Console.WriteLine(generatedFunction);

        Console.WriteLine();

        List<string> attributes = new List<string> { "int x", "string name" };
        List<string> methods = new List<string> { "public void PrintName() { Console.WriteLine(name); }" };
        string generatedClass = CodeGenerator.GenerateClass("MyClass", attributes, methods);
        Console.WriteLine(generatedClass);
    }
}
