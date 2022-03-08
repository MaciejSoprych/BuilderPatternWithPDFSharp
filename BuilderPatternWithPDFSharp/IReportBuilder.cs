using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWithPDFSharp
{
    public interface IReportBuilder
    {
        void AddTitle();
        void AddAdminData(string name, string legalForm);
        void AddAnswers();
    }
}
