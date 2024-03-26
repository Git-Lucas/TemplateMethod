using TemplateMethod.DomainServices.SalesReport;
using TemplateMethod.UseCases;

GeneratorSalesReport generatorSalesReport = new();

Console.WriteLine(generatorSalesReport.Execute(new DailySalesReport()));
Console.WriteLine(generatorSalesReport.Execute(new WeeklySalesReport()));
Console.WriteLine(generatorSalesReport.Execute(new MonthlySalesReport()));