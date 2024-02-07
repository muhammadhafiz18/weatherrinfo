using System.Text.Json.Serialization;

namespace weatherrinfo.Models
{
    public class Current
    {
        [JsonPropertyName("last_updated_epoch")]
        public long LastUpdatedEpoch { get; set; }
        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }
        [JsonPropertyName("temp_c")]
        public decimal TempC { get; set; }
        [JsonPropertyName("temp_f")]
        public decimal Tempf { get; set; }
        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }
        public Condition Condition { get; set; }
        [JsonPropertyName("wind_mph")]
        public decimal WindMph { get; set; }
        [JsonPropertyName("wind_kph")]
        public decimal WindKph { get; set; }
        [JsonPropertyName("wind_degree")]
        public decimal WindDegree { get; set; }
        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; }
        [JsonPropertyName("pressure_mb")]
        public decimal PressureMb { get; set; }
        [JsonPropertyName("pressure_in")]
        public decimal PressureIn { get; set; }
        [JsonPropertyName("precip_mm")]
        public decimal PrecipMm { get; set; }
        [JsonPropertyName("precip_in")]
        public decimal PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        [JsonPropertyName("feelslike_c")]
        public decimal FellslikeC { get; set; }
        [JsonPropertyName("feelslike_f")]
        public decimal FellslikeF { get; set; }
        [JsonPropertyName("vis_km")]
        public decimal VisKm { get; set; }
        [JsonPropertyName("vis_miles")]
        public decimal VisMiles { get; set; }
        public decimal Uv { get; set; }
        [JsonPropertyName("gust_mph")]
        public decimal GustMph { get; set; }
        [JsonPropertyName("gust_kph")]
        public decimal GustKph { get; set; }
    }
}
