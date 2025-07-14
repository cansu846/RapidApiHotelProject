using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiHotelProject.Dtos;
using RapidApiHotelProject.Models;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace RapidApiHotelProject.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        [HttpPost]
        public async Task<IActionResult> HotelDetails(HotelSearchViewModel model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels" +
                         $"?dest_id={model.DestinationId}" +
                         $"&arrival_date={model.ArrivalDate}" +
                         $"&departure_date={model.DepartureDate}" +
                         $"&adults={model.Adults}" +
                         $"&room_qty={model.RoomQty}" +
                         $"&units=metric" +
                         $"&children_age={model.ChildrenAge}" +
                         $"&temperature_unit=c" +
                         $"&languagecode=en-us&search_type=CITY"),
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
                    var values = JsonConvert.DeserializeObject<HotelDetailDto>(body);
                    return View(values);
                }
                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> VisitHotelDetail(/*int id, string arrival, string departure*/)
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
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails?hotel_id=191605&arrival_date=2025-07-15&departure_date=2025-07-17"),
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
                    var values = JsonConvert.DeserializeObject<VisitHotelDetailDto>(body);
                    return View(values);
                }
                return View();
            }
        }

    }
}

