using System;
using System.Collections.Generic;
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
using Prism.Regions;
using sconnTester.Infrastracture;
using sconnTester.Model.Test;
using sconnTester.Model.Test.Result;

namespace sconnTester.View
{
    /// <summary>
    /// Interaction logic for DutMeasurementsListView.xaml
    /// </summary>

    [Export(TesterViewContracts.TesterContractTests)]
    [ViewSortHint("01")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class DutMeasurementsListView : UserControl
    {
        [Import]
        public IRegionManager RegionManager;

        public DutMeasurementsListView()
        {
            InitializeComponent();
        }


        [ImportingConstructor]
        public DutMeasurementsListView(IMeasurementTest viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }

    }

}
