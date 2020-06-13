using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using CSS.Website.Strapi.Domain.Models;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi
{
    public class StrapiCssTeamMemberDao : ICssTeamMemberDao
    {
        private readonly HttpClient _httpClient;

        public StrapiCssTeamMemberDao(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TeamMember?> GetById(string id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/team-members/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var teamMember = JsonConvert.DeserializeObject<DTO.TeamMember>(responseContent);

                return teamMember?.ToDomain();
            }

            return null;
        }

        public async Task<IEnumerable<TeamMember>> GetAllForTeamMemberPage()
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/team-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var page = JsonConvert.DeserializeObject<DTO.TeamPage>(responseContent);

                return page.TeamMembers.Select(teamMember => teamMember.ToDomain());
            }

            return Enumerable.Empty<TeamMember>();
        }
    }
}