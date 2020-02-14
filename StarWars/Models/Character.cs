using System;
using Newtonsoft.Json;

namespace StarWars.Models {
    public class Character {

        [JsonProperty("birth")]
        public string Birth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("planet")]
        public string Planet { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }
    }
}
