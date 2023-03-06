using Newtonsoft.Json;

namespace Disneyverse.Data
{

    public class DisneyCharacterResponse
    {
        [JsonProperty("data")]
        public List<DisneyCharacter> Data { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("previousPage")]
        public string PreviousPage { get; set; }
    }
}
