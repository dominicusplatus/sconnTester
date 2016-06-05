using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Model.Abstract
{


    public class TestStageEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public string ContractName { get; set; }
    }

    interface ITestStageEntity
    {
    }
}
