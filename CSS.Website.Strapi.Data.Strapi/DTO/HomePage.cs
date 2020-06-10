using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class HomePage
    {
        [JsonProperty("subtitle")] public string SubTitle { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("leistungen")] public IEnumerable<Accomplishment> Accomplishments { get; set; }
    }
}