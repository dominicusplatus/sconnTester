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
using sconnTester.Model.Test;
using sconnTester.Model.Test.Result;
using sconnTester.Model.Test.Tests;
using sconnTester.Service.Output;

namespace sconnTester.ViewModel
{

    [Export]
    public class TesterMeasurmentListViewModel : BindableBase
    {
        public ObservableCollection<IMeasurmentTestRecord> Measurements { get; set; }
        public IMeasurementTest Test { get; set; }

        private readonly IRegionManager _regionManager;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        public ICommand RunTestsCommand { get; set; }

        private void RunTests()
        {

        }

        private void SetupCmds()
        {
            RunTestsCommand = new DelegateCommand(RunTests);
        }

        public TesterMeasurmentListViewModel()
        {
            SetupCmds();
            Test = new BoardTestPointTest();
        }


        [ImportingConstructor]
        public TesterMeasurmentListViewModel(IRegionManager regionManager) : this()
        {
            this._regionManager = regionManager;
        }

    }

}
