using TemplateMethod.Data;

namespace TemplateMethod.DomainServices.SalesReport;
public class MonthlySalesReport : BaseSalesReport
{
    protected override string GenerateBody()
    {
        int salesInOneDay = SalesPerDay.GetSalesInOneDay();
        int salesInThisMonthly = salesInOneDay * DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

        return $"{nameof(MonthlySalesReport)}: {salesInThisMonthly} sales in last monthly.";
    }
}
