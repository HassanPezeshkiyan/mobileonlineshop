using Microsoft.AspNetCore.Mvc;
using OnlineMobileShop.Models;
using System.Diagnostics;

namespace OnlineMobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static DB db = new DB();
        public static List<Phone> list = new List<Phone>();
        public static List<Category> categories= new List<Category>();  


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.PhoneList = "";
            ViewBag.Categories = "";
            db.AddCategories();
            db.AddData();
            list = db.phones;
            categories= db.categories;
            ViewBag.PhoneList = list;
            ViewBag.Categories = categories;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult PhoneList(int Id)
        {

            var newlist = list.Where(e => e.CategoryId == Id).ToList();
            ViewBag.List = newlist;
            return View();
        }


        public IActionResult PhoneDetail(int Id)
        {
            var phone = list.Where(e => e.Id == Id).ToList().First();
            ViewBag.Phone = phone;
            return View();
        }
    }
}