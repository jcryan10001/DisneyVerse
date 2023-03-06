using Newtonsoft.Json;

namespace Disneyverse.Data
{
    public class DisneyCharacter
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        public List<string> Films { get; set; }

        [JsonProperty("shortFilms")]
        public List<string> ShortFilms { get; set; }

        public List<string> TvShows { get; set; }

        public List<string> VideoGames { get; set; }

        public List<string> ParkAttractions { get; set; }

        public List<string> Allies { get; set; }

        public List<string> Enemies { get; set; }

        public string Url { get; set; }
    }
}
