using System;
using System.Collections.Generic;
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
using System.ComponentModel.Composition;
using System.Composition;
using sconnTester.View.Navigation;

namespace sconnRem.View.Config
{
    /// <summary>
    /// Interaction logic for ZoneConfig.xaml
    /// </summary>

    [Export(TesterRegionNames.AlarmConfig_Contract_ZoneConfigView)]
    public partial class ZoneConfigView : UserControl
    {
        [ImportingConstructor]
        public ZoneConfigView(AlarmZoneConfigViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
