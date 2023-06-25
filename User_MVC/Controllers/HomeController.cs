
using Microsoft.AspNetCore.Mvc;

using User_MVC.Models;
using User_MVC.Services;

namespace User_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISabzavodInterface _request;
        public HomeController(ISabzavodInterface request)
        {
            _request = request;
        }

        public IActionResult Sabzavot()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_request.GetAllsabz());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Sabzavot newsabzavot)
        {
            return View(newsabzavot);
        }
    }
}