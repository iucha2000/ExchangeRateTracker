using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeRateTracker.Models
{
    public class ResponseModel
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, RateAmount> Data { get; set; }
    }

    public class Meta
    {
        [JsonProperty("last_updated_at")]
        public DateTime LastUpdated { get; set; }
    }

    public class RateAmount
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("value")]
        public float Value { get; set; }
    }
}
