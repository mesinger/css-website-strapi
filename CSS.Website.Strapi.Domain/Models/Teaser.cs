namespace CSS.Website.Strapi.Domain.Models
{
    // Teaser representation for a accomplishment, team member etc.
    public class Teaser
    {
        public Teaser(string teaserTitle, string teaserDescription, string teaserImageUrl)
        {
            TeaserTitle = teaserTitle;
            TeaserDescription = teaserDescription;
            TeaserImageUrl = teaserImageUrl;
        }

        public string TeaserTitle { get; }
        public string TeaserDescription { get; }
        public string TeaserImageUrl { get; }
    }
}