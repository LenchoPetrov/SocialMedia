namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using System;
    using System.Linq;

    public class CommentService : ICommentService
    {
        private readonly SocialMediaDbContext db;

        public CommentService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public void CreateComment(int pictureId, string commentContent, string name)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == name);
            var picture = this.db.Pictures.FirstOrDefault(u => u.Id == pictureId);

            var comment = new Comment
            {
                UserId = user.Id,
                User = user,
                Content = commentContent,
                Picture = picture,
                PictureId = pictureId,
                PublishDate = DateTime.UtcNow
            };

            this.db.Add(comment);
            this.db.SaveChanges();

            user.Comments.Add(comment);
            picture.Comments.Add(comment);

            this.db.Update(user);
            this.db.Update(picture);
            this.db.SaveChanges();
        }

        public void DeleteComment(int commentId)
        {
            var comment = this.db.Comments.FirstOrDefault(u => u.Id == commentId);

            this.db.Remove(comment);
            this.db.SaveChanges();
        }
    }
}
