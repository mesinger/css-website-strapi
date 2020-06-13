using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class Achievement
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; } = null!;
        [JsonProperty("description")] public string Description { get; set; } = null!;
        [JsonProperty("teaser")] public Teaser Teaser { get; set; } = null!;
    }

    internal class AchievementComponent
    {
        [JsonProperty("achievement")] public Achievement Inner { get; set; } = null!;
    }
}