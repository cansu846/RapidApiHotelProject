using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.UILayoutViewComponents
{
    public class _HeadLayoutComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }
    }
}
