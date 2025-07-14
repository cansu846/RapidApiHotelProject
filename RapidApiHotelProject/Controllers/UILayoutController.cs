using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
