using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.ApiClient.Models
{
    public class Thumbnail
    {
        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
