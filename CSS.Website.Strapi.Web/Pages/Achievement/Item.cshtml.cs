using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Achievement
{
    public class AchievementItemPageModel : PageModel
    {
        private readonly ICssAchievementDao _achievementDao;

        public AchievementItemPageModel(ICssAchievementDao achievementDao)
        {
            _achievementDao = achievementDao;
        }

        public Domain.Models.Achievement Achievement { get; private set; }

        public async Task<ActionResult> OnGet(string id)
        {
            var achievement = await _achievementDao.GetById(id);

            if (achievement == null)
            {
                return NotFound();
            }

            Achievement = achievement;
            return Page();
        }
    }
}