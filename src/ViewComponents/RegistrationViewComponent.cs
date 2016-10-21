using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EtnaDev.ViewComponents
{
    public class RegistrationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}