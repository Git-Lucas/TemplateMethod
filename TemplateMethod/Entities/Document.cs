namespace TemplateMethod.Entities;
public class Document(string header, string body, string footer)
{
    public string Header { get; } = header;
    public string Body { get; } = body;
    public string Footer { get; } = footer;

    public override string ToString()
    {
        return $"{Header}\n\n" +
            $"{Body}\n\n" +
            $"{Footer}\n\n";
    }
}
