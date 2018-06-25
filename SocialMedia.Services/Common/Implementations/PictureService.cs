namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PictureService : IPictureService
    {
        private readonly SocialMediaDbContext db;

        public PictureService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public bool CreatePicture(string description, byte[] fileContents, int albumId)
        {
            try
            {
                var album = this.db.Albums.FirstOrDefault(a => a.Id == albumId);
                var user = this.db.Users.FirstOrDefault(u => u.Id == album.UserId);
                var picture = new Picture
                {
                    Description = description,
                    PublishDate = DateTime.UtcNow,
                    AlbumId = albumId,
                    Album = album,
                    Photo = fileContents,
                    OwnerId = user.Id,
                    Owner = user
                };

                this.db.Add(picture);
                this.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeletePicture(int id)
        {
            var pictrure = this.db.Pictures.FirstOrDefault(p => p.Id == id);
            var comments = this.db.Comments.Where(c => c.PictureId == id);
            var album = this.db.Albums.FirstOrDefault(a => a.Id == pictrure.AlbumId);
            this.db.RemoveRange(comments);
            this.db.SaveChanges();
            this.db.Remove(pictrure);
            this.db.SaveChanges();

            if (!this.db.Pictures.Any(p => p.AlbumId == album.Id))
            {
                this.db.Remove(album);
                this.db.SaveChanges();
            }
        }

        public void EditPicture(int id, string description)
        {
            var picture = this.db.Pictures.FirstOrDefault(a => a.Id == id);
            picture.Description = description;

            this.db.Update(picture);
            this.db.SaveChanges();
        }

        public string GetUserId(int id)
        {
            return this.db.Albums.FirstOrDefault(a => a.Id == this.db.Pictures.FirstOrDefault(p => p.Id == id).AlbumId).UserId;
        }

        public IEnumerable<Album> GetAllAlbums(string name)
        {
            var userId = this.db.Users.FirstOrDefault(u => u.UserName == name).Id;
            return this.db.Albums.Where(a => a.UserId == userId).ToList();
        }

        public IndexPicture GetPicture(int id)
        {
            var picture = this.db.Pictures.FirstOrDefault(u => u.Id == id);
            var userId = this.db.Albums.FirstOrDefault(a => a.Id == picture.AlbumId).UserId;
            var user = this.db.Users.FirstOrDefault(u => u.Id == userId);
            var comments = this.db.Comments.Where(c => c.PictureId == id).Select(c => new CommentIndex
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
            return new IndexPicture
            {
                Id = picture.Id,
                Description = picture.Description,
                PublishDate = picture.PublishDate,
                Comments = comments,
                Name = user.Name,
                UserName = user.UserName,
                UserProfilePhoto = user.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(user.ProfilePicture)),
                AlbumId = picture.AlbumId,
                UserId = user.Id,
                Photo = picture.Photo == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(picture.Photo)),
                PhotoToBytes = picture.Photo
            };
        }

        public PictureInfo GetPictureInfo(int id)
        {
            var picture = this.db.Pictures.FirstOrDefault(u => u.Id == id);
            return new PictureInfo
            {
                Description = picture.Description,
                PublishDate = picture.PublishDate,
                AlbumName = this.db.Albums.FirstOrDefault(p => p.Id == picture.AlbumId).Title
            };
        }

        public bool UserIsOwner(int id, string name)
        {
            var albumId = this.db.Pictures.FirstOrDefault(u => u.Id == id).AlbumId;
            var userId = this.db.Albums.FirstOrDefault(u => u.Id == albumId).UserId;
            var user = this.db.Users.FirstOrDefault(u => u.Id == userId);
            if (user.UserName == name)
                return true;

            return false;
        }
    }
}
