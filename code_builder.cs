using System.Collections.Generic;
using System.Text;

public class CodeBuilder
{
    private StringBuilder codeLines;
    private int indentLevel;

    public CodeBuilder()
    {
        this.codeLines = new StringBuilder();
        this.indentLevel = 0;
    }

    public void AddLine(string line)
    {
        codeLines.Append(' ', indentLevel * 4).AppendLine(line);
    }

    public void Indent()
    {
        indentLevel++;
    }

    public void Dedent()
    {
        if (indentLevel > 0)
            indentLevel--;
    }

    public override string ToString()
    {
        return codeLines.ToString();
    }
}
