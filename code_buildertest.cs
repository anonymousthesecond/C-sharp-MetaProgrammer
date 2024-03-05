using NUnit.Framework;

[TestFixture]
public class CodeBuilderTests
{
    [Test]
    public void AddLine_AddsLineWithProperIndentation()
    {
        // Arrange
        CodeBuilder builder = new CodeBuilder();

        // Act
        builder.AddLine("public class MyClass");
        builder.Indent();
        builder.AddLine("{");
        builder.AddLine("public int MyProperty { get; set; }");
        builder.Dedent();
        builder.AddLine("}");

        // Assert
        string expectedResult = "public class MyClass\n{\n    public int MyProperty { get; set; }\n}\n";
        Assert.AreEqual(expectedResult, builder.ToString());
    }
}
