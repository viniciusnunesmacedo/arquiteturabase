using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaBase.UI.Site.Angular.Controllers
{
    public class AppController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
