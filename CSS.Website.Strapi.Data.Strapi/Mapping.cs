using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Data.Strapi
{
    internal static class Mapping
    {
        public static Accomplishment ToDomain(this DTO.Accomplishment accomplishment) => new Accomplishment(accomplishment.Name, accomplishment.Description, accomplishment.Teaser.ToDomain());
        public static Teaser ToDomain(this DTO.Teaser teaser) => new Teaser(teaser.Title, teaser.Description, teaser.TeaserImage.Url);
    }
}