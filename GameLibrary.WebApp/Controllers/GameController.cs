using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.WebApp.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
