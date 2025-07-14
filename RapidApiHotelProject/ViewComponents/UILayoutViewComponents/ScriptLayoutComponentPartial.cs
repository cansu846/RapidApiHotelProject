using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotelProject.ViewComponents.UILayoutViewComponents
{
    public class ScriptLayoutComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}