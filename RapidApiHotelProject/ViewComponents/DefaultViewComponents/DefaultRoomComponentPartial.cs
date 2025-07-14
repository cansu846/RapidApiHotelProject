using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.DefaultViewComponents
{
    public class DefaultRoomComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
