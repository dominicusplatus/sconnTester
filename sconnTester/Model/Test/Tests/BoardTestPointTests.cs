using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Model.Test.Tests
{

    [Export(typeof(IMeasurementTest))]
    public class BoardTestPointTest : IMeasurementTest
    {
        public void Run()
        {
           
        }

        public List<IMeasurmentTestRecord> Tests { get; set; }
        public bool Running { get; set; }
        public bool Success { get; set; }

        public BoardTestPointTest()
        {
                
        }

    }
}
