using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.DefaultViewComponents
{
    public class DefaultAboutComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
