using NUnit.Framework;

[TestFixture]
public class CodeTemplateTests
{
    [Test]
    public void Render_TemplateWithPlaceholders_ReplacesPlaceholdersWithValues()
    {
        // Arrange
        CodeTemplate template = new CodeTemplate("Hello, $name!");

        // Act
        template.SetValue("name", "World");
        string result = template.Render();

        // Assert
        Assert.AreEqual("Hello, World!", result);
    }
}
