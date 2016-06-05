using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Test;
using sconnTester.Model.Test.Result;

namespace sconnTester.Service.Measurement
{
    public interface IMeasurementService
    {
        void RegisterTest(IMeasurementTest test);
        ITestResultSummary Run();
        Task<ITestResultSummary> RunAsync();
        bool Running { get; set; }
    }
}
