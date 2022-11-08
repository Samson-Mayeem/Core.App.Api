using Microsoft.AspNetCore.Mvc;

namespace Core.App.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
