using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Regions;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using sconnTester.Model.Device;
using sconnTester.Model.Test;
using sconnTester.Model.Test.Tests;

namespace sconnTester.ViewModel
{

    [Export]
    public class TesterInstrumentStatusViewModel : BindableBase
    {
        public ObservableCollection<IMeasurementInstrument> Instruments { get; set; } 

        private readonly IRegionManager _regionManager;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        public ICommand RunTestsCommand { get; set; }

        private void RunTests()
        {
            //test instrument connections - discovery

        }

        private void SetupCmds()
        {
            RunTestsCommand = new DelegateCommand(RunTests);
        }

        public TesterInstrumentStatusViewModel()
        {
            SetupCmds();
            Instruments = new ObservableCollection<IMeasurementInstrument>();
        }


        [ImportingConstructor]
        public TesterInstrumentStatusViewModel(IRegionManager regionManager) : this()
        {
            this._regionManager = regionManager;
        }

    }


}
