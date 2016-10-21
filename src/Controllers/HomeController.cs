using System;
using EtnaDev.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EtnaDev.Controllers 
{

    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public void Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO... registrazione
            }
            else throw new ArgumentException("model");
        }
    }

}