using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class TeamMember
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("first_name")] public string FirstName { get; set; } = null!;
        [JsonProperty("last_name")] public string LastName { get; set; } = null!;
        [JsonProperty("bio")] public string Bio { get; set; } = null!;
        [JsonProperty("teaser")] public Teaser Teaser { get; set; } = null!;
    }

    internal class TeamMemberComponent
    {
        [JsonProperty("__component")] public string ComponentName { get; set; } = null!;
        [JsonProperty("team_member")] public TeamMember Inner { get; set; } = null!;
    }
}