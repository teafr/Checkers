using Microsoft.AspNetCore.Mvc;

namespace CheckersGame.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
