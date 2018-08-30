namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Services.Common.Interfaces;

    public class FollowersController : Controller
    {
        private readonly IFollowerService followers;

        public FollowersController(IFollowerService followers)
        {
            this.followers = followers;
        }

        public IActionResult Add(string followedUserId)
        {
            followers.Follow(User.Identity.Name, followedUserId);
            return RedirectToAction("Index", "User", new { id = followedUserId });
        }

        public IActionResult Remove(string followedUserId)
        {
            followers.Unfollow(User.Identity.Name, followedUserId);
            return RedirectToAction("Index", "User", new { id = followedUserId });
        }

        public IActionResult Followers(string UserId)
        {
            return View("Index", followers.GetAllFollowers(UserId));
        }

        public IActionResult Followed(string UserId)
        {
            return View("Index", followers.GetAllFollowed(UserId));
        }
    }
}
