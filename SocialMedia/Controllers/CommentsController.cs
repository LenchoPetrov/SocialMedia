namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Services.Common.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CommentsController : Controller
    {
        private readonly ICommentService comments;

        public CommentsController(ICommentService comments)
        {
            this.comments = comments;
        }

        [HttpPost]
        public void Create(int pictureId, string commentContent)
        {
            comments.CreateComment(pictureId, commentContent, User.Identity.Name);
            //return RedirectToAction("Index", "Pictures", new { id = pictureId });
        }

        public IActionResult Delete(int commentId, int pictureId)
        {
            comments.DeleteComment(commentId);
            return RedirectToAction("Index", "Pictures", new { id = pictureId });
        }
    }
}
