using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Infrastracture;
using sconnTester.Model.Abstract;

namespace sconnTester.Service.UI.Stages
{
    [Export(typeof(ITestStageListService))]
    public class StaticLocalTestStageListService : ITestStageListService
    {
        private ObservableCollection<TestStageEntity> Tests { get; set; }

        public StaticLocalTestStageListService()
        {
            Tests = new ObservableCollection<TestStageEntity>();

            TestStageEntity statusStage = new TestStageEntity
            {
                ContractName = TesterViewContracts.TesterContractStatus,
                ImageUri = "pack://application:,,,/Images/config.png",
                Name = "Status"
            };
            Tests.Add(statusStage);

            TestStageEntity testingStage = new TestStageEntity
            {
                ContractName = TesterViewContracts.TesterContractTests,
                ImageUri = "pack://application:,,,/Images/tests.png",
                Name = "Testing"
            };
            Tests.Add(testingStage);


            TestStageEntity outputStage = new TestStageEntity
            {
                ContractName = TesterViewContracts.TesterContractOutput,
                ImageUri = "pack://application:,,,/Images/print.png",
                Name = "Output"
            };
            Tests.Add(outputStage);
        }

        public ObservableCollection<TestStageEntity> GetAll()
        {
            return Tests;
        }
    }
}
