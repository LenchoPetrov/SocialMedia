namespace SocialMedia.Tests
{
    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Implementations;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public class Tests
    {
        private SocialMediaDbContext GetDatabase()
        {
            var dbOptions = new DbContextOptionsBuilder<SocialMediaDbContext>()
                                      .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                      .Options;

            return new SocialMediaDbContext(dbOptions);
        }

        // AlbumService Tests
        [Fact]
        public async Task GetAlbumTitleService()
        {
            //Arange
            var db = GetDatabase();
            var album = new Album { Id = 1, Title = "Test" };

            db.Add(album);
            db.SaveChanges();

            //Act
            var albumService = new AlbumService(db);
            var result = albumService.GetAlbumTitle(album.Id);

            //Assert
            result.Should()
                .Match(album.Title);
        }



        [Fact]
        public async Task DeleteAlbumService()
        {
            //Arange
            var db = GetDatabase();
            var album = new Album { Id = 1, Title = "Test" };
            var album2 = new Album { Id = 2, Title = "Test2" };

            db.AddRange(album, album2);
            db.SaveChanges();

            //Act
            var albumService = new AlbumService(db);

            albumService.DeleteAlbum(1);
            var result = db.Albums.ToHashSet();
            
            //Assert
            result.Should()
                .Match(a => a.ElementAt(0).Id == 2)
                .And
                .HaveCount(1);
        }

        [Fact]
        public async Task EditAlbumService()
        {
            //Arange
            var db = GetDatabase();
            var album = new Album { Id = 1, Title = "Test" };

            db.Add(album);
            db.SaveChanges();

            //Act
            var albumService = new AlbumService(db);
            
            albumService.EditAlbum(1, "Edit Album");
            var result = db.Albums.ToHashSet();

            //Assert
            result.Should()
                .Match(a => a.ElementAt(0).Title == "Edit Album");
        }

        [Fact]
        public async Task GetAllAlbumsService()
        {
            //Arange
            var db = GetDatabase();
            var albumService = new AlbumService(db);
            var user = new User()
            {
                UserName = "User",
                Email = "user@mail.bg"
            };
            db.Add(user);
            db.SaveChanges();

            var album = new Album { Id = 1, Title = "New Album", UserId = user.Id };
            var album2 = new Album { Id = 2, Title = "Test", UserId = user.Id };
            db.AddRange(album, album2);
            db.SaveChanges();

            //Act
            var userAlbums = albumService.GetAllAlbums(user.Id);

            //Assert
            userAlbums.Albums.Should()
               .Match(a => a.ElementAt(0).Id == 1)
               .And
               .Match(a => a.ElementAt(0).Title == "New Album")
               .And
               .Match(a => a.ElementAt(1).Id == 2)
               .And
               .Match(a => a.ElementAt(1).Title == "Test")
               .And
               .HaveCount(2);
        }

        [Fact]
        public async Task GetAllPicturesForThisAlbumService()
        {
            //Arange
            var db = GetDatabase();
            var albumService = new AlbumService(db);
            var user = new User()
            {
                UserName = "User",
                Email = "user@mail.bg"
            };
            db.Add(user);
            db.SaveChanges();

            var album = new Album { Id = 1, Title = "Test", UserId = user.Id };
            db.Add(album);
            db.SaveChanges();
            var picture = new Picture()
            {
                Id = 1,
                AlbumId = album.Id,
                Description = "Some",
                PublishDate = DateTime.UtcNow
            };
            db.Add(picture);
            db.SaveChanges();

            //Act
            var userAlbumPictures = albumService.GetAllPicturesForThisAlbum(album.Id);

            //Assert
            userAlbumPictures.AlbumName.Should()
               .Match(album.Title);

            userAlbumPictures.Pictures.Should()
               .Match(p => p.ElementAt(0).Description == picture.Description)
               .And
               .Match(p => p.ElementAt(0).Id == picture.Id);

            userAlbumPictures.AlbumId.ToString().Should()
               .Match(album.Id.ToString());
        }


        [Fact]
        public async Task GetPicturesCountService()
        {
            //Arange
            var db = GetDatabase();
            var albumService = new AlbumService(db);
            var user = new User()
            {
                UserName = "User",
                Email = "user@mail.bg"
            };
            db.Add(user);
            db.SaveChanges();

            var album = new Album { Id = 1, Title = "Test", UserId = user.Id };
            db.Add(album);
            db.SaveChanges();
            var picture = new Picture()
            {
                Id = 1,
                AlbumId = album.Id,
                Description = "Some",
                PublishDate = DateTime.UtcNow
            };
            db.Add(picture);
            db.SaveChanges();

            //Act
            var result = albumService.GetPicturesCount(album.Id);

            //Assert
            result.ToString().Should()
               .Match(1.ToString());
        }

        //CommentsService Tests
        [Fact]
        public async Task CreateCommentService()
        {
            //Arange
            var db = GetDatabase();
            var commentService = new CommentService(db);
            var picture = new Picture()
            {
                Id = 1,
                Description = "Some",
                PublishDate = DateTime.UtcNow
            };

            var user = new User()
            {
                UserName = "User",
                Email = "user@mail.bg"
            };

            db.Add(user);
            db.SaveChanges();
            db.Add(picture);
            db.SaveChanges();

            //Act
            commentService.CreateComment(picture.Id, "Comment", user.UserName);

            var comments = db.Comments.ToHashSet();

            //Assert
            comments.Should()
              .Match(c => c.ElementAt(0).Content == "Comment")
              .And
              .Match(c => c.ElementAt(0).PictureId == picture.Id)
              .And
              .Match(c => c.ElementAt(0).UserId == user.Id);
        }

        [Fact]
        public async Task DeleteCommentService()
        {
            //Arange
            var db = GetDatabase();
            var commentService = new CommentService(db);

            var comment = new Comment
            {
                Id = 1,
                Content = "Some Content"
            };
            var comment1 = new Comment
            {
                Id = 2,
                Content = "Second Comment"
            };

            db.AddRange(comment, comment1);
            db.SaveChanges();

            //Act
            commentService.DeleteComment(1);

            var list = db.Comments.ToHashSet();

            //Assert
            list.Should()
              .Match(a => a.ElementAt(0).Content == comment1.Content)
              .And
              .HaveCount(1);
        }

        //PictureService Tests
        [Fact]
        public async Task DeletePictureService()
        {
            //Arange
            var db = GetDatabase();
            var pictureService = new PictureService(db);

            var picture1 = new Picture()
            {
                Id = 1,
                Description = "Picture"
            };

            var picture2 = new Picture()
            {
                Id = 2,
                Description = "Picture2"
            };

            db.AddRange(picture1, picture2);
            db.SaveChanges();

            //Act
            pictureService.DeletePicture(1);

            var list = db.Pictures.ToHashSet();

            //Assert
            list.Should()
               .Match(p => p.ElementAt(0).Description == "Picture2")
               .And
               .HaveCount(1);
        }


        [Fact]
        public async Task EditPictureService()
        {
            //Arange
            var db = GetDatabase();
            var pictureService = new PictureService(db);

            var picture1 = new Picture()
            {
                Id = 1,
                Description = "Picture"
            };

            db.Add(picture1);
            db.SaveChanges();
           
            //Act
            pictureService.EditPicture(1, "New Picture");

            var list = db.Pictures.ToHashSet();

            //Assert
            list.Should()
               .Match(p => p.ElementAt(0).Description == "New Picture");
        }


        [Fact]
        public async Task GetPictureService()
        {
            //Arange
            var db = GetDatabase();
            var pictureService = new PictureService(db);

            var user = new User()
            {
                UserName = "gosh21",
                Name = "gosh"
            };
            db.Add(user);
            db.SaveChanges();

            var album = new Album()
            {
                Id = 1,
                Title = "Album",
                UserId = user.Id,
                User = user
            };
            db.Add(album);
            db.SaveChanges();

            var picture1 = new Picture()
            {
                Id = 1,
                Description = "Picture",
                AlbumId = album.Id,
                Album = album
            };

            db.Add(picture1);
            db.SaveChanges();

            var comment = new Comment()
            {
                Id = 1,
                Content = "Some",
                PictureId = picture1.Id,
                Picture = picture1
            };

            db.Add(comment);
            db.SaveChanges();

            //Act
            var pic = pictureService.GetPicture(1);

            //Assert
            pic.Description.Should()
               .Match(picture1.Description);

            pic.Id.ToString().Should()
               .Match(picture1.Id.ToString());

            pic.Name.Should()
               .Match(user.Name);

            pic.Comments.Should()
               .Match(c => c.ElementAt(0).Content == comment.Content)
               .And
               .HaveCount(1);
        }


        [Fact]
        public async Task GetPictureInfoService()
        {
            //Arange
            var db = GetDatabase();
            var pictureService = new PictureService(db);

            var album = new Album()
            {
                Id = 1,
                Title = "Album"
            };

            db.Add(album);
            db.SaveChanges();
            
            var picture1 = new Picture()
            {
                Id = 1,
                Description = "Picture",
                AlbumId = album.Id
            };

            db.Add(picture1);
            db.SaveChanges();

            //Act
            var pic = pictureService.GetPictureInfo(1);

            //Assert
            pic.Description.Should()
               .Match(picture1.Description);

            pic.AlbumName.Should()
               .Match(album.Title);
        }
    }
}
