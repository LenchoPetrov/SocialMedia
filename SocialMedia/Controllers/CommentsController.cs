namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Services.Common.Interfaces;

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

        [HttpPost]
        public void Delete(int commentId, int pictureId)
        {
            comments.DeleteComment(commentId);
            //return RedirectToAction("Index", "Pictures", new { id = pictureId });
        }
    }
}
