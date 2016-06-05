using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using NLog;
using Prism.Mef;
using sconnTester.Wnd;

namespace sconnTester.Bootstrap
{
    public interface IVerifiableBootstraper
    {
        CompositionContainer GetContainer();
        AggregateCatalog GetAggregateCatalog();
    }

    public class MvvmLogger : ILoggerFacade
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public void Log(string message, Category category, Priority priority)
        {
            string messageToLog =
                String.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "{1}: {2}. Priority: {3}. Timestamp:{0:u}.",
                    DateTime.Now,
                    category.ToString().ToUpperInvariant(),
                    message,
                    priority.ToString());

            _logger.Error(messageToLog);
        }
    }



    public class SconnTesterMainBootstrapper : MefBootstrapper, IVerifiableBootstraper
    {
        
        private Logger _nlogger = LogManager.GetCurrentClassLogger();


        protected override ILoggerFacade CreateLogger()
        {
            return new MvvmLogger();

        }

        protected override void ConfigureAggregateCatalog()
        {
            try
            {
                base.ConfigureAggregateCatalog();
                this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(WndSconnTester).Assembly));
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
        
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<WndSconnTester>();
        }

        protected override void InitializeShell()
        {
            try
            {
                base.InitializeShell();
                Application.Current.MainWindow = (Window)this.Shell;
                Application.Current.MainWindow.Show();
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }

        }

        public CompositionContainer GetContainer()
        {
            return this.Container;
        }

        public AggregateCatalog GetAggregateCatalog()
        {
            return this.AggregateCatalog;
        }
    }



}
