using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Test;
using sconnTester.Model.Test.Result;

namespace sconnTester.Service.Measurement
{

    [Export]
    public class MeasurementServiceSingleThreaded : IMeasurementService
    {
        public void RegisterTest(IMeasurementTest test)
        {
            throw new NotImplementedException();
        }

        public ITestResultSummary Run()
        {
            throw new NotImplementedException();
        }

        public Task<ITestResultSummary> RunAsync()
        {
            throw new NotImplementedException();
        }

        public bool Running { get; set; }
    }
}
