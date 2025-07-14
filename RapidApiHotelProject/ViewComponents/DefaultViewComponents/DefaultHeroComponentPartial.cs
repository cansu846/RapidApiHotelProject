using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RapidApiHotelProject.Dtos;
using System.Net.Http.Headers;

namespace RapidApiHotelProject.ViewComponents.DefaultViewComponents
{
    public class DefaultHeroComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultHeroComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=turkey"),
                Headers =
    {
        { "x-rapidapi-key", "e432b5d933msh9b531a31af638f8p1eab76jsna14ba142e3e5" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                var values = JsonConvert.DeserializeObject<ResultDestinationDto>(body);
                ViewBag.cities = values.data.Select(x => new SelectListItem
                {
                    Text = x.city_name,
                    Value = x.dest_id.ToString()
                }).ToList();
            }


            return View();
        }
    }
}