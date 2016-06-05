using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Test.Result;
using System.ComponentModel.Composition;

namespace sconnTester.Service.Output
{

    [Export]
    public class MeasurementFileOutputService : ITestOutputService
    {
        public bool CanOutputResults()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }

        public Task OutputAsync()
        {
            throw new NotImplementedException();
        }

        public void ProcessResults(ITestResultSummary summary)
        {
            throw new NotImplementedException();
        }
    }
}
