using Microsoft.AspNetCore.Mvc;

namespace Dino.Controllers
{
    public class HomeController : Controller
    {

         [HttpGet("/")]
        // public ActionResult Index()
        // {
        //     return View();
        // }

        public ActionResult Index()
        {
          return View();
        }


    }
}
