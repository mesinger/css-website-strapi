using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class AchievementPage
    {
        [JsonProperty("achievements")] public IEnumerable<Achievement> Achievements { get; set; } = null!;
    }
}