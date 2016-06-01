using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.ViewModel;

namespace sconnTester.Infrastracture
{
    static public class TestStagingListProvider
    {
        static public ObservableCollection<TestStageEntity> GetTestStages()
        {
            //todo - load from config/service
            TestStageEntity statusStageEntity = new TestStageEntity();
            statusStageEntity.ContractName = "";
            statusStageEntity.Description = "Device initialization status";
            statusStageEntity.Name = "Status";
            statusStageEntity.ImageUri = "";

            TestStageEntity testlistStageEntity = new TestStageEntity();
            testlistStageEntity.ContractName = "";
            testlistStageEntity.Description = "";
            testlistStageEntity.Name = "Tests";
            testlistStageEntity.ImageUri = "";

            TestStageEntity outputStageEntity = new TestStageEntity();
            outputStageEntity.ContractName = "";
            outputStageEntity.Description = "";
            outputStageEntity.Name = "Output";
            outputStageEntity.ImageUri = "";

            ObservableCollection < TestStageEntity > stages = new ObservableCollection<TestStageEntity>();
            stages.Add(statusStageEntity);
            stages.Add(testlistStageEntity);
            stages.Add(outputStageEntity);
            return new ObservableCollection<TestStageEntity>();
        } 

    }
}
