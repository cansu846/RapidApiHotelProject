using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiHotelProject.Dtos;
using RapidApiHotelProject.Models;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;


namespace RapidApiHotelProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                //  RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails?" +
                //  $"hotel_id={id}" +
                //  $"&arrival_date={arrival}" +
                //  $"&departure_date={departure}"
                //),
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/getRoomList?hotel_id=74717&arrival_date=2025-07-15&departure_date=2025-07-19"),
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
                if (response.IsSuccessStatusCode)
                {
                    var values = JsonConvert.DeserializeObject<VisitRoomDetailDto>(body);
                    return View(values);
                }
                return View();
            }
        }
    }
    }

