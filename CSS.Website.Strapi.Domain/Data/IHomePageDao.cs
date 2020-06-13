using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Domain.Data
{
    /// <summary>
    /// Access to data shown on the web page
    /// </summary>
    public interface IHomePageDao
    {
        /// <summary>
        /// Retrieves the featured achievements shown on the home page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Achievement>> GetFeaturedAchievements();
        
        /// <summary>
        /// Retrieves the featured team members shown on the home page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TeamMember>> GetFeaturedTeamMembers();
    }
}