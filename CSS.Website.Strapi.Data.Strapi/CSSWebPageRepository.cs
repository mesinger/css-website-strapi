using System.Net.Http;
using System.Threading.Tasks;
using CSS.Website.Strapi.Domain.Models;
using CSS.Website.Strapi.Domain.Repository;
using Newtonsoft.Json;

namespace CSS.Website.Strapi.Data.Strapi
{
    public class CSSWebPageRepository : ICSSWebPageRepository
    {
        private readonly HttpClient _client;

        public CSSWebPageRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<Accomplishment?> GetById(string id)
        {
            var response = await _client.GetAsync($"http://localhost:1337/leistungs/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var accomplishment = JsonConvert.DeserializeObject<DTO.Accomplishment>(responseContent);

                return accomplishment.ToDomain();
            }

            return null;
        }
    }
}