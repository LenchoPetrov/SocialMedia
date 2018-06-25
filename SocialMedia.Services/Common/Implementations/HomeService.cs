namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HomeService : IHomeService
    {
        private readonly SocialMediaDbContext db;

        public HomeService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public HomeViewModel GetAllPictures(string username)
        {
            var user1 = this.db.Users.FirstOrDefault(u => u.UserName == username);
            var followedIds = this.db.Followers.Where(f => f.UserId == user1.Id).Select(f => f.FollowedId).ToHashSet();
            followedIds.Add(user1.Id);
            var pictures = this.db.Pictures.Where(p => followedIds.Contains(p.OwnerId)).ToHashSet();
            var result = new HashSet<IndexPicture>();

            foreach (var pic in pictures)
            {
                var userId = this.db.Albums.FirstOrDefault(u => u.Id == pic.AlbumId).UserId;
                var user = this.db.Users.FirstOrDefault(u => u.Id == userId);
                var comments = this.db.Comments.Where(c => c.PictureId == pic.Id).Select(c => new CommentIndex
                {
                    Id = c.Id,
                    Content = c.Content,
                    Name = this.db.Users.FirstOrDefault(u => u.Id == c.UserId).Name,
                    UserProfileImage = this.db.Users.FirstOrDefault(u => u.Id == c.UserId).ProfilePicture == null ?
                        null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Users.FirstOrDefault(u => u.Id == c.UserId).ProfilePicture)),
                    PublishDate = c.PublishDate,
                    UserId = c.UserId,
                    UserName = this.db.Users.FirstOrDefault(u => u.Id == c.UserId).UserName,
                    PictureOwnerUserName = user.UserName,
                    PictureId = c.PictureId
                }).ToList();
                var picture = new IndexPicture
                {
                    Name = user.Name,
                    UserName = user.UserName,
                    UserProfilePhoto = user.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(user.ProfilePicture)),
                    Id = pic.Id,
                    Description = pic.Description,
                    PublishDate = pic.PublishDate,
                    Comments = comments,
                    UserId = userId,
                    Photo = pic.Photo == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(pic.Photo))
                };
                result.Add(picture);
            }
            var home = new HomeViewModel
            {
                Pictures = result
            };

            return home;
        }
    }
}
