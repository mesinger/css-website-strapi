using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class HomePage
    {
        [JsonProperty("featured_achievements")] public IEnumerable<AchievementComponent> Achievements { get; set; } = null!;
        [JsonProperty("featured_team_members")] public IEnumerable<TeamMemberComponent> TeamMembers { get; set; } = null!;
    }
}