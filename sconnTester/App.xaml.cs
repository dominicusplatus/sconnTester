using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using sconnTester.Bootstrap;
using sconnTester.Service.Measurement;
using sconnTester.Service.Output;

namespace sconnTester
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<IMeasurementService, MeasurementServiceSingleThreaded>();
            //container.RegisterType<ITestOutputService, MeasurementFileOutputService>();
            //container.RegisterType<ITestOutputService, MeasurementPrinterOutputService>();


            SconnTesterMainBootstrapper bootstrapper = new SconnTesterMainBootstrapper();
            bootstrapper.Run();
        }
    }
}
