using contactii2.Data;
using contactii2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Diagnostics;

//added from contactscontroller to be able to view the data in homepage 
namespace contactii2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager; //user
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {

            _logger = logger;
            _context = context; //user
            _userManager = userManager; //user
            
        }
        private Task<IdentityUser?> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }//user
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            if (user == null) //when theres no users logged in
            {
                return View();
            } 
            var applicationDbContext = _context.Contact.Include(c => c.Categorie).Where((f => f.Username == user.UserName));
            var count = applicationDbContext.Count();
            ViewData["count"] = count;
            return View(await applicationDbContext.ToListAsync());
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
    }
}
