using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Abstract;

namespace sconnTester.Model.Test.Result
{

    public interface ITestResultSummary
    {
        Dictionary<IMeasurementTest, IMeasurementTestResult> GetResults();
        bool Success { get; set; }

    }

}
