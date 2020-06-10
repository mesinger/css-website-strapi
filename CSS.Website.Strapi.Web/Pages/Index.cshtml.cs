using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Dao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CSS.Website.Strapi.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICSSWebPageDao _webPageDao;

        public IndexModel(ILogger<IndexModel> logger, ICSSWebPageDao webPageDao)
        {
            _logger = logger;
            _webPageDao = webPageDao;
        }

        public string Description { get; private set; }
        public IEnumerable<Domain.Models.Accomplishment> FeaturedAccomplishments { get; private set; }

        public async Task<ActionResult> OnGet()
        {
            Description = await _webPageDao.GetHomePageDescription();
            FeaturedAccomplishments = await _webPageDao.GetAccomplishmentsForHomePage();

            return Page();
        }
    }
}