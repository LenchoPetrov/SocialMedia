namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Models;
    using SocialMedia.Services.Common.Interfaces;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        private readonly IHomeService home;

        public HomeController(IHomeService home)
        {
            this.home = home;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(home.GetAllPictures(User.Identity.Name));
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
