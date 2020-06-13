using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Achievement
{
    public class AchievementIndexPageModel : PageModel
    {
        private readonly ICssAchievementDao _achievementDao;

        public AchievementIndexPageModel(ICssAchievementDao achievementDao)
        {
            _achievementDao = achievementDao;
        }

        public IEnumerable<Domain.Models.Achievement> Achievements { get; private set; }
        
        public async Task<ActionResult> OnGet()
        {
            Achievements = await _achievementDao.GetAllForAchievementPage();
            return Page();
        }
    }
}