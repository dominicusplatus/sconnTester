using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using sconnTester.View.Navigation;

namespace sconnRem.View.Config.AlarmSystem.Zone
{
    [ModuleExport(typeof(ZoneConfigModule))]
    public class ZoneConfigModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            this.RegionManager.RegisterViewWithRegion(TesterRegionNames.MainNavigationRegion, typeof(ZoneConfigViewNavigationItem));
        }
    }

}
