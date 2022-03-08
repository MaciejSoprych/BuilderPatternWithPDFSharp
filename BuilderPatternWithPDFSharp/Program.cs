using System;
using System.Collections.Generic;

namespace BuilderPatternWithPDFSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var answers = new List<Answer>
            {
                new Answer("Has the company seat in Poland", "Yes"),
                new Answer("Is the company subject to income tax in Poland", "No"),
            };
            string companyName = "Test";
            string legalForm = "Ltd";

            ReportBuilder reportBuilder = new ReportBuilder(answers);
            var reportDirector = new ReportDirector(reportBuilder);
            reportDirector.BuildCompleteReport(companyName, legalForm);
            var report = reportBuilder.GetReport();
            Console.WriteLine(report.Debug());
        }

       
    }
}
