using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.DefaultViewComponents
{
    public class DefaultServiceComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
