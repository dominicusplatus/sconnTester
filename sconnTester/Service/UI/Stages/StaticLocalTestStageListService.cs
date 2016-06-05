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
                ImageUri = "",
                Name = "Status"
            };
            Tests.Add(statusStage);
        }

        public ObservableCollection<TestStageEntity> GetAll()
        {
            return Tests;
        }
    }
}
