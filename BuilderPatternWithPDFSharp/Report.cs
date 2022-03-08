using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWithPDFSharp
{
    public class Report
    {
        public string Title { get; set; }
        public string AdminData { get; set; }
        public string Answers { get; set; }

        public string Debug()
        {
            return new StringBuilder()
                .AppendLine(Title)
                .AppendLine(AdminData)
                .AppendLine(Answers)
                .ToString();
        }

    }
    public class AdminData
    {
        public string CompanyName { get; set; }
        public string LegalForm { get; set; }
        
    }
    public class Answer
    {
        public Answer(string question, string userAnswer)
        {
            Question = question;
            UserAnswer = userAnswer;
        }

        public string Question { get; set; }
        public string UserAnswer { get; set; }
    }
}
