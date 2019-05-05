using System;

namespace Monitoring
{
    public class Measurement
    {
        public int TagId { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Value { get; set; }
        public string OpcQuality { get; set; }
    }
}