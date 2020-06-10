namespace CSS.Website.Strapi.Domain.Models
{
    // Represents an accomplishment (Leistung) on the css website
    public class Accomplishment
    {
        public Accomplishment(string name, string description, Teaser teaser)
        {
            Name = name;
            Description = description;
            Teaser = teaser;
        }

        public string Name { get; }
        public string Description { get; }
        public Teaser Teaser { get; }
    }
}