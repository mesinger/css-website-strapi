using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Team
{
    public class TeamItemPageModel : PageModel
    {
        private readonly ICssTeamMemberDao _teamMemberDao;

        public TeamItemPageModel(ICssTeamMemberDao teamMemberDao)
        {
            _teamMemberDao = teamMemberDao;
        }

        public Domain.Models.TeamMember TeamMember { get; private set; }

        public async Task<ActionResult> OnGet(string id)
        {
            var teamMember = await _teamMemberDao.GetById(id);

            if (teamMember == null)
            {
                return NotFound();
            }

            TeamMember = teamMember;
            return Page();
        }
    }
}