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
using sconnTester.Model.Abstract;
using sconnTester.Service.UI.Stages;

namespace sconnTester.ViewModel
{
    


    [Export]
    public class TesterStagesListViewModel : BindableBase
    {
        public ObservableCollection<TestStageEntity> Stages { get; set; }
        private readonly IRegionManager _regionManager;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();
        public ITestStageListService Service { get; set; }

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
            Stages = new ObservableCollection<TestStageEntity>();   // TestStagingListProvider.GetTestStages(); 
        }


        [ImportingConstructor]
        public TesterStagesListViewModel(IRegionManager regionManager, ITestStageListService service) :this()
        {
            this._regionManager = regionManager;
            Service = service;
            Stages = Service.GetAll();
        }
        
    }

}
