using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Model.Device
{
    public interface IConfigurableInstrument
    {
        void Load(List<IInstrumentParameter> parameters);
    }

}
