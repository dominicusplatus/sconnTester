using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnTester.Model.Device
{

    public enum InstrumentParameterType
    {
        VoltageRange,
        CurrentLimit,
        FrequencyRange,
        ReferenceVoltage,
        SampleTime,
        TriggerMode,
        StartFreq,
        EndFreq,
        OvercurrentProt,
        ConstantVoltage,
        ConstantCurrent,
        BufferSize,
        Demodulation,
        SweepTime,
        ProbleScale,
        FunctionType,
        Offset,
        DutyCycle,
    }

    public interface IInstrumentParameter
    {
        string Name { get; set; }
        string Value { get; set; }
        InstrumentParameterType Type { get; set; }
    }

}
