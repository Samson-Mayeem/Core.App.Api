using Microsoft.AspNetCore.Mvc;

namespace Core.App.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
