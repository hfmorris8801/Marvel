using Marvel.ApiClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marvel.ApiClient.Responses
{
    public class DataResponse
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<Character> Results { get; set; }
    }
}
