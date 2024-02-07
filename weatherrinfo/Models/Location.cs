using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace weatherrinfo.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string TzId { get; set; }
        [JsonPropertyName("localtime_epoch")]
        public long LocalTime_Epoch { get; set; }
        public string LocalTime { get; set; }

    }
}
