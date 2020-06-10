using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class Teaser
    {
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("image")] public TeaserImage TeaserImage { get; set; }
    }

    internal class TeaserImage
    {
        [JsonProperty("url")] public string Url { get; set; }
    }
}