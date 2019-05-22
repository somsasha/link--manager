using System.Diagnostics;
using LinkManager.DAL.Context;
using LinkManager.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using LinkManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LinkManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _db;
        private UserManager<User> _userManager; 

        public HomeController(ApplicationDbContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Links");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
