using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using CSS.Website.Strapi.Domain.Models;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi
{
    public class StrapiCssPageDao : IHomePageDao
    {
        private readonly HttpClient _httpClient;
        private readonly ICssAchievementDao _achievementDao;
        private readonly ICssTeamMemberDao _teamMemberDao;

        public StrapiCssPageDao(HttpClient httpClient, ICssAchievementDao achievementDao, ICssTeamMemberDao teamMemberDao)
        {
            _httpClient = httpClient;
            _achievementDao = achievementDao;
            _teamMemberDao = teamMemberDao;
        }

        public async Task<IEnumerable<Achievement>> GetFeaturedAchievements()
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/home-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var page = JsonConvert.DeserializeObject<DTO.HomePage>(responseContent);

                var achievementIds = page?.Achievements.Select(achievement => achievement.Inner.Id) ?? Enumerable.Empty<int>();
                return achievementIds.Select(async id => await _achievementDao.GetById(id.ToString())).Select(t => t.Result).Where(a => a != null)!;
            }

            return Enumerable.Empty<Achievement>();
        }

        public async Task<IEnumerable<TeamMember>> GetFeaturedTeamMembers()
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/home-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var page = JsonConvert.DeserializeObject<DTO.HomePage>(responseContent);

                var teamMemberIds = page?.TeamMembers.Select(teamMember => teamMember.Inner.Id) ?? Enumerable.Empty<int>();
                return teamMemberIds.Select(async id => await _teamMemberDao.GetById(id.ToString())).Select(t => t.Result).Where(a => a != null)!;
            }

            return Enumerable.Empty<TeamMember>();
        }
    }
}