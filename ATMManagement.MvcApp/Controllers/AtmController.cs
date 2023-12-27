using ATMManagement.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATMManagement.MvcApp.Controllers
{
    public class AtmController : Controller
    {
        private readonly AppDbContext _context;
        public AtmController(AppDbContext dbContext)
        {
             _context = dbContext;
        }

        [ActionName("account-detail")]
        public IActionResult AccountDetail()
        {
            return View("AccountDetail");
        }
    }
}
