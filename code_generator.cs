using System.Collections.Generic;
using System.Text;

public static class CodeGenerator
{
    public static string GenerateFunction(string name, string arguments, string body)
    {
        CodeBuilder builder = new CodeBuilder();
        builder.AddLine($"public static {name}({arguments})");
        builder.AddLine("{");
        builder.Indent();
        builder.AddLine(body);
        builder.Dedent();
        builder.AddLine("}");
        return builder.ToString();
    }

    public static string GenerateClass(string name, List<string> attributes, List<string> methods)
    {
        CodeBuilder builder = new CodeBuilder();
        builder.AddLine($"public class {name}");
        builder.AddLine("{");
        builder.Indent();
        foreach (var attribute in attributes)
        {
            builder.AddLine($"public {attribute};");
        }
        builder.AddLine("");
        foreach (var method in methods)
        {
            builder.AddLine(method);
            builder.AddLine("");
        }
        builder.Dedent();
        builder.AddLine("}");
        return builder.ToString();
    }
}
