using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EtnaDev.Components
{
    public class RegistrationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}