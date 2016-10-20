using Microsoft.AspNetCore.Mvc;

namespace EtnaDev.Controllers 
{

    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }

}