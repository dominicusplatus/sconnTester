using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Service.Device
{
    public enum MeasurementInstrumentType
    {
        Oscilloscope,
        ProgrammableSupply,
        Multimeter,
        SpectrumAnalyzer,
        Thermocouple,
        ArbitraryFunctionGenerator,
        Ammeter,
        ProgrammableLoad,
        RfGenerator,
        VNA
    }

    public class InstrumentDiscoveryEventArgs
    {
        public string Name { get; set; }
        public MeasurementInstrumentType Type { get; set; }
        public string Model { get; set; }
        public string Revision { get; set; }
        public string Serial { get; set; }
        public string Id { get; set; }
    }

    public interface IInstrumentDiscoveryService
    {
        void Search();
        void Stop();
        bool Searching { get; set; }
        event EventHandler<InstrumentDiscoveryEventArgs> DeviceDiscovered;

    }
}
