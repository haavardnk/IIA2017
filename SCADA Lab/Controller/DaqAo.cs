using NationalInstruments.DAQmx;

namespace Controller
{
    public class DaqAo
    {
        private readonly Task _analogOutTask = new Task();
        private AOChannel _myAoChannel;
        private readonly AnalogSingleChannelWriter _writer;

        public DaqAo(string channel)
        {
            _myAoChannel = _analogOutTask.AOChannels.CreateVoltageChannel(
                "dev3/"+channel,
                "myAOChannel",
                0,
                5,
                AOVoltageUnits.Volts
            );
            _writer = new AnalogSingleChannelWriter(_analogOutTask.Stream);

        }

        public void SetValue(double volt)
        {
            _writer.WriteSingleSample(true, volt);
        }
    }

}