using Marvel.ApiClient.Responses;
using Newtonsoft.Json;

namespace Marvel.ApiClient.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Image { get; set; }

        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("comics")]
        public Comic Comics { get; set; }

        //[JsonProperty("data")]
        //public Series series { get; set; }
        //[JsonProperty("data")]

        //public Stories stories { get; set; }
        //[JsonProperty("data")]

        //public Events events { get; set; }
        //[JsonProperty("data")]

        //public List<Url> urls { get; set; }

    }
}
