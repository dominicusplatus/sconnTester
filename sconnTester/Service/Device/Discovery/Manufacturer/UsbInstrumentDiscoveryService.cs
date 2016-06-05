using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Service.Device
{
    public class UsbInstrumentDiscoveryService : IInstrumentDiscoveryService
    {
        public void Search()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public bool Searching { get; set; }
        public event EventHandler<InstrumentDiscoveryEventArgs> DeviceDiscovered;
    }
}
