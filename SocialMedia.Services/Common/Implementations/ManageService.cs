namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ManageService : IManageService
    {
        private readonly SocialMediaDbContext db;

        public ManageService(SocialMediaDbContext db)
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

        public bool ChangePicture(byte[] profilePicture, string name)
        {
            try
            {
                var user = this.db.Users.FirstOrDefault(u => u.UserName == name);
                user.ProfilePicture = profilePicture;

                this.db.Update(user);
                this.db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public void SetName(string id, string name)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == id);
            user.Name = name;

            this.db.Update(user);
            this.db.SaveChanges();
        }
    }
}
