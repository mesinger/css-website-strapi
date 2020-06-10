namespace CSS.Website.Strapi.Domain.Models
{
    // Teaser representation for a accomplishment, team member etc.
    public class Teaser
    {
        public Teaser(string title, string description, string imageUrl)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
        }

        public string Title { get; }
        public string Description { get; }
        public string ImageUrl { get; }
    }
}