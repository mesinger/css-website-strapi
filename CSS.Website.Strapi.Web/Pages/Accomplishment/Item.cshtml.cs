using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Accomplishment
{
    public class Item : PageModel
    {
        private readonly ICSSWebPageRepository _webPageRepository;

        public Item(ICSSWebPageRepository webPageRepository)
        {
            _webPageRepository = webPageRepository;
        }

        public Domain.Models.Accomplishment Accomplishment { get; private set; }

        public async Task<ActionResult> OnGet(string id)
        {
            var accomplishment = await _webPageRepository.GetById(id);

            if (accomplishment == null)
            {
                return NotFound();
            }

            Accomplishment = accomplishment;
            return Page();
        }
    }
}