using Newtonsoft.Json;

namespace Marvel.ApiClient.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Image { get; set; }
    }
}
