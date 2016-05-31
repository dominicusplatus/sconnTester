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
            return new ObservableCollection<TestStageEntity>();
        } 

    }
}
