using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Dao;
using CSS.Website.Strapi.Domain.Models;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi
{
    public class StrapiCSSWebPageDao : ICSSWebPageDao
    {
        private readonly HttpClient _client;

        public StrapiCSSWebPageDao(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetAccomplishmentPageDescription()
        {
            var response = await _client.GetAsync("http://localhost:1337/leistung-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var accomplishmentPage = JsonConvert.DeserializeObject<DTO.AccomplishmentPage>(responseContent);

                if (accomplishmentPage == null)
                {
                    return string.Empty;
                }

                return accomplishmentPage.Description;
            }

            return string.Empty;
        }

        public async Task<IEnumerable<Accomplishment>> GetAccomplishmentsForAccomplishmentPage()
        {
            var response = await _client.GetAsync("http://localhost:1337/leistung-page");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var accomplishmentPage = JsonConvert.DeserializeObject<DTO.AccomplishmentPage>(responseContent);

                if (accomplishmentPage == null)
                {
                    return Enumerable.Empty<Accomplishment>();
                }

                return accomplishmentPage.Accomplishments.Select(accomplishment => accomplishment.ToDomain());
            }

            return Enumerable.Empty<Accomplishment>();
        }

        public async Task<string> GetHomePageDescription()
        {
            var response = await _client.GetAsync("http://localhost:1337/home");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var homePage = JsonConvert.DeserializeObject<DTO.HomePage>(responseContent);

                if (homePage == null)
                {
                    return string.Empty;
                }

                return homePage.Description;
            }

            return string.Empty;
        }

        public async Task<IEnumerable<Accomplishment>> GetAccomplishmentsForHomePage()
        {
            var response = await _client.GetAsync("http://localhost:1337/home");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var homePage = JsonConvert.DeserializeObject<DTO.HomePage>(responseContent);

                if (homePage == null)
                {
                    return Enumerable.Empty<Accomplishment>();
                }

                return homePage.Accomplishments.Select(accomplishment => accomplishment.ToDomain());
            }

            return Enumerable.Empty<Accomplishment>();
        }
    }
}