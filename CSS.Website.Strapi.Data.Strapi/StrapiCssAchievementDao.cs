using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Data;
using CSS.Website.Strapi.Domain.Models;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi
{
    public class StrapiCssAchievementDao : ICssAchievementDao
    {
        private readonly HttpClient _httpClient;

        public StrapiCssAchievementDao(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Achievement?> GetById(string id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/achievements/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var achievement = JsonConvert.DeserializeObject<DTO.Achievement>(responseContent);

                return achievement.ToDomain();
            }

            return null;
        }

        public async Task<IEnumerable<Achievement>> GetAllForAchievementPage()
        {
            var response = await _httpClient.GetAsync($"http://localhost:1337/achievement-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var page = JsonConvert.DeserializeObject<DTO.AchievementPage>(responseContent);

                return page.Achievements.Select(achievement => achievement.ToDomain());
            }

            return Enumerable.Empty<Achievement>();
        }
    }
}