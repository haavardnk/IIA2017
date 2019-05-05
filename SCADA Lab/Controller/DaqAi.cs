using NationalInstruments.DAQmx;

namespace Controller
{
    public class DaqAi
    {
        private readonly Task _analogInTask = new Task();
        private AIChannel _myAiChannel;
        private readonly AnalogSingleChannelReader _reader;

        public DaqAi(string channel)
        {
            _myAiChannel = _analogInTask.AIChannels.CreateVoltageChannel(
                "dev3/"+channel,
                "myAIChannel",
                AITerminalConfiguration.Differential,
                0,
                5,
                AIVoltageUnits.Volts
            );
            _reader = new AnalogSingleChannelReader(_analogInTask.Stream);

        }

        public double GetCelsiusValue()
        {
            var volt = _reader.ReadSingleSample();
            return (volt-1)/(5-1)*50;
        }

        public double GetVoltValue()
        {
            return _reader.ReadSingleSample();
        }
}
}