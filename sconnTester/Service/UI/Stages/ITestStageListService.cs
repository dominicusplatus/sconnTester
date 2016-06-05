using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Model.Abstract;

namespace sconnTester.Service.UI.Stages
{
    public interface ITestStageListService
    {
        ObservableCollection<TestStageEntity> GetAll();
    }

}
