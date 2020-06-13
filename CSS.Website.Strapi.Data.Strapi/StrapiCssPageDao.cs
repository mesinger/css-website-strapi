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

        public StrapiCssPageDao(HttpClient httpClient, ICssAchievementDao achievementDao)
        {
            _httpClient = httpClient;
            _achievementDao = achievementDao;
        }

        public async Task<IEnumerable<Achievement>> GetFeaturedAchievements()
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/home-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var page = JsonConvert.DeserializeObject<DTO.HomePage>(responseContent);

                var achievementIds = page?.Achievements.Select(achievement => achievement.Id) ?? Enumerable.Empty<int>();
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

                return Enumerable.Empty<TeamMember>();
            }

            return Enumerable.Empty<TeamMember>();
        }
    }
}