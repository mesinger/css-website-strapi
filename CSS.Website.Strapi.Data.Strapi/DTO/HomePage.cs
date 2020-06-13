using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class HomePage
    {
        [JsonProperty("featured_achievements")] public IEnumerable<Achievement> Achievements { get; set; }
        [JsonProperty("featured_team_members")] public IEnumerable<TeamMember> TeamMembers { get; set; }
    }
}