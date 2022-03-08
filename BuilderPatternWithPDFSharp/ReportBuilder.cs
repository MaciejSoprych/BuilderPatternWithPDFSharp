using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWithPDFSharp
{
    public class ReportBuilder : IReportBuilder
    {
        private Report _report;
        
        private readonly List<Answer> _answers;

        public ReportBuilder(List<Answer> answers)
        {
            Reset();
            _answers = answers;
        }

        public void AddTitle()
        {
            _report.Title = "Does your company meet RECO definition";
        }
        public void AddAdminData(string name, string legalForm)
        {
          _report.AdminData = String.Join(Environment.NewLine, $"Company name: {name} \n Legal form: {legalForm}\n");
        }

        public void AddAnswers()
        {
            _report.Answers = String.Join(Environment.NewLine, _answers.Select(i => $"Qeustion: {i.Question} \n Answer: {i.UserAnswer}\n"));
        }

        public Report GetReport()
        {
            Report finishedReport = _report;
            Reset();
            return finishedReport;
        }

        public void Reset()
        {
            _report = new Report();
        }
  
    }
}
