namespace Controller
{
    public class LowPassFilter
    {
        public double PreviousOutput { get; private set; }
        public double Tf { get; set; }

        public LowPassFilter(double tf, double initialValue)
        {
            Tf = tf;
            PreviousOutput = initialValue;
        }

        public double Filter(double y, double dt)
        {
            var output = (Tf / (Tf + dt)) * PreviousOutput + (dt / (dt + Tf)) * y;
            PreviousOutput = output;

            return output;
        }
    }
    
}