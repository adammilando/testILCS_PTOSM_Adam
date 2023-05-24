using System.Collections.Generic;

namespace MonitoringTruck.Models
{
    public class Result
    {
        public int recordsFiltered { get; set; }
        public List<Datum> data { get; set; }
        public int draw { get; set; }
        public int recordsTotal { get; set; }
    }
}
