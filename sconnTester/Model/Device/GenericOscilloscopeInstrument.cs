using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnTester.Service.Device;

namespace sconnTester.Model.Device
{
    public abstract class GenericOscilloscopeInstrument : IMeasurementInstrument
    {
        public void Load(List<IInstrumentParameter> parameters)
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public MeasurementInstrumentType Type { get; set; }
        public string Model { get; set; }
        public string Revision { get; set; }
        public string Serial { get; set; }
        public string Id { get; set; }
        public bool Connected()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }
    }
}
