using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CodeTemplate
{
    private string template;
    private Dictionary<string, string> values;

    public CodeTemplate(string template)
    {
        this.template = template;
        this.values = new Dictionary<string, string>();
    }

    public void SetValue(string key, string value)
    {
        this.values[key] = value;
    }

    public string Render()
    {
        string renderedTemplate = template;
        foreach (var pair in values)
        {
            string placeholder = Regex.Escape("$" + pair.Key);
            renderedTemplate = Regex.Replace(renderedTemplate, placeholder, pair.Value);
        }
        return renderedTemplate;
    }
}
