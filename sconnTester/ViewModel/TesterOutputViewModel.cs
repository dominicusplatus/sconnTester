using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using sconnTester.Infrastracture;
using sconnTester.Model.Test.Result;
using sconnTester.Service.Output;

namespace sconnTester.ViewModel
{
   

    [Export]
    public class TesterOutputViewModel : BindableBase
    {
        public ObservableCollection<ITestResultSummary> Results { get; set; }
        public ITestOutputService Service { get; set; }

        private readonly IRegionManager _regionManager;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        public ICommand GenerateOutputCommand { get; set; }

        private void GenerateOutput()
        {

        }

        private void SetupCmds()
        {
            GenerateOutputCommand = new DelegateCommand(GenerateOutput);
        }

        public TesterOutputViewModel()
        {
            SetupCmds();
            Results = new ObservableCollection<ITestResultSummary>();
        }


        [ImportingConstructor]
        public TesterOutputViewModel(IRegionManager regionManager) : this()
        {
            this._regionManager = regionManager;
        }

    }


}
