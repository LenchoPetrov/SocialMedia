namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System.Linq;

    [Authorize]
    public class MessagesController : Controller
    {
        private readonly IMessageService messages;

        private readonly IUserService users;

        public MessagesController(IMessageService messages, IUserService users)
        {
            this.messages = messages;
            this.users = users;
        }

        public IActionResult Index()
        {
            return View(messages.TakeAllMyMessages(User.Identity.Name));
        }

        public IActionResult Message(string RecepientId, string SenderId)
        {
            return View(messages.TakeMessages(RecepientId, SenderId, User.Identity.Name));
        }

        public IActionResult Send()
        {
            var users = messages.GetAllUsers(User.Identity.Name).
               Select(r => new SelectListItem
               {
                   Text = r.Name + "(" + r.UserName + ")",
                   Value = r.Id
               })
               .ToList();

            return View(new SendMessage
            {
                Users = users
            });
        }

        [HttpPost]
        public IActionResult Send(SendMessage model)
        {
            messages.SendMessage(User.Identity.Name, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Answer(SendMessage model)
        {
            messages.SendMessage(User.Identity.Name, model);

            return RedirectToAction(nameof(Message), new { RecepientId = model.RecepientId, SenderId = users.GetUserId(User.Identity.Name) });
        }
    }
}