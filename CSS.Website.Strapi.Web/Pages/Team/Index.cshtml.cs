using System.Collections.Generic;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using CSS.Website.Strapi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSS.Website.Strapi.Web.Pages.Team
{
    public class TeamIndexPageModel : PageModel
    {
        private readonly ICssTeamMemberDao _teamMemberDao;

        public TeamIndexPageModel(ICssTeamMemberDao teamMemberDao)
        {
            _teamMemberDao = teamMemberDao;
        }

        public IEnumerable<TeamMember> TeamMembers { get; private set; }

        public async Task<ActionResult> OnGet()
        {
            TeamMembers = await _teamMemberDao.GetAllForTeamMemberPage();
            return Page();
        }
    }
}