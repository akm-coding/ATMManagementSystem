using ATMManagement.MvcApp.Models;
using ATMManagement.MvcApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ATMManagement.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserService _userService;

        public HomeController(ILogger<HomeController> logger,UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult UserLogin(UserModel userModel)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ActionName("Register")]
        [HttpPost]
        public IActionResult UserRegister(UserModel userModel)
        {
            int result = _userService.SaveUser(userModel);
            if (result > 0) 
            {
                return Redirect("/home/login");
            }
            return Redirect("/home/register");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}