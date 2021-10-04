using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.ApiClient.Responses
{
    public class Comic
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("CollectionURI")]
        public string collectionURI { get; set; }

        //[JsonProperty("offset")]
        //public List<Item> items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }
}
