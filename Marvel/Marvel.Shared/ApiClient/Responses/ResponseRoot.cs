﻿using Newtonsoft.Json;

namespace Marvel.ApiClient.Responses
{
    public class ResponseRoot
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("attributionText")]
        public string AttributionText { get; set; }

        [JsonProperty("attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("data")]
        public DataResponse Data { get; set; }
    }
}
