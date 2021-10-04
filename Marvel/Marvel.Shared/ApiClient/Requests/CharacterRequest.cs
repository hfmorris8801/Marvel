using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.ApiClient.Requests
{
    public class CharacterRequest
    {
        [JsonProperty("characterid")]
        public string CharacterId { get; set; }

    }
}
