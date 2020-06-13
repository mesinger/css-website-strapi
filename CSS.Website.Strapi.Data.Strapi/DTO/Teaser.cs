using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi.DTO
{
    internal class Teaser
    {
        [JsonProperty("title")] public string Title { get; set; } = null!;
        [JsonProperty("description")] public string Description { get; set; } = null!;
        [JsonProperty("image")] public TeaserImage TeaserImage { get; set; } = null!;
    }

    internal class TeaserImage
    {
        [JsonProperty("url")] public string Url { get; set; } = null!;
    }
}