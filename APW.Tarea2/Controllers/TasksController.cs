using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
