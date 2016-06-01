using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Abstract;

namespace sconnTester.Model.Test.Result
{
    public class TestResultSummary : ITestResultSummary
    {
        public Dictionary<IMeasurementTest, IMeasurementTestResult> GetResults()
        {
            return new Dictionary<IMeasurementTest, IMeasurementTestResult>();
        }

        public bool Success { get; set; }
    }
}
