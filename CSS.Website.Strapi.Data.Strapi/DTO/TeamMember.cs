using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class TeamMember
    {
        [JsonProperty("team_member")] public TeamMemberInner Inner { get; set; }
        
        internal class TeamMemberInner
        {
            [JsonProperty("id")] public int Id { get; set; }
            [JsonProperty("first_name")] public string FirstName { get; set; }
            [JsonProperty("last_name")] public string LastName { get; set; }
            [JsonProperty("bio")] public string Bio { get; set; }
        }
    }
}