namespace CSS.Website.Strapi.Domain.Models
{
    public class TeamMember : Teaser
    {
        public TeamMember(string id, string firstName, string lastName, string bio, string teaserTitle, string teaserDescription,
            string teaserImageUrl) : base(teaserTitle, teaserDescription, teaserImageUrl)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Bio = bio;
        }

        public TeamMember(string id, string firstName, string lastName, string bio) : base(string.Empty, string.Empty, string.Empty)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Bio = bio;
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Bio { get; }
    }
}