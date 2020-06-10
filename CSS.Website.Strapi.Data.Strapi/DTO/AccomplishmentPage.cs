using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class AccomplishmentPage
    {
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("leistungen")] public IEnumerable<Accomplishment> Accomplishments { get; set; }
    }
}