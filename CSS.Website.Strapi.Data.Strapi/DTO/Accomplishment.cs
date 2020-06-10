using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class Accomplishment
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("teaser")] public Teaser Teaser { get; set; }
    }
}