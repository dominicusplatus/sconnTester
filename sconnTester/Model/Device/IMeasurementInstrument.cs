using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Service.Device;

namespace sconnTester.Model.Device
{
    public interface IMeasurementInstrument : IConfigurableInstrument
    {
         string Name { get; set; }
         MeasurementInstrumentType Type { get; set; }
         string Model { get; set; }
         string Revision { get; set; }
         string Serial { get; set; }
         string Id { get; set; }

        bool Connected();
        void Connect();
        void Setup();

    }
}
