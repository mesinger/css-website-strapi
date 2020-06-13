using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Domain.Data
{
    /// <summary>
    /// Access to css team members
    /// </summary>
    public interface ICssTeamMemberDao
    {
        /// <summary>
        /// Retrieves a team member by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TeamMember?> GetById(string id);

        /// <summary>
        /// Retrieves all team members that shall be
        /// shown on the team member page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TeamMember>> GetAllForTeamMemberPage();
    }
}