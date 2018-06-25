namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Linq;

    public class AlbumService : IAlbumService
    {
        private readonly SocialMediaDbContext db;

        public AlbumService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public int CreateAlbum(string title, string username)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == username);

            var album = new Album
            {
                Title = title,
                User = user,
                UserId = user.Id
            };

            this.db.Add(album);
            this.db.SaveChanges();

            return album.Id;
        }

        public void DeleteAlbum(int id)
        {
            var album = this.db.Albums.FirstOrDefault(a => a.Id == id);
            var pictures = this.db.Pictures.Where(a => a.AlbumId == id).ToHashSet();
            foreach (var picture in pictures)
            {
                var comments = this.db.Comments.Where(c => c.PictureId == picture.Id).ToHashSet();
                this.db.RemoveRange(comments);
                this.db.SaveChanges();
            }
            this.db.RemoveRange(pictures);
            this.db.SaveChanges();

            this.db.Remove(album);
            this.db.SaveChanges();
        }

        public void EditAlbum(int id, string title)
        {
            var album = this.db.Albums.FirstOrDefault(a => a.Id == id);
            album.Title = title;

            this.db.Update(album);
            this.db.SaveChanges();
        }

        public string GetAlbumTitle(int albumId)
        {
            return this.db.Albums.FirstOrDefault(a => a.Id == albumId).Title;
        }

        public UserAlbums GetAllAlbums(string id)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == id);
            return new UserAlbums
            {
                UserName = user.UserName,
                Albums = this.db.Albums.Where(a => a.UserId == user.Id).Select(a => new AlbumInfo
                {
                    Id = a.Id,
                    Title = a.Title,
                    AlbumProfileImage = this.db.Pictures.FirstOrDefault(p => p.Id == a.AlbumProfileImageId).Photo == null ?
                        null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Pictures.FirstOrDefault(p => p.Id == a.AlbumProfileImageId).Photo))
                }).ToList()
            };
        }

        public PicturesAlbum GetAllPicturesForThisAlbum(int id)
        {
            var pictures = this.db.Pictures.Where(u => u.AlbumId == id).ToHashSet();
            var album = this.db.Albums.FirstOrDefault(u => u.Id == id);
            var user = this.db.Users.FirstOrDefault(u => u.Id == album.UserId);
            return new PicturesAlbum { Pictures = pictures, AlbumName = album.Title, AlbumId = id, UserName = user.UserName };
        }

        public int GetPicturesCount(int albumId)
        {
            return this.db.Albums.FirstOrDefault(u => u.Id == albumId).Pictures.Count;
        }

        public string GetUserId(int albumId)
        {
            return this.db.Albums.FirstOrDefault(u => u.Id == albumId).UserId;
        }

        public void SetAlbumPicture(int photoId, int albumId)
        {
            var album = this.db.Albums.FirstOrDefault(a => a.Id == albumId);
            album.AlbumProfileImageId = photoId;

            this.db.Update(album);
            this.db.SaveChanges();
        }

        public bool UserIsOwner(int id, string name)
        {
            var userId = this.db.Albums.FirstOrDefault(u => u.Id == id).UserId;
            var user = this.db.Users.FirstOrDefault(u => u.Id == userId);
            if (user.UserName == name)
                return true;

            return false;
        }
    }
}
