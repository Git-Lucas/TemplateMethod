using TemplateMethod.Data;

namespace TemplateMethod.DomainServices.SalesReport;
public class DailySalesReport : BaseSalesReport
{
    protected override string GenerateBody()
    {
        int salesInOneDay = SalesPerDay.GetSalesInOneDay();

        return $"{nameof(DailySalesReport)}: {salesInOneDay} sales today.";
    }
}
