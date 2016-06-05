using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using sconnTester.Infrastracture;

namespace sconnTester.View.Navigation
{

    [ModuleExport(typeof(TesterTabbedNavigationModule))]
    public class TesterTabbedNavigationModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            this.RegionManager.RegisterViewWithRegion(TesterRegionNames.TestStageListRegionName, typeof(TesterStagedTabsNavigationListView));
        }
    }
    
}
