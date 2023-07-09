
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
        //Malumot olish uchun
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //Malumot berish ychun
        [HttpPost]
        public IActionResult Add(Sabzavot newsabzavot)
        {
            _request.Add(newsabzavot);
            return RedirectToAction("Index");
        }
    }
}
