using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
