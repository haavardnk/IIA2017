using System.Collections.Generic;

namespace Monitoring
{
    public class Tag
    {
        //Columns in TAG table from database
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string Description { get; set; }
        public double Zero { get; set; }
        public double Span { get; set; }
        public double AlarmLimit { get; set; }

        //A list of all measurements in history table in database
        public List<Measurement> History { get; set; }

    }
}
    