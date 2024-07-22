// See https://aka.ms/new-console-template for more information
using ReportBuilder.Src.Builders;
using ReportBuilder.Src.Directores;

Console.WriteLine("Hello, World!");
var builder = new HtmlReportBulder();
var reportGenerator = new ProfitReportGenerator(builder);


reportGenerator.Pars("fileP_ath");

builder.Build();