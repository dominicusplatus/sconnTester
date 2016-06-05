using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Abstract;

namespace sconnTester.Model.Test.Result
{
    [Export(typeof(ITestResultSummary))]
    public class BasicTestResultSummary : ITestResultSummary
    {
        public Dictionary<IMeasurementTest, IMeasurementTestResult> GetResults()
        {
            throw new NotImplementedException();
        }

        public bool Success { get; set; }
    }
}
