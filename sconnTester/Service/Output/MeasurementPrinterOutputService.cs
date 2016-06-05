using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Test.Result;

namespace sconnTester.Service.Output
{

    [Export]
    public class MeasurementPrinterOutputService : ITestOutputService
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
