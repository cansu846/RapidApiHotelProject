using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.UILayoutViewComponents
{
    public class FooterLayoutComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }
    }
}
