using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Abstract;

namespace sconnTester.Model.Test.Result
{
    
    [Export(typeof(IMeasurementTestResult))]
    public class BasicTestResult :IMeasurementTestResult
    {
        public double Value { get; set; }
        public double Elapsed { get; set; }
    }
}
