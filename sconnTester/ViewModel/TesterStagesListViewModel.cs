using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using sconnTester.Infrastracture;

namespace sconnTester.ViewModel
{

    public class TestStageEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public string ContractName { get; set; }
    }

    [Export]
    public class TesterStagesListViewModel : BindableBase
    {
        public ObservableCollection<TestStageEntity> Stages { get; set; }
        private readonly IRegionManager _regionManager;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        public ICommand ShowStageCommand { get; set; }

        private void ShowStage(TestStageEntity entity)
        {
            
        }

        private void SetupCmds()
        {
            ShowStageCommand = new DelegateCommand<TestStageEntity>(ShowStage);
        }

        public TesterStagesListViewModel()
        {
            SetupCmds();
            Stages = TestStagingListProvider.GetTestStages();    //new ObservableCollection<TestStageEntity>();
        }


        [ImportingConstructor]
        public TesterStagesListViewModel(IRegionManager regionManager) :this()
        {
            this._regionManager = regionManager;
        }

    }

}
