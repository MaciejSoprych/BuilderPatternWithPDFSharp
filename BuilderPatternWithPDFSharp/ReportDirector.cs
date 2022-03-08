using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWithPDFSharp
{
    public class ReportDirector
    {
        private readonly IReportBuilder _reportBuilder;
        public ReportDirector(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }
        public void BuildCompleteReport(string companyName, string legalForm)
        {
            _reportBuilder.AddTitle();
            _reportBuilder.AddAdminData(companyName, legalForm);
            _reportBuilder.AddAnswers();
        }
    }
}
