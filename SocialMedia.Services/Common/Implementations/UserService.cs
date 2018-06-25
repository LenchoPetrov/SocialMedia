namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly SocialMediaDbContext db;

        public UserService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public HashSet<IndexPicture> GetMyPictures(string id)
        {
            var albumsId = this.db.Albums.Where(a => a.UserId == id).Select(a => a.Id).ToList();
            var pictures = this.db.Pictures.Where(p => albumsId.Contains(p.AlbumId)).ToHashSet();
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
                    Id = pic.Id,
                    Description = pic.Description,
                    PublishDate = pic.PublishDate,
                    Comments = comments,
                    UserId = userId,
                    UserProfilePhoto = user.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(user.ProfilePicture)),
                    Photo = pic.Photo == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(pic.Photo))
                };
                result.Add(picture);
            }

            return result;
        }

        public User GetUser(string id)
        {
            return this.db.Users.FirstOrDefault(u => u.Id == id);
        }

        public string GetUserId(string name)
        {
            return this.db.Users.FirstOrDefault(u => u.UserName == name).Id;
        }

        public FollowInfo IsFollowed(string id, string username)
        {
            var info = new FollowInfo
            {
                Followers = this.db.Followers.Where(f => f.FollowedId == id).Count(),
                Followed = this.db.Followers.Where(f => f.UserId == id).Count()
            };
            var user = this.db.Users.FirstOrDefault(u => u.UserName == username);
            if (this.db.Followers.Any(f => f.FollowedId == id && f.UserId == user.Id))
                info.Follow = true;
            else
                info.Follow = false;

            return info;
        }
    }
}
