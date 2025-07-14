using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.UILayoutViewComponents
{
    public class MenuComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }
    }
}
