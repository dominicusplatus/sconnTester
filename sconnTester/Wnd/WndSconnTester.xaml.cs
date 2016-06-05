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
using System.Windows.Shapes;
using Prism.Mef.Regions;
using Prism.Modularity;
using Prism.Regions;

namespace sconnTester.Wnd
{
    /// <summary>
    /// Interaction logic for WndSconnTester.xaml
    /// </summary>

    [Export]
    public partial class WndSconnTester : Window
    {
        public WndSconnTester(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
            InitializeComponent();
        }

        public IRegionManager RegionManager { get; private set; }


        public WndSconnTester()
        {
            RegionManager = new MefRegionManager();
            InitializeComponent();
        }

        [Import(AllowRecomposition = false)]
        public IModuleManager ModuleManager;
    }
}
