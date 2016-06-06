using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NLog;
using Prism.Regions;
using sconnTester.Infrastracture;
using sconnTester.ViewModel;
using sconnTester.ViewModel.Instrument;

namespace sconnTester.View.Instruments.Live.Instruments
{
    /// <summary>
    /// Interaction logic for SpectrumAnalyzerInstrumentLiveDataView.xaml
    /// </summary>



    [Export(TesterViewContracts.TesterContractData)]
    [ViewSortHint("01")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class SpectrumAnalyzerInstrumentLiveDataView : UserControl
    {


        [Import]
        public IRegionManager RegionManager;

        public SpectrumAnalyzerInstrumentLiveDataView()
        {
            InitializeComponent();
        }


        [ImportingConstructor]
        public SpectrumAnalyzerInstrumentLiveDataView(InstrumentSpectrumAnalyzerLiveViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }

    }
}
