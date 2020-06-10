using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;

namespace CSS.Website.Strapi.Domain.Repository
{
    /// <summary>
    /// Retrieve accomplishments for the css website
    /// </summary>
    public interface ICSSWebPageRepository
    {
        /// <summary>
        /// Retrieve a accomplishment by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Accomplishment?> GetById(string id);
    }
}