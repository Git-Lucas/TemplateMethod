namespace TemplateMethod.Data;
public static class SalesPerDay
{
    public static int GetSalesInOneDay()
    {
        return new Random().Next(maxValue: 200);
    }
}
