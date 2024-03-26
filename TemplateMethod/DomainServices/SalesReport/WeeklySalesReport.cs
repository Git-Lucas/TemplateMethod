using TemplateMethod.Data;

namespace TemplateMethod.DomainServices.SalesReport;
public class WeeklySalesReport : BaseSalesReport
{
    protected override string GenerateBody()
    {
        int salesInOneDay = SalesPerDay.GetSalesInOneDay();
        int salesInThisWeekly = salesInOneDay * 5;

        return $"{nameof(WeeklySalesReport)}: {salesInThisWeekly} sales in last weekly.";
    }
}
