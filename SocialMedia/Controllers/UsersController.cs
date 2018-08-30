namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Data.Models;
    using SocialMedia.Models.ManageViewModels;
    using SocialMedia.Services.Common.Interfaces;
    using System;
    using System.Threading.Tasks;

    public class UserController : Controller
    {
        private readonly IUserService userService;

        private readonly UserManager<User> userManager;

        public UserController(IUserService userService, UserManager<User> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(string id)
        {
            if (id == null)
            {
                id = userService.GetUserId(User.Identity.Name);
            }
            var user = userService.GetUser(id);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            var model = new IndexViewModel
            {
                Username = user.UserName,
                Name = user.Name,
                ProfileImage = user.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(user.ProfilePicture)),
                Pictures = userService.GetMyPictures(user.Id),
                UserId = user.Id,
                FollowInfo = userService.IsFollowed(id, User.Identity.Name)
            };

            return View(model);
        }
    }
}
