using Microsoft.AspNetCore.Mvc;

namespace ToDoMusicOrganizer.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}