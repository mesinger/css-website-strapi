using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class TeamPage
    {
        [JsonProperty("team_members")] public IEnumerable<TeamMember> TeamMembers { get; set; } = null!;
    }
}