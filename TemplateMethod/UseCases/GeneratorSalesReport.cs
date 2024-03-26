using TemplateMethod.DomainServices.SalesReport;

namespace TemplateMethod.UseCases;
public class GeneratorSalesReport
{
    public Entities.Document Execute(BaseSalesReport salesReport)
    {
        return salesReport.GenerateReport();
    }
}
