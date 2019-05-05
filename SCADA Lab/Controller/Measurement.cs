using System;

namespace Controller
{
    public class Measurement
    {
        public double SetPoint { get; set; }
        public double u { get; set; }
        public double y { get; set; }

        public DateTime Time { get; set; }

        public Measurement(double setPoint, double u, double y)
        {
            SetPoint = setPoint;
            this.u = u;
            this.y = y;
            Time = DateTime.Now;
        }
    }
}