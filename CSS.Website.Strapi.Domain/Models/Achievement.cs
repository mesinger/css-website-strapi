namespace CSS.Website.Strapi.Domain.Models
{
    // Represents an accomplishment (Leistung) on the css website
    public class Achievement : Teaser
    {
        public Achievement(string id, string name, string description, string teaserTitle, string teaserDescription,
            string teaserImageUrl) : base(teaserTitle, teaserDescription, teaserImageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Achievement(string id, string name, string description) : base(string.Empty, string.Empty, string.Empty)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}