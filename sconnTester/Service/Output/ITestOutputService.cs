using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Test.Result;

namespace sconnTester.Service.Output
{

    public interface ITestOutputService
    {
        bool CanOutputResults();
        void Output();
        Task OutputAsync();
        void ProcessResults(ITestResultSummary summary);
        
    }

}
