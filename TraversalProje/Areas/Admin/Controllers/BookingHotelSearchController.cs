using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TraversalProje.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task <IActionResult> Index()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?units=metric&dest_id=-1456928&dest_type=city&room_number=1&checkin_date=2024-05-19&order_by=popularity&locale=en-gb&adults_number=2&checkout_date=2024-05-20&filter_by_currency=EUR&page_number=0&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true"),
                Headers =
    {
        { "X-RapidAPI-Key", "dfa145565dmsh63d9f20ca4ebab1p1e0a81jsndea2436ae272" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodyReplace= body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
                return View (values.result);
            }
        }
    }
}
