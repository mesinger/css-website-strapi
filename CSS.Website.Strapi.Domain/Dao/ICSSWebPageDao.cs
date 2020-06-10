using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Domain.Dao
{
    /// <summary>
    /// Provides access that gets presented on the css website
    /// </summary>
    public interface ICSSWebPageDao
    {
        /// <summary>
        /// Retrieves the description shown on the accomplishment page
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccomplishmentPageDescription();
        
        /// <summary>
        /// Retrieves all accomplishments that are shown on the accomplishment page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Accomplishment>> GetAccomplishmentsForAccomplishmentPage();
        
        /// <summary>
        /// Retrieves the description shown on the home page
        /// </summary>
        /// <returns></returns>
        Task<string> GetHomePageDescription();
        
        /// <summary>
        /// Retrieves all accomplishments that are shown on the home page
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Accomplishment>> GetAccomplishmentsForHomePage();
    }
}