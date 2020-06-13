using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Data.Strapi
{
    internal static class Mapping
    {
        public static Achievement ToDomain(this DTO.Achievement achievement) => new Achievement(
            achievement.Id.ToString(), achievement.Name, achievement.Description, achievement.Teaser.Title,
            achievement.Teaser.Description, achievement.Teaser.TeaserImage.Url);
        
        public static TeamMember ToDomain(this DTO.TeamMember teamMember) => new TeamMember(teamMember.Id.ToString(),
            teamMember.FirstName, teamMember.LastName, teamMember.Bio, teamMember.Teaser.Title,
            teamMember.Teaser.Description, teamMember.Teaser.TeaserImage.Url);
    }
}