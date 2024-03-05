using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class CodeGeneratorTests
{
    [Test]
    public void GenerateFunction_CreatesFunctionWithProperFormat()
    {
        // Arrange
        string expectedFunction = "public static void MyFunction(int x)\n{\n    Console.WriteLine(x);\n}";

        // Act
        string generatedFunction = CodeGenerator.GenerateFunction("MyFunction", "int x", "Console.WriteLine(x);");

        // Assert
        Assert.AreEqual(expectedFunction, generatedFunction);
    }

    [Test]
    public void GenerateClass_CreatesClassWithProperFormat()
    {
        // Arrange
        List<string> attributes = new List<string> { "int x", "string name" };
        List<string> methods = new List<string> { "public void PrintName() { Console.WriteLine(name); }" };
        string expectedClass = "public class MyClass\n{\n    public int x;\n    public string name;\n\n    public void PrintName() { Console.WriteLine(name); }\n}";

        // Act
        string generatedClass = CodeGenerator.GenerateClass("MyClass", attributes, methods);

        // Assert
        Assert.AreEqual(expectedClass, generatedClass);
    }
}
