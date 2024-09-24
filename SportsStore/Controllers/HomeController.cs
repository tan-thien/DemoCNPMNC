using Microsoft.AspNetCore.Mvc;
namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Home() => View();
        public IActionResult register() => View();
        public IActionResult login() => View();
        public IActionResult detailProject() => View();
    }
}
