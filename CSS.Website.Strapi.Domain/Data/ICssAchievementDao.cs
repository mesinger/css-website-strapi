using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Domain.Data
{
    /// <summary>
    /// Access to achievements shown on the css website
    /// </summary>
    public interface ICssAchievementDao
    {
        /// <summary>
        /// Retrieves a achievement by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Achievement?> GetById(string id);

        /// <summary>
        /// Retrieves all current achievements
        /// that should be featured on the css achievement page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Achievement>> GetAllForAchievementPage();
    }
}