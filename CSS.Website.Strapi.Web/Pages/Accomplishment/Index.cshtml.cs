using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Dao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Accomplishment
{
    public class Index : PageModel
    {
        private readonly ICSSWebPageDao _webPageDao;

        public Index(ICSSWebPageDao webPageDao)
        {
            _webPageDao = webPageDao;
        }

        public string Description { get; private set; }
        public IEnumerable<Domain.Models.Accomplishment> Accomplishments { get; private set; }

        public async Task<ActionResult> OnGet()
        {
            Description = await _webPageDao.GetAccomplishmentPageDescription();
            Accomplishments = await _webPageDao.GetAccomplishmentsForAccomplishmentPage();

            return Page();
        }
    }
}