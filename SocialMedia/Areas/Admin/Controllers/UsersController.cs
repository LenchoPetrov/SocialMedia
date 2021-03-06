﻿namespace SocialMedia.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SocialMedia.Areas.Admin.Models;
    using SocialMedia.Controllers;
    using SocialMedia.Data.Models;
    using SocialMedia.Infrastructure;
    using SocialMedia.Services.Admin.Interfaces;
    using SocialMedia.Services.Admin.Models;
    using SocialMedia.Services.Common.Interfaces;
    using System.Linq;
    using System.Threading.Tasks;

    [Area("Admin")]
    [Authorize(Roles = GlobalConstants.AdministratorRole)]
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        private readonly IAdminService admins;

        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        public UsersController(IAdminService admins,
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager,
            IUserService userService,
            SignInManager<User> signInManager
            )
        {
            this.admins = admins;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.userService = userService;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var roles = roleManager.Roles.
                Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                })
                .ToList();
            var users = this.admins.All();
            return View(new AdminUsersViewModel
            {
                Users = users,
                Roles = roles
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddToRole(AddUserToFormModel model)
        {
            var roleExists = await this.roleManager.RoleExistsAsync(model.Role);
            var user = await this.userManager.FindByIdAsync(model.UserId);
            var userExists = user != null;
            if (!roleExists || !userExists)
            {
                ModelState.AddModelError(string.Empty, "invalid identity detail");
            }

            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Index));

            await this.userManager.AddToRoleAsync(user, model.Role);

            TempData["SuccessMessage"] = $"User {user.UserName} added to role {model.Role}";

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(string id)
        {
            return View(this.admins.GetUserDelete(id));
        }

        [HttpPost]
        public IActionResult Delete(DeleteUserViewModel model)
        {
            var userId = userService.GetUserId(User.Identity.Name);
            var takenId = model.Id;
            this.admins.DeleteUser(model.Id);
            if (takenId == userId)
            {
                signInManager.SignOutAsync();
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            return View(this.admins.GetUserEdit(id));
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel model)
        {
            this.admins.EditUser(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
