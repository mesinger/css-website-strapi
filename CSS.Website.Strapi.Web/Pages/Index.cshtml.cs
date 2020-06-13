using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using CSS.Website.Strapi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages
{
    public class IndexPageModel : PageModel
    {
        private readonly IHomePageDao _homePageDao;

        public IndexPageModel(IHomePageDao homePageDao)
        {
            _homePageDao = homePageDao;
        }

        public IEnumerable<Domain.Models.Achievement> FeaturedAchievements { get; private set; }
        public IEnumerable<Domain.Models.TeamMember> FeaturedTeamMembers { get; private set; }
        
        public async Task<ActionResult> OnGet()
        {
            FeaturedAchievements = await _homePageDao.GetFeaturedAchievements();
            FeaturedTeamMembers = await _homePageDao.GetFeaturedTeamMembers();

            return Page();
        }
    }
}