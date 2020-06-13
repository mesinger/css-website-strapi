using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Data.Strapi
{
    internal static class Mapping
    {
        public static Achievement ToDomain(this DTO.Achievement achievement) => new Achievement(
            achievement.Id.ToString(), achievement.Name, achievement.Description, achievement.Teaser.Title,
            achievement.Teaser.Description, achievement.Teaser.TeaserImage.Url);
    }
}