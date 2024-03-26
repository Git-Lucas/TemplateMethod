namespace TemplateMethod.DomainServices.SalesReport;
public abstract class BaseSalesReport
{
    public Entities.Document GenerateReport()
    {
        string header = GenerateHeader();
        string body = GenerateBody();
        string footer = GenerateFooter();

        return new Entities.Document(header, body, footer);
    }

    private string GenerateHeader()
    {
        return "-----------------------SALES REPORT---------------------";
    }

    protected abstract string GenerateBody();

    private string GenerateFooter()
    {
        return $"{DateTime.Now}----------------------- Page 1 of 1";
    }
}
